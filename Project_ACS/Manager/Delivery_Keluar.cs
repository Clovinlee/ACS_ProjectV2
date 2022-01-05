using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ACS.Manager
{
    public partial class Delivery_Keluar : Form
    {
        public Delivery_Keluar()
        {
            InitializeComponent();
            InitializeComponent();
            loadmasuk();
        }
        DataSet dataset;
        string querystr = "";
        public Panel getPl()
        {
            return pl;
        }
        void loadmasuk()
        {
            cbb_partner.Items.Clear();
            cbb_partner.Items.Add("Semua");
            cbb_partner.SelectedIndex = 0;
            dataset = new DataSet();
            querystr = "SELECT NAMA FROM BUSINESS_PARTNER";
            DB.executeDataSet(dataset, querystr, null, "PARTNER");
            cbb_partner.DataSource = dataset.Tables["PARTNER"];
            cbb_partner.ValueMember = "NAMA";
            cbb_partner.DisplayMember = "NAMA";
            loaddgv();
            settingDgv();
        }

        void settingDgv()
        {
            //dgvWarehouse.Columns[3].Visible = false;
            dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvBarang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvBarang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);


            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);

        }

        void loaddgv()
        {
            dataset = new DataSet();
            querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY || ' Dus' AS Qty FROM BARANG";
            querystr = "SELECT DISTINCT B.KODE AS KODE, B.NAMA AS NAMA, BW.QTY || ' Dus' AS QTY FROM BARANG B, BARANG_WAREHOUSE BW, WAREHOUSE W WHERE B.ID = BW.ID_BARANG AND BW.ID_WAREHOUSE = :0";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "BARANG");
            dgvBarang.DataMember = "BARANG";
            dgvBarang.DataSource = dataset;

            

            dataset = new DataSet();
            querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY || ' Dus' AS Qty FROM BARANG WHERE 1=2";
            DB.executeDataSet(dataset, querystr, null, "BARANG");
            dgvCart.DataMember = "BARANG";
            dgvCart.DataSource = dataset;
        }

        private void Delivery_Keluar_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (totalbarang == 0)
            {
                MessageBox.Show("Tidak ada barang yang dibeli!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Konfirmasi Jual Barang?", "Yakin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String tanggal = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                    string count = (string)DB.executeScalar($"select count(*) from H_KELUAR_BARANG", null);
                    int countdown = Convert.ToInt32(count) + 1;
                    String kode = "HK";
                    if (countdown > 999)
                    {
                        kode += countdown.ToString();
                    }
                    else if (countdown > 99)
                    {
                        kode += "0" + countdown.ToString();
                    }
                    else if (countdown > 9)
                    {
                        kode += "00" + countdown.ToString();
                    }
                    else
                    {
                        kode += "000" + countdown.ToString();
                    }
                    querystr = $"INSERT INTO H_KELUAR_BARANG VALUES('{kode}',{cbb_partner.SelectedIndex + 1},TO_DATE('{Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"))}', 'DD/MM/YYYY'),{User.User_login.Id_warehouse})";
                    DB.executeQuery(querystr, null);
                    for (int l = 0; l < dgvCart.Rows.Count; l++)
                    {
                        String idbarang = (string)DB.executeScalar($"select ID from Barang WHERE NAMA = '{dgvCart.Rows[l].Cells[1].Value.ToString()}'", null).ToString();
                        querystr = $"INSERT INTO D_KELUAR_BARANG VALUES('{kode}',{idbarang},{dgvCart.Rows[l].Cells[2].Value.ToString()})";
                        DB.executeQuery(querystr, null);
                    }
                    MessageBox.Show("Berhasil Insert!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataset.Clear();
                    loaddgv();
                    totalbarang = 0;
                    label9.Text = totalbarang.ToString();
                }
            }
        }
        int idx = -1;
        int totalbarang = 0;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string kode = dgvBarang.Rows[idx].Cells[1].Value.ToString();
            int jumlah = Convert.ToInt32(dgvBarang.Rows[idx].Cells[3].Value);
            int qty = Convert.ToInt32(nudQty.Value);
            int idxAda = -1;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                if (dgvCart.Rows[i].Cells[0].Value.ToString() == kode)
                {
                    idxAda = i;
                    break;
                }
            }
            if (qty > jumlah)
            {
                MessageBox.Show("Quantity melebihi stok persediaan!", "Error!");
            }
            else
            {
                int exist = -1;
                if (idx != -1)
                {
                    for (int j = 0; j < dgvCart.Rows.Count; j++)
                    {
                        if (dgvBarang.Rows[idx].Cells[1].Value.ToString() == dgvCart.Rows[j].Cells[1].Value.ToString())
                        {
                            exist = j;
                        }
                    }
                    if (exist != -1)
                    {
                        dgvCart.Rows[exist].Cells[2].Value = Convert.ToInt32(dgvCart.Rows[exist].Cells[2].Value.ToString()) + Convert.ToInt32(nudQty.Value);
                    }
                    else
                    {
                        dataset.Tables["BARANG"].Rows.Add(dgvBarang.Rows[idx].Cells[0].Value.ToString(), dgvBarang.Rows[idx].Cells[1].Value.ToString(), Convert.ToInt32(nudQty.Value));

                        dgvCart.DataSource = dataset.Tables["BARANG"];
                    }
                }
            }
            for (int k = 0; k < dgvCart.Rows.Count; k++)
            {
                totalbarang += Convert.ToInt32(dgvCart.Rows[k].Cells[2].Value.ToString());
            }
            label9.Text = totalbarang.ToString();
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }
    }
}
