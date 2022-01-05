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
    public partial class Warehouse_Access : Form
    {
        public Warehouse_Access()
        {
            InitializeComponent();
            loadReq();
            getName();
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet dataset = new DataSet();
        string querystr = "";
        int idx = -1;

        public void loadReq()
        {
            dataset = new DataSet();
            querystr = "SELECT W1.NAMA AS ASAL, H.TOTAL_QTY || ' Dus' AS TOTAL, H.TANGGAL AS TANGGAL, H.KODE, H.ASAL AS KODE FROM H_PINDAH H, WAREHOUSE W1, WAREHOUSE W2 WHERE H.ASAL = W1.ID AND W2.ID = "+ User.User_login.Id_warehouse + " AND H.STATUS = 0 AND H.ASAL != " + User.User_login.Id_warehouse + "";
            //List<object[]> listParam = new List<object[]>();
            //listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, null, "WAREHOUSE");
            //dgvWarehouse.DataMember = "WAREHOUSE";
            dgvWarehouse.DataSource = dataset.Tables[0];
            settingDgv();
        }

        void settingDgv()
        {
            dgvWarehouse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvWarehouse.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvWarehouse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvWarehouse.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            //DataGridViewColumn column1 = dgvBarang.Columns[0];
            //column1.Width = 70;
            //DataGridViewColumn column3 = dgvBarang.Columns[2];
            //column3.Width = 55;
            //DataGridViewColumn column5 = dgvBarang.Columns[3];
            //column5.Width = 140;
            //dgvWarehouse.Columns[3].Visible = false;

            //dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            //dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            //dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            //dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            //DataGridViewColumn column2 = dgvCart.Columns[0];
            //column2.Width = 70;
            //DataGridViewColumn column4 = dgvCart.Columns[2];
            //column4.Width = 100;
        }

        void getName()
        {
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            string querynama = "SELECT NAMA FROM WAREHOUSE WHERE ID = :0";
            string nama = DB.executeScalar(querynama, listParam).ToString();
            lblWarehouse.Text = nama;
        }

        private void dgvWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetail.DataMember = null;
            dgvDetail.DataSource = null;
            dataset = new DataSet();
            idx = e.RowIndex;
            string kode = dgvWarehouse.Rows[idx].Cells[3].Value.ToString();
            querystr = "SELECT B.KODE AS KODE, B.NAMA AS NAMA, D.QTY AS QTY, B.ID FROM D_PINDAH D, BARANG B WHERE D.ID_BARANG = B.ID AND D.KODE_PINDAH = :0";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { kode, "varchar" });
            DB.executeDataSet(dataset, querystr, listParam, "BARANG");
            dgvDetail.DataMember = "BARANG";
            dgvDetail.DataSource = dataset;
            dgvDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvDetail.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvDetail.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            //dgvDetail.Columns[3].Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (idx == -1)
            {
                MessageBox.Show("Belum ada data yang dipilih!", "Error!");
            }
            else
            {
                selesaiReq("acc");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (idx == -1)
            {
                MessageBox.Show("Belum ada data yang dipilih!", "Error!");
            }
            else
            {
                selesaiReq("dec");
            }
        }

        void selesaiReq(string mode)
        {
            DialogResult dialogResult = MessageBox.Show("Konfirmasi persetujuan?", "Yakin?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (mode == "acc")
                {
                    //UBAH STATUS H_PINDAH
                    dataset = new DataSet();
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { dgvWarehouse.Rows[idx].Cells[3].Value.ToString(), "varchar" });
                    querystr = "UPDATE H_PINDAH SET STATUS = 1 WHERE KODE = :0";
                    DB.executeDataSet(dataset, querystr, listParam, "H_PINDAH");

                    //UPDATE STOK BARANG WAREHOUSE PENGIRIM
                    for (int i = 0; i < dgvDetail.Rows.Count; i++)
                    {
                        listParam.Clear();
                        listParam.Add(new object[] { dgvDetail.Rows[i].Cells[3].Value.ToString(), "int32" });
                        //listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
                        listParam.Add(new object[] { dgvWarehouse.Rows[idx].Cells[4].Value.ToString(), "int32" });
                        //AMBIL STOK LAMANYA DULU
                        querystr = "SELECT QTY FROM BARANG_WAREHOUSE WHERE ID_BARANG = :0 AND ID_WAREHOUSE = :1";
                        int qty = Convert.ToInt32(DB.executeScalar(querystr, listParam));
                        int qty_akhir = qty - Convert.ToInt32(dgvDetail.Rows[i].Cells[2].Value.ToString());
                        listParam.Add(new object[] { qty_akhir, "int32" });
                        querystr = "UPDATE BARANG_WAREHOUSE SET QTY = :2 WHERE ID_BARANG = :0 AND ID_WAREHOUSE = :1";
                        DB.executeDataSet(dataset, querystr, listParam, "BARANG_1");
                    }

                    //UPDATE STOK BARANG WAREHOUSE PENERIMA
                    for (int i = 0; i < dgvDetail.Rows.Count; i++)
                    {
                        listParam.Clear();
                        listParam.Add(new object[] { dgvDetail.Rows[i].Cells[3].Value.ToString(), "int32" });
                        listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
                        //listParam.Add(new object[] { dgvWarehouse.Rows[idx].Cells[4].Value.ToString(), "int32" });
                        //AMBIL STOK LAMANYA DULU
                        querystr = "SELECT QTY FROM BARANG_WAREHOUSE WHERE ID_BARANG = :0 AND ID_WAREHOUSE = :1";
                        int qty = Convert.ToInt32(DB.executeScalar(querystr, listParam));
                        int qty_akhir = qty + Convert.ToInt32(dgvDetail.Rows[i].Cells[2].Value.ToString());
                        listParam.Add(new object[] { qty_akhir, "int32" });
                        querystr = "UPDATE BARANG_WAREHOUSE SET QTY = :2 WHERE ID_BARANG = :0 AND ID_WAREHOUSE = :1";
                        DB.executeDataSet(dataset, querystr, listParam, "BARANG_2");
                    }

                    //MASUKIN DATA KE HISTORY BARANG KELUAR MASUK -> WAREHOUSE PENGIRIM
                    //dataset = new DataSet();
                    //listParam.Clear();
                    //listParam.Add(new object[] { kode, "varchar" });
                    //listParam.Add(new object[] { asal, "int32" });
                    //listParam.Add(new object[] { tujuan, "int32" });
                    //listParam.Add(new object[] { lblTotal.Text, "int32" });
                    //listParam.Add(new object[] { System.DateTime.Now.Date, "date" });
                    //listParam.Add(new object[] { 0, "int32" });
                    //querystr = "INSERT INTO H_PINDAH VALUES(:0, :1, :2, :3, :4, :5)";
                    //DB.executeQuery(querystr, listParam);

                    //MASUKIN DATA KE HISTORY BARANG KELUAR MASUK -> WAREHOUSE PENERIMA

                    MessageBox.Show("Berhasil Diterima!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDetail.DataMember = null;
                    dgvDetail.DataSource = null;  
                }
                else
                {
                    dataset = new DataSet();
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { dgvWarehouse.Rows[idx].Cells[3].Value.ToString(), "varchar" });
                    querystr = "UPDATE H_PINDAH SET STATUS = 2 WHERE ID = :0";
                    DB.executeDataSet(dataset, querystr, listParam, "WAREHOUSE");
                    MessageBox.Show("Berhasil Ditolak!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadReq();
            }
        }
    }
}
