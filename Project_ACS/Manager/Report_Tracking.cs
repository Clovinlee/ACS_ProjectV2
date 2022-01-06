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
    public partial class Report_Tracking : Form
    {
        public Report_Tracking(int idwarehouse, string namawarehouse, string bp)
        {
            InitializeComponent();
            bussiness_partner = bp;
            idw = idwarehouse;
            nama = namawarehouse;
        }
        string bussiness_partner = "";
        int idw = 0; string nama="";
        private void Report_Tracking_Load(object sender, EventArgs e)
        {

        }
        reportInventory rpt;
        OracleCommand query;
        OracleDataAdapter adapter;  

        private void btnShowReport_Click_1(object sender, EventArgs e)
        {
            string awal = dtpAwal.Value.ToString("dd-MM-yyyy") ;
            string akhir = dtpAkhir.Value.ToString("dd-MM-yyyy"); 
            if (dtpAkhir.Value<dtpAwal.Value)
            {
                MessageBox.Show("Tanggal Akhir harus lebih besar");
                return;
            }
            myDataSet dataset = new myDataSet();
            DB.executeDataSet(dataset, "SELECT * from BARANG", null, "barang");
            DB.executeDataSet(dataset, "SELECT * FROM HISTORY_BARANG_KELUAR_MASUK h where h.id_warehouse = " + idw + " and h.TANGGAL>=TO_DATE('" + awal + "','DD-MM-YYYY') and h.TANGGAL <= TO_DATE('" + akhir + "','DD-MM-YYYY')", null, "history_barang_keluar_masuk");
            //where id_warehouse = "+idw+" and TANGGAL>=TO_DATE('"+awal+ "','DD-MM-YYYY') and TANGGAL <= TO_DATE('" + akhir + "','DD-MM-YYYY') " 
            DB.executeDataSet(dataset, "SELECT * from WAREHOUSE", null, "warehouse");
            DB.executeDataSet(dataset, "SELECT * from BUSINESS_PARTNER", null, "BUSINESS_PARTNER");

            rpt = new reportInventory();
            rpt.SetDataSource(dataset);
            rpt.SetParameterValue("namaWarehouse", nama);
            rpt.SetParameterValue("tanggalAwal", awal);
            rpt.SetParameterValue("tanggalAkhir", akhir);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
