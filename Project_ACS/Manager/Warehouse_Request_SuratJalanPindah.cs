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

        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
