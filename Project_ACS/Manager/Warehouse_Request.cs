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
    public partial class Warehouse_Request : Form
    {
        public Warehouse_Request()
        {
            InitializeComponent();
            loadBarang();
            loadWarehouse();
            lblTotal.Text = totalCart + "";
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet dataset = new DataSet();
        string querystr = "";
        int totalCart = 0;

        void loadWarehouse()
        {
            cmbWarehouse.Items.Clear();
            cmbWarehouse.Items.Add("");
            dataset = new DataSet();
            querystr = "SELECT ID, INITCAP(NAMA) AS \"NAMA\" FROM WAREHOUSE WHERE ID != :0 AND STATUS = 1";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "WAREHOUSE");
            cmbWarehouse.DataSource = dataset.Tables["WAREHOUSE"]; 
            cmbWarehouse.ValueMember = "ID"; 
            cmbWarehouse.DisplayMember = "NAMA"; 
            settingDgv();
        }

        public void settingDgv()
        {
            dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvBarang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvBarang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column1 = dgvBarang.Columns[0];
            column1.Width = 70;
            DataGridViewColumn column3 = dgvBarang.Columns[2];
            column3.Width = 55;
            DataGridViewColumn column5 = dgvBarang.Columns[3];
            column5.Width = 140;
            dgvBarang.Columns[3].Visible = false;

            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column2 = dgvCart.Columns[0];
            column2.Width = 70;
            DataGridViewColumn column4 = dgvCart.Columns[2];
            column4.Width = 100;
        }

        public void loadBarang()
        {
            dgvBarang.Columns.Clear();
            dataset = new DataSet();
            querystr = "SELECT DISTINCT B.KODE AS KODE, B.NAMA AS NAMA, BW.QTY AS QTY, B.ID FROM BARANG B, BARANG_WAREHOUSE BW, WAREHOUSE W WHERE B.ID = BW.ID_BARANG AND BW.ID_WAREHOUSE = :0";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "BARANG");
            dgvBarang.DataMember = "BARANG";
            dgvBarang.DataSource = dataset;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvBarang.Columns.Add(btn);
            btn.HeaderText = "TAMBAH";
            btn.Text = "Tambah";
            btn.Name = "btn";
            //btn.FlatStyle = FlatStyle.Popup;
            //btn.DefaultCellStyle.BackColor = Color.FromArgb(0, 255, 153);
            //btn.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            btn.UseColumnTextForButtonValue = true;

            //dataset = new DataSet();
            //querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY AS Qty FROM BARANG WHERE 1=2";
            //DB.executeDataSet(dataset, querystr, null, "CART");
            //dgvCart.DataMember = "CART";
            //dgvCart.DataSource = dataset;
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            //String tgl = dtp1.Value.ToString("dd-M-yyyy");
            //MessageBox.Show(tgl);
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbWarehouse.SelectedValue.ToString());
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int jumlah = Convert.ToInt32(dgvBarang.Rows[e.RowIndex].Cells[3].Value);
                string kode = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nama = dgvBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                int qty = Convert.ToInt32(nudQty.Value);
                //MessageBox.Show(kode + " " + nama);

                int idxAda = -1;
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    if (dgvCart.Rows[i].Cells[0].Value.ToString() == kode)
                    {
                        idxAda = i;
                        break;
                    }
                }

                if (qty > 0)
                {
                    if (idxAda == -1)
                    {
                        if (qty > jumlah)
                        {
                            MessageBox.Show("Quantity melebihi stok persediaan!", "Error!");
                        }
                        else
                        {
                            dgvCart.Rows.Add(kode, nama, qty, dgvBarang.Rows[e.RowIndex].Cells[4].Value.ToString());
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dgvCart.Rows[idxAda].Cells[2].Value) + qty > jumlah)
                        {
                            MessageBox.Show("Quantity akan melebihi stok persediaan!", "Error!");
                        }
                        else
                        {
                            dgvCart.Rows[idxAda].Cells[2].Value = Convert.ToInt32(dgvCart.Rows[idxAda].Cells[2].Value) + qty;
                        }
                    }
                    totalCart = 0;
                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        totalCart += Convert.ToInt32(dgvCart.Rows[i].Cells[2].Value);
                    }
                    lblTotal.Text = totalCart + "";
                }
                else
                {
                    MessageBox.Show("Quantity minimal 1!", "Error!");
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0")
            {
                MessageBox.Show("Tidak ada barang yang akan dipindah!", "Error!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Konfirmasi Pindah Barang?", "Yakin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string querystr = "SELECT LPAD(COUNT(*) + 1, 4, '0') FROM H_PINDAH";
                    string kode = DB.executeScalar(querystr, null).ToString();
                    //MessageBox.Show(kode);
                    kode = "HP" + kode;
                    string asal = User.User_login.Id_warehouse;
                    string tujuan = cmbWarehouse.SelectedValue.ToString();

                    dataset = new DataSet();
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { kode, "varchar" });
                    listParam.Add(new object[] { asal, "int32" });
                    listParam.Add(new object[] { tujuan, "int32" });
                    listParam.Add(new object[] { lblTotal.Text, "int32" });
                    listParam.Add(new object[] { System.DateTime.Now.Date, "date" });
                    listParam.Add(new object[] { 0, "int32" });
                    querystr = "INSERT INTO H_PINDAH VALUES(:0, :1, :2, :3, :4, :5)";
                    DB.executeQuery(querystr, listParam);

                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        listParam.Clear();
                        listParam.Add(new object[] { kode, "varchar" });
                        listParam.Add(new object[] { dgvCart.Rows[i].Cells[3].Value.ToString(), "int32" });
                        listParam.Add(new object[] { dgvCart.Rows[i].Cells[2].Value.ToString(), "int32" });
                        querystr = "INSERT INTO D_PINDAH VALUES(:0, :1, :2)";
                        DB.executeQuery(querystr, listParam);
                    }

                    MessageBox.Show("Berhasil Request!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCart.Rows.Clear();
                    lblTotal.Text = "0";
                }
            }
        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCart.Rows.RemoveAt(e.RowIndex);
            totalCart = 0;
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                totalCart += Convert.ToInt32(dgvCart.Rows[i].Cells[2].Value);
            }
            lblTotal.Text = totalCart + "";
        }
    }
}
