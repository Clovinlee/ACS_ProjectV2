using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Project_ACS.Manager
{
    public partial class Inventory_Tracking : Form
    {
        public Inventory_Tracking()
        {
            InitializeComponent(); 
            DataSet dtemp1 = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dtemp1, "SELECT NAMA FROM WAREHOUSE WHERE ID = :0 ", listParam, "dtmp");  
            try
            {
                labelNamaWarehouse.Text = dtemp1.Tables["dtmp"].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception)
            {
                labelNamaWarehouse.Text = "Warehouse " + User.User_login.Id_warehouse;
            }
            queryDataset();
            //loadTambah();
        }

        public Panel getPl()
        {
            return pl;
        } 
        int idxclicked = -1;
        DataSet ds_barang = new DataSet();
        public void queryDataset()
        {
            ds_barang = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(ds_barang, "SELECT H.TANGGAL, b.kode, b.nama, b.MULTIPLIER, H.QTY, h.status, b.id, H.KETERANGAN  FROM BARANG B JOIN HISTORY_BARANG_KELUAR_MASUK H ON B.ID = H.ID_BARANG WHERE H.ID_WAREHOUSE = :0 order by h.TANGGAL desc", listParam, "inv1barang");
            //ds_barang.Tables["invbarang"].Columns.Add("Terakhir");
            loadDGV(); 
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();
            for (int i = 0; i < dgv_barang1.RowCount; i++)
            {
                cm.Add(dgv_barang1.Rows[i].Cells["KODE"].Value.ToString());
                cm.Add(dgv_barang1.Rows[i].Cells["NAMA"].Value.ToString()); 
            }
            textbox_searchkode.AutoCompleteCustomSource = cm; 
            textbox_searchkode.Text = "";
            reloadDGVWithFilter(); 
        }

        void dgvDefColor()
        {
            dgv_barang1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_barang1.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_barang1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_barang1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            for (int i = 0; i < dgv_barang1.RowCount; i++)
            { 
                if (dgv_barang1.Rows[i].Cells["status"].Value.ToString() == "0")
                {
                    dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(224, 128, 128); //keluar = merah 
                }
                else
                {
                    dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192); //masuk = hijau  
                }
            } 
        }

        //DataSet dataset = new DataSet();
        //string querystr = "";

        //OracleConnection conn;
        //String connstr;
        //OracleCommand query;
        //OracleDataAdapter adapter;
        //DataSet datasetCari;

        //OracleCommand cmd;
        //String cmdstr;

        //OracleDataReader reader;
        //OracleTransaction trans;

        void loadTambah()
        {
            //connstr = "USER ID=MK;PASSWORD = MK; DATA SOURCE=localhost:1521/XEPDB1";
            //conn = new OracleConnection(connstr);

            ////for (int i = 0; i < dgv_barang1.Rows.Count; i++)
            ////{
            ////    dataset = new DataSet();
            ////    querystr = "SELECT DISTINCT B.KODE AS KODE, B.NAMA AS NAMA, BW.QTY AS QTY, B.ID FROM BARANG B, BARANG_WAREHOUSE BW, WAREHOUSE W WHERE B.ID = BW.ID_BARANG AND BW.ID_WAREHOUSE = :0";
            ////    List<object[]> listParam = new List<object[]>();
            ////    listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            ////    DB.executeDataSet(dataset, querystr, listParam, "BARANG");
            ////    dgv_barang1.DataMember = "BARANG";
            ////    dgv_barang1.DataSource = dataset;
            ////}

            //try
            //{
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //    conn.Open();
            //    //listJenis.Add(new Jenis(-1, "None"));

            //    for (int i = 0; i < dgv_barang1.Rows.Count; i++)
            //    {
            //        querystr = "SELECT W.NAMA FROM HISTORY_BARANG_KELUAR_MASUK H, WAREHOUSE W WHERE H.ID_BARANG = "+ dgv_barang1.Rows[i].Cells[6] +" AND H.ID_WAREHOUSE = W.ID AND ROWNUM < 2";
            //        query = new OracleCommand(querystr, conn);
            //        reader = query.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            while (reader.Read())
            //            {
            //                //edit1.Rows.Add(reader.GetValue(0).ToString());
            //            }
            //        }
            //    }

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw;
            //}
        }

        private void loadDGV()
        {
            dgv_barang1.DataSource = ds_barang.Tables["inv1barang"];

            //MessageBox.Show("Data count : " + ds_barang.Tables["invbarang"].Rows.Count);
            for (int i = 0; i < dgv_barang1.ColumnCount; i++)
            {
                dgv_barang1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            } 
            dgv_barang1.Columns["qty"].Width = 40;
            //dgv_barang1.Columns["status"].Visible = false;
            dgv_barang1.Columns["id"].Visible = false;

            ds_barang.Tables["inv1barang"].Columns.Add("Terakhir");
            for (int i = 0; i < dgv_barang1.RowCount; i++)
            {
                string[] list = dgv_barang1.Rows[i].Cells[7].Value.ToString().Split('-');
                string detail = list[0];
                int idx = Convert.ToInt32(list[1]);
                String tujuan = "";
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { idx, "int32" });

                if (dgv_barang1.Rows[i].Cells["status"].Value.ToString() == "0")
                {
                    //dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(224, 128, 128); //keluar = merah  
                    dgv_barang1.Rows[i].Cells["Terakhir"].Value = dgv_barang1.Rows[i].Cells["NAMA"].Value.ToString();

                    if (detail == "P")
                    {
                        //dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Pindah Keluar";
                        tujuan = DB.executeScalar("SELECT NAMA FROM WAREHOUSE WHERE ID = :0", listParam).ToString();
                    }
                    else
                    {
                        //dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Delivery Keluar";
                        tujuan = DB.executeScalar("SELECT NAMA FROM BUSINESS_PARTNER WHERE ID = :0 ", listParam).ToString();
                    }
                    dgv_barang1.Rows[i].Cells["Terakhir"].Value = tujuan;
                }
                else
                {
                    //dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192); //masuk = hijau  
                    dgv_barang1.Rows[i].Cells["Terakhir"].Value = dgv_barang1.Rows[i].Cells["NAMA"].Value.ToString();

                    if (detail == "P")
                    {
                        //dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Pindah Masuk";
                        tujuan = DB.executeScalar("SELECT NAMA FROM WAREHOUSE WHERE ID = "+ User.User_login.Id_warehouse +"", null).ToString();
                    }
                    else
                    {
                        //dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Delivery Masuk";
                        tujuan = DB.executeScalar("SELECT NAMA FROM BUSINESS_PARTNER WHERE ID = :0 ", listParam).ToString();
                    }
                    dgv_barang1.Rows[i].Cells["Terakhir"].Value = tujuan;
                }

            }

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        { 
            textbox_searchkode.Text = "";
            queryDataset(); 
        }

        private void Inventory_Tracking_Load(object sender, EventArgs e)  {  }

        private void bunifuButton1_Click(object sender, EventArgs e) //button track
        {
            if (idxclicked==-1)
            {
                MessageBox.Show("Silahkan pilih data barang yang mau di-track ");
                return;
            }
            //munculin form baru
            int idbarang = Convert.ToInt32(dgv_barang1.Rows[idxclicked].Cells["id"].Value.ToString()); 
            Detail_Tracking dt = new Detail_Tracking(dgv_barang1.Rows[idxclicked].Cells["NAMA"].Value.ToString(), labelNamaWarehouse.Text, idbarang, Convert.ToInt32(User.User_login.Id_warehouse));
            dt.ShowDialog();
        }  
        private void textbox_searchkode_KeyUp(object sender, KeyEventArgs e)
        {
            reloadDGVWithFilter(); 
        }
        private void reloadDGVWithFilter()
        {
            ds_barang.Tables["inv1barang"].DefaultView.RowFilter = string.Format("nama LIKE '%{0}%' or kode LIKE '%{1}%'", textbox_searchkode.Text, textbox_searchkode.Text);
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang1.RowCount + " data Tracking";
            dgv_barang1.ClearSelection();
            dgvDefColor();
        }

        private void dgv_barang1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idxclicked = e.RowIndex; 
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            Report_Tracking rpt = new Report_Tracking(Convert.ToInt32(User.User_login.Id_warehouse), labelNamaWarehouse.Text,"");
            rpt.ShowDialog();
            
        }
    }
}
