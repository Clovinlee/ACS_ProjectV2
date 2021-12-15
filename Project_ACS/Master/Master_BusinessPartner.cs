using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ACS.Master
{
    public partial class Master_BusinessPartner : Form
    {
        public Master_BusinessPartner()
        {
            InitializeComponent();
            loadDgv();
        }

        DataSet ds_bp;

        public Panel getPl()
        {
            return pl;
        }

        private void reloadDGVWithFilter()
        {//buat reload ulang dgv sesuai kondisi filter
            ds_bp.Tables["bp"].DefaultView.RowFilter = string.Format("kode LIKE '%{0}%' and nama LIKE '%{1}%'", tb_kode.Text, tb_nama.Text);
            dgv_bp.ClearSelection();
            loadDgvColor();
        }

        private void Master_BusinessPartner_Load(object sender, EventArgs e)
        {
            
        }

        void loadDgvColor()
        {
            dgv_bp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_bp.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_bp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_bp.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }

        public void loadDgv()
        {
            ds_bp = new DataSet();
            DB.executeDataSet(ds_bp, "select kode,nama,telepon,alamat from bussiness_partner", null, "bp");
            dgv_bp.DataSource = ds_bp.Tables[0];
            lbl_jml.Text = "Showing " + dgv_bp.RowCount + " data from Barang";
            dgv_bp.ClearSelection();
            loadDgvColor();
        }

        private void tb_nama_KeyUp(object sender, KeyEventArgs e)
        {
            reloadDGVWithFilter();
        }
    }
}
