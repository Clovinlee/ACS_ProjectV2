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
    public partial class Report_Tracking : Form
    {
        public Report_Tracking(int idwarehouse, string bp)
        {
            InitializeComponent();
            bussiness_partner = bp;
            idw = idwarehouse;
        }
        string bussiness_partner = "";
        int idw = 0;
        private void Report_Tracking_Load(object sender, EventArgs e)
        {

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string awal = dtpAwal.Value.ToString("dd-MM-yyyy");
            string akhir = dtpAkhir.Value.ToString("dd-MM-yyyy");

            if (dtpAkhir.Value<dtpAwal.Value)
            {
                MessageBox.Show("Tanggal Akhir harus lebih besar");
                return;
            }


        }
    }
}
