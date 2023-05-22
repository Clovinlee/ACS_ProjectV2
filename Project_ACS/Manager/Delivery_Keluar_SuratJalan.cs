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
    public partial class Delivery_Keluar_SuratJalan : Form
    {
        public Delivery_Keluar_SuratJalan(string kode)
        {
            InitializeComponent();
            kode_keluar = kode;
        }
        string kode_keluar = "";
        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Delivery_Keluar_SuratJalan_Load(object sender, EventArgs e)
        { 
            suratJalanOrder s = new suratJalanOrder();
            DataTable dataT = DB.get($"SELECT H.*, B.NAMA AS NAMABP FROM H_KELUAR_BARANG H JOIN BUSINESS_PARTNER B ON B.ID=H.ID_PARTNER WHERE H.KODE='{kode_keluar}'");
            DataRow data = dataT.Rows[0];

            myDataSet dataset = new myDataSet();
            DB.executeDataSet(dataset, $"SELECT B.* from BARANG B join D_KELUAR_BARANG D ON D.ID_BARANG = B.ID WHERE D.KODE_KELUAR='{kode_keluar}'", null, "barang");
            DB.executeDataSet(dataset, $"SELECT * from D_KELUAR_BARANG WHERE KODE_KELUAR='{kode_keluar}'", null, "d_keluar_barang");

            s.SetDataSource(dataset);

            s.SetParameterValue("paramKode", kode_keluar);
            s.SetParameterValue("paramTanggal", data.Field<DateTime>("TANGGAL").ToString());
            s.SetParameterValue("paramPlat", data.Field<string>("PLATE_NUMBER"));
            s.SetParameterValue("paramAsal", "Warehouse " + data.Field<decimal>("ID_WAREHOUSE").ToString());
            s.SetParameterValue("paramTujuan", data.Field<string>("NAMABP"));
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = s;
        }
    }
}
