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
    public partial class Delivery_Masuk : Form
    {
        public Delivery_Masuk()
        {
            InitializeComponent();
            loadmasuk();
            
        }

        public Panel getPl()
        {
            return pl;
        }
        DataSet dataset;
        string querystr = "";

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
            label9.Text = "0";
        }
        void settingDgv()
        {
            
            dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvBarang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvBarang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column1 = dgvBarang.Columns[0];
            column1.Width = 70;

            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column12 = dgvCart.Columns[0];
            column12.Width = 100;

        }

        void loaddgv()
        {
            dataset = new DataSet();
            querystr = $"SELECT B.KODE as Kode , B.NAMA AS Nama FROM BARANG B";
            DB.executeDataSet(dataset, querystr, null, "ORDER");
            dgvBarang.DataSource = dataset.Tables["ORDER"];

            

            dataset = new DataSet();
            querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY || ' Dus' AS Qty FROM BARANG WHERE 1=2";
            DB.executeDataSet(dataset, querystr, null, "BARANG");
            
            dgvCart.DataSource = dataset.Tables["BARANG"];
        }
        private void Delivery_Masuk_Load(object sender, EventArgs e)
        {

        }
        int idx = -1;
        private void dgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            
        }
        int totalbarang = 0;
        private void bunifuButton1_Click(object sender, EventArgs e)
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
                    dgvCart.Rows[exist].Cells[2].Value = Convert.ToInt32(dgvCart.Rows[exist].Cells[2].Value.ToString()) + Convert.ToInt32(nudQty.Value) ;
                }
                else
                {
                    if (nudQty.Value != 0)
                    {
                        dataset.Tables["BARANG"].Rows.Add(dgvBarang.Rows[idx].Cells[0].Value.ToString(), dgvBarang.Rows[idx].Cells[1].Value.ToString(), Convert.ToInt32(nudQty.Value));

                        dgvCart.DataSource = dataset.Tables["BARANG"];
                    }
                    else
                    {
                        MessageBox.Show("Quantity tidak boleh 0!");
                    }
                }
            }
            totalbarang = 0;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (totalbarang == 0)
            {
                MessageBox.Show("Tidak ada barang yang dibeli!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Konfirmasi Beli Barang?", "Yakin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String tanggal = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                    String hari = tanggal.Substring(0, 2);
                    String bulan = tanggal.Substring(3, 2);
                    String tahun = tanggal.Substring(6, 4);
                    string count = (string)DB.executeScalar($"select count(*) from H_ORDER_SUPPLIER WHERE KODE LIKE 'HO{hari + bulan + tahun}%'",null).ToString();
                    int countdown = Convert.ToInt32(count) + 1;
                    
                    String kode = "HO" + hari + bulan + tahun;
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
                    String eta = Convert.ToString(dt_picker.Value.ToString("dd/MM/yyyy"));
                    querystr = $"INSERT INTO H_ORDER_SUPPLIER VALUES('{kode}',{cbb_partner.SelectedIndex+1},TO_DATE('{eta}', 'DD/MM/YYYY'),1,{totalbarang},{User.User_login.Id_warehouse},0)";
                    DB.executeQuery(querystr, null);
                    for (int l = 0; l < dgvCart.Rows.Count; l++)
                    {
                        String idbarang = (string)DB.executeScalar($"select ID from Barang WHERE NAMA = '{dgvCart.Rows[l].Cells[1].Value.ToString()}'" , null).ToString();
                        querystr = $"INSERT INTO D_ORDER_SUPPLIER VALUES('{kode}',{idbarang},{dgvCart.Rows[l].Cells[2].Value.ToString()})";
                        DB.executeQuery(querystr, null);
                        
                    }
                    MessageBox.Show("Berhasil Insert!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                    totalbarang = 0;
                    label9.Text = totalbarang.ToString();
                }
            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataset.Tables["BARANG"].Rows.Clear();
            totalbarang = 0;
            label9.Text = totalbarang.ToString();
        }
         

        private void dgvCart_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        { 
            int idx = e.RowIndex;

            dataset.Tables["BARANG"].Rows.RemoveAt(idx);

            dgvCart.DataSource = dataset.Tables["BARANG"];
        }
    }
}
