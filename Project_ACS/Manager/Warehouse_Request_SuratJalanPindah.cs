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
        public Warehouse_Request_SuratJalanPindah(string kode, string namaSupir)
        {
            InitializeComponent();
            kode_pindah = kode;
            nama_supir = namaSupir;
        }
        string kode_pindah = "";
        string nama_supir = "";
        private void Waarehouse_Request_SuratJalanPindah_Load(object sender, EventArgs e)
        {
            try
            {

                suratJalanPindah s = new suratJalanPindah();
                DataTable dataT = DB.get($"SELECT * FROM H_PINDAH WHERE KODE='{kode_pindah}'");
                DataRow data = dataT.Rows[0];

                string asal = data.Field<decimal>("ASAL").ToString();
                string tujuan = data.Field<decimal>("TUJUAN").ToString();

                DataTable dataTPengirim = DB.get($"SELECT W.*, U.NAMA AS NAMA_PENGIRIM FROM WAREHOUSE W JOIN USERS U ON W.ID_USER = U.ID WHERE W.ID={asal}");
                DataRow dataPengirim = dataTPengirim.Rows[0];
                 
                DataTable dataTPenerima = DB.get($"SELECT W.*, U.NAMA AS NAMA_PENERIMA FROM WAREHOUSE W JOIN USERS U ON W.ID_USER = U.ID WHERE W.ID={tujuan}");
                DataRow dataPenerima = dataTPenerima.Rows[0];
                //MessageBox.Show(tujuan + dataPenerima.Field<string>("NAMA_PENERIMA"));

                myDataSet dataset = new myDataSet();
                DB.executeDataSet(dataset, $"SELECT B.* from BARANG B join D_PINDAH D ON D.ID_BARANG = B.ID WHERE D.KODE_PINDAH='{kode_pindah}'", null, "barang");

                DB.executeDataSet(dataset, $"SELECT * from D_PINDAH WHERE KODE_PINDAH='{kode_pindah}'", null, "d_pindah");
                s.SetDataSource(dataset);
                 
                s.SetParameterValue("paramNamaPengirim", dataPengirim.Field<string>("NAMA_PENGIRIM"));
                s.SetParameterValue("paramNamaPenerima", dataPenerima.Field<string>("NAMA_PENERIMA"));
                s.SetParameterValue("paramTeleponPenerima", dataPenerima.Field<string>("TELEPON")); 

                s.SetParameterValue("paramSupir", nama_supir);
                s.SetParameterValue("paramKodePindah", kode_pindah);
                s.SetParameterValue("paramTanggal", data.Field<DateTime>("TANGGAL").ToString("dd MMMM yyyy"));
                s.SetParameterValue("paramPlat", data.Field<string>("PLATE_NUMBER"));
                s.SetParameterValue("paramAsal", "Warehouse " + data.Field<decimal>("ASAL").ToString());
                s.SetParameterValue("paramTujuan", "Warehouse " + data.Field<decimal>("TUJUAN").ToString());
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
