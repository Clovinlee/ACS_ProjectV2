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
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
            refreshData();
            settingDgv();
        } 

        void settingDgv()
        {
            dgv_keluarmasuk.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_keluarmasuk.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_keluarmasuk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_keluarmasuk.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column1 = dgv_keluarmasuk.Columns[0];
            column1.Width = 70;
            DataGridViewColumn column2 = dgv_keluarmasuk.Columns[1];
            column2.Width = 50;
            DataGridViewColumn column3 = dgv_keluarmasuk.Columns[2];
            column3.Width = 50;

            dgv_adjustment.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_adjustment.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_adjustment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_adjustment.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn ccolumn1 = dgv_adjustment.Columns[0];
            ccolumn1.Width = 30;
            DataGridViewColumn ccolumn2 = dgv_adjustment.Columns[1];
            ccolumn2.Width = 100;
            DataGridViewColumn ccolumn3 = dgv_adjustment.Columns[2];
            ccolumn3.Width = 35;
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet ds_keluarmasuk;
        DataSet ds_adjust;
        DataSet ds_delivery;

        public void refreshData()
        {
            ds_adjust = new DataSet();
            ds_keluarmasuk = new DataSet();
            ds_delivery = new DataSet();
            
            loadDgvKeluarMasuk();
            loadDgvAdjust();
            loadLateDelivery();
            loadUpcomingDelivery();
            loadWarehouseRequest();
        }

        public void loadWarehouseRequest()
        {
            int jml = Convert.ToInt32(DB.executeScalar($"select count(*) from H_PINDAH where TUJUAN = {User.User_login.Id_warehouse} AND status = 0", null));
            lbl_warehouserequest.Text = jml.ToString();
        }

        public void loadUpcomingDelivery() 
        {
            DB.executeDataSet(ds_delivery, $"select h.kode, bp.nama, h.eta, h.status, h.qty, h.id_warehouse, h.grand_total from H_ORDER_SUPPLIER h, BUSINESS_PARTNER bp where h.id_partner = bp.id AND id_warehouse = {User.User_login.Id_warehouse} order by ETA desc", null, "delivery");

            if (ds_delivery.Tables[0].Rows.Count > 0)
            {
                lbl_upcomingname.Text = "Tidak ada delivery";
                lbl_upcomingarrival.Text = "";
                for (int i = 0; i < ds_delivery.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds_delivery.Tables[0].Rows[i];
                    String status = dr[3].ToString();
                    String nama = dr[1].ToString();
                    if (status != "1")
                    {
                        break;
                    }

                    DateTime arrival = Convert.ToDateTime(dr[2].ToString());
                    DateTime now = DateTime.Now;

                    int resultCompare = DateTime.Compare(now, arrival);

                    if (resultCompare <= 0)
                    {
                        lbl_upcomingname.Text = dr[1].ToString();
                        lbl_upcomingarrival.Text = arrival.ToString("dd MMMM yyyy");
                    }
                    else if (resultCompare > 0)
                    {
                        lbl_upcomingname.Text = "Tidak ada delivery";
                        lbl_upcomingarrival.Text = "";
                    }
                    break;
                }
            }
        }

        public void loadLateDelivery()
        {
            DB.executeDataSet(ds_delivery, $"select h.kode, bp.nama, h.eta, h.status, h.qty, h.id_warehouse, h.grand_total from H_ORDER_SUPPLIER h, BUSINESS_PARTNER bp where h.id_partner = bp.id AND id_warehouse = {User.User_login.Id_warehouse} order by ETA desc",null,"delivery");

            int jml = Convert.ToInt32(DB.executeScalar($"SELECT COUNT(*) FROM H_ORDER_SUPPLIER WHERE status = 2 AND id_warehouse = {User.User_login.Id_warehouse}",null));
            lbl_latedelivery.Text = jml.ToString();
        }

        public void loadDgvAdjust()
        {
            string st = System.DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            DB.executeDataSet(ds_adjust, $"select a.id, a.qty - a.real_qty AS perbedaan, a.qty, a.real_qty, b.kode, a.keterangan, a.id_barang, a.tanggal from adjustment a, barang b where a.id_barang = b.id and a.id_warehouse = {User.User_login.Id_warehouse} and a.tanggal > TO_DATE('{st}','DD/MM/YYYY')order by a.id desc", null, "adj");
            dgv_adjustment.DataSource = ds_adjust.Tables[0];
            dgv_adjustment.Columns[2].Visible = false;
            dgv_adjustment.Columns[3].Visible = false;
            dgv_adjustment.Columns[6].Visible = false;

        }

        public void loadDgvKeluarMasuk()
        {
            //DB.executeDataSet(ds_keluarmasuk, $"SELECT NVL(tb1.bulan,tb2.bulan) AS bulan, NVL(tb1.totalqty,0) AS keluar, NVL(tb2.totalqty,0) AS masuk FROM(select SUM(QTY) AS totalqty, TO_CHAR(TANGGAL, 'MM') AS bulan from HISTORY_BARANG_KELUAR_MASUK WHERE ID_WAREHOUSE = {User.User_login.Id_warehouse} AND TO_CHAR(TANGGAL, 'YYYY') = TO_CHAR(SYSDATE, 'YYYY') AND status = 0 GROUP BY TO_CHAR(TANGGAL, 'MM') ORDER BY 2) tb1 FULL OUTER JOIN (select SUM(QTY) AS totalqty, TO_CHAR(TANGGAL, 'MM') AS bulan from HISTORY_BARANG_KELUAR_MASUK WHERE ID_WAREHOUSE = {User.User_login.Id_warehouse} AND TO_CHAR(TANGGAL, 'YYYY') = TO_CHAR(SYSDATE, 'YYYY') AND status = 1 GROUP BY TO_CHAR(TANGGAL, 'MM') ORDER BY 2) tb2 ON tb1.bulan = tb2.bulan ORDER BY 1 ASC", null, "data");

            DB.executeDataSet(ds_keluarmasuk, $"SELECT to_char(tanggal, 'mm-yyyy') AS tgl, sum(qty) AS keluar, 0 AS masuk FROM HISTORY_BARANG_KELUAR_MASUK hbkm WHERE status = 0 AND to_char(tanggal, 'yyyy') = to_char(sysdate, 'yyyy') AND ID_WAREHOUSE = {User.User_login.Id_warehouse} GROUP BY to_char(tanggal, 'mm-yyyy') UNION SELECT to_char(tanggal, 'mm-yyyy') AS tgl, 0 AS KELUAR, sum(qty) AS masuk FROM HISTORY_BARANG_KELUAR_MASUK hbkm WHERE status = 1 AND to_char(tanggal, 'yyyy') = to_char(sysdate, 'yyyy') AND ID_WAREHOUSE = {User.User_login.Id_warehouse} GROUP BY to_char(tanggal, 'mm-yyyy') ORDER BY TGL ASC",null,"data");

            List<string> listBulan = new List<string>();
            listBulan.Add("Januari");
            listBulan.Add("Februari");
            listBulan.Add("Maret");
            listBulan.Add("April");
            listBulan.Add("Mei");
            listBulan.Add("Juni");
            listBulan.Add("Juli");
            listBulan.Add("Agustus");
            listBulan.Add("September");
            listBulan.Add("Oktober");
            listBulan.Add("November");
            listBulan.Add("Desember");

            List<int[]> listKeluarMasuk = new List<int[]>();
            for(int i = 0; i < 12; i++)
            {
                listKeluarMasuk.Add(new int[] { 0, 0 });
            }

            foreach (DataRow dr in ds_keluarmasuk.Tables[0].Rows)
            {
                int month = Int32.Parse(dr[0].ToString().Split('-')[0]);
                int keluar = Int32.Parse(dr[1].ToString());
                int masuk = Int32.Parse(dr[2].ToString());

                listKeluarMasuk[month - 1][0] += keluar;
                listKeluarMasuk[month - 1][1] += masuk;

            }
            dgv_keluarmasuk.Rows.Clear();
            for (int i = 0; i < listBulan.Count; i++)
            {
                dgv_keluarmasuk.Rows.Add(new object[] { listBulan[i], listKeluarMasuk[i][0], listKeluarMasuk[i][1] });
            }
                
            //for (int i = 0; i < listBulan.Count; i++)
            //{
            //    bool valid = false;
            //    foreach (DataRow dr in ds_keluarmasuk.Tables[0].Rows)
            //    {
            //        if(Convert.ToInt32(dr[0].ToString()) == i + 1)
            //        {
            //            listKeluarMasuk.Add(new int[] { Convert.ToInt32(dr[1].ToString()), Convert.ToInt32(dr[2].ToString()) });
            //            valid = true;
            //        }
            //    }
            //    if(valid == false)
            //    {
            //        listKeluarMasuk.Add(new int[] { 0,0 });
            //    }
            //}
        }

        private void pl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
