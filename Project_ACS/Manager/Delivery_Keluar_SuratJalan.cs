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
        public Delivery_Keluar_SuratJalan(string kode, string namaSupir)
        {
            InitializeComponent();
            kode_keluar = kode;
            nama_supir= namaSupir;
        }
        string kode_keluar = "";
        string nama_supir = "";
        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Delivery_Keluar_SuratJalan_Load(object sender, EventArgs e)
        { 
            suratJalanOrder s = new suratJalanOrder();
            DataTable dataT = DB.get($"SELECT H.*, B.TELEPON AS TELEPONBP ,B.NAMA AS NAMABP, B.ALAMAT AS ALAMATBP FROM H_KELUAR_BARANG H JOIN BUSINESS_PARTNER B ON B.ID=H.ID_PARTNER WHERE H.KODE='{kode_keluar}'");
            DataRow data = dataT.Rows[0];


            DataTable dataWarehouse = DB.get($"SELECT H.*, U.NAMA AS NAMA_PENGIRIM FROM H_KELUAR_BARANG H JOIN WAREHOUSE W ON W.ID=H.ID_WAREHOUSE JOIN USERS U ON U.ID=W.ID_USER WHERE H.KODE='{kode_keluar}'");
            DataRow dataW = dataWarehouse.Rows[0];

            myDataSet dataset = new myDataSet();
            DB.executeDataSet(dataset, $"SELECT B.* from BARANG B join D_KELUAR_BARANG D ON D.ID_BARANG = B.ID WHERE D.KODE_KELUAR='{kode_keluar}'", null, "barang");
            DB.executeDataSet(dataset, $"SELECT * from D_KELUAR_BARANG WHERE KODE_KELUAR='{kode_keluar}'", null, "d_keluar_barang");

            s.SetDataSource(dataset);
             
            s.SetParameterValue("paramAlamatPenerima", data.Field<string>("ALAMATBP"));
            s.SetParameterValue("paramNamaPengirim", dataW.Field<string>("NAMA_PENGIRIM"));
            s.SetParameterValue("paramTeleponPenerima", data.Field<string>("TELEPONBP"));

            s.SetParameterValue("paramSupir", nama_supir );
            s.SetParameterValue("paramKode", kode_keluar);
            s.SetParameterValue("paramTanggal", data.Field<DateTime>("TANGGAL").ToString("dd MMMM yyyy"));
            s.SetParameterValue("paramPlat", data.Field<string>("PLATE_NUMBER"));
            s.SetParameterValue("paramAsal", "Warehouse " + data.Field<decimal>("ID_WAREHOUSE").ToString());
            s.SetParameterValue("paramTujuan", data.Field<string>("NAMABP"));
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = s;
        }
    }
}
