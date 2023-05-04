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
    public partial class Warehouse_History_Detail : Form
    {
        public Warehouse_History_Detail(string k)
        {
            InitializeComponent();
            kode = k;
        }
        string kode = "";
        private void Warehouse_History_Detail_Load(object sender, EventArgs e)
        {
            lblKode.Text = kode;
            DataTable header = DB.get($"SELECT H.*, (CASE H.STATUS WHEN 1 THEN 'DITERIMA' WHEN 0 THEN 'PENDING' ELSE 'DITOLAK' END) AS StatusString FROM H_PINDAH H JOIN WAREHOUSE WASAL ON WASAL.ID = H.ASAL JOIN WAREHOUSE WTUJUAN ON WTUJUAN.ID = H.TUJUAN WHERE H.KODE='{kode}'");
            lblAsal.Text = "Warehouse "+header.Rows[0].Field<decimal>("ASAL").ToString();
            lblTujuan.Text = "Warehouse "+header.Rows[0].Field<decimal>("TUJUAN").ToString();
            lblTotal.Text = header.Rows[0].Field<decimal>("TOTAL_QTY").ToString();
            lblStatus.Text = header.Rows[0].Field<string>("StatusString");
            lblTanggal.Text = header.Rows[0].Field<DateTime>("TANGGAL").ToString("dd/MM/yyyy");

            dgv_barang.DataSource = DB.get($"SELECT B.KODE, B.NAMA, D.QTY FROM D_PINDAH D JOIN BARANG B ON D.ID_BARANG = B.ID WHERE D.KODE_PINDAH='{kode}'");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAsal_Click(object sender, EventArgs e)
        {

        }

        private void lblKode_Click(object sender, EventArgs e)
        {

        }

    }
}
