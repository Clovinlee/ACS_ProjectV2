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
    public partial class Warehouse_Request_SuratJalanPindah : Form
    {
        public Warehouse_Request_SuratJalanPindah(string kode)
        {
            InitializeComponent();
            kode_pindah = kode;
        }
        string kode_pindah = "";
        private void Waarehouse_Request_SuratJalanPindah_Load(object sender, EventArgs e)
        {
            suratJalanPindah s = new suratJalanPindah();
            DataTable dataT = DB.get($"SELECT * FROM H_PINDAH WHERE KODE='{kode_pindah}'");
            DataRow data = dataT.Rows[0];
            s.SetParameterValue("paramKodePindah", kode_pindah);
            s.SetParameterValue("paramTanggal", data.Field<DateTime>("TANGGAL").ToString());
            s.SetParameterValue("paramPlat", data.Field<string>("PLATE_NUMBER"));
            s.SetParameterValue("paramAsal", "Warehouse "+data.Field<decimal>("ASAL").ToString());
            s.SetParameterValue("paramTujuan", "Warehouse " + data.Field<decimal>("TUJUAN").ToString());
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = s;
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
