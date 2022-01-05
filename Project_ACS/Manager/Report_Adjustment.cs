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
    public partial class Report_Adjustment : Form
    {
        public Report_Adjustment()
        {
            InitializeComponent();
        }

        reportadjustment rpt;


        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            string awal = dtpAwal.Value.ToString("dd-MM-yyyy");
            string akhir = dtpAkhir.Value.ToString("dd-MM-yyyy");
            if (dtpAkhir.Value < dtpAwal.Value)
            {
                MessageBox.Show("Tanggal Akhir harus lebih besar");
                return;
            }
            string id_wh = User.User_login.Id_warehouse;

            myDataSet dataset = new myDataSet();
            DB.executeDataSet(dataset, "SELECT * from BARANG", null, "barang");
            DB.executeDataSet(dataset, "SELECT * from WAREHOUSE", null, "warehouse");
            DB.executeDataSet(dataset, $"SELECT * from ADJUSTMENT WHERE TANGGAL >= TO_DATE('{awal}','dd/MM/yyyy') AND TANGGAL <= TO_DATE('{akhir}','dd/MM/yyyy') AND id_warehouse = '{id_wh}'", null, "adjustment");

            rpt = new reportadjustment();
            rpt.SetDataSource(dataset);
            rpt.SetParameterValue("pNama_Warehouse", DB.executeScalar($"SELECT NAMA from WAREHOUSE where ID = {User.User_login.Id_warehouse}",null).ToString());
            rpt.SetParameterValue("pDate_awal", awal);
            rpt.SetParameterValue("pDate_akhir", akhir);
            rpt.SetParameterValue("pId_Warehouse", id_wh);

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
