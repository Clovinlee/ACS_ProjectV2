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
        }

        public Master_BusinessPartner(DataSet ds_bp, MainMenu_Master frm_master) : this()
        {
            this.ds_bp = ds_bp;
            this.frm_menumaster = frm_master;
            loadDgv();
        }

        DataSet ds_bp;

        public MainMenu_Master frm_menumaster;

        public Panel getPl()
        {
            return pl;
        }

        private void search()
        {//buat reload ulang dgv sesuai kondisi filter
            ds_bp.Tables["bp"].DefaultView.RowFilter = string.Format("kode LIKE '%{0}%' and nama LIKE '%{1}%' and telepon LIKE '%{2}%'", tb_kode.Text, tb_nama.Text, tb_telpon.Text);
            dgv_bp.ClearSelection();
            loadDgvColor();
        }

        private void Master_BusinessPartner_Load(object sender, EventArgs e)
        {
            clear();
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
            ds_bp.Tables[0].Rows.Clear();
            DB.executeDataSet(ds_bp, "select * from business_partner order by id DESC", null, "bp");
            dgv_bp.AllowUserToResizeRows = false;
            //ds_bp = new DataSet();
            //DB.executeDataSet(ds_bp, "select id,kode,nama,telepon,alamat from business_partner ORDER BY id DESC", null, "bp");
            dgv_bp.DataSource = ds_bp.Tables[0];
            dgv_bp.Columns[0].Visible = false;
            lbl_jml.Text = "Showing " + dgv_bp.RowCount + " data from Business Partner";
            dgv_bp.ClearSelection();
            loadDgvColor();
            search();
        }

        private void tb_nama_KeyUp(object sender, KeyEventArgs e)
        {
            search();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Detail_Master_BusinessPartner frm_bp = new Detail_Master_BusinessPartner();
            frm_bp.Frm_masterbp = this;
            frm_bp.ShowDialog();
        }

        int idx = 0;

        private void dgv_bp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                idx = e.RowIndex;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            tb_kode.Text = "";
            tb_nama.Text = "";
            tb_telpon.Text = "";
            if(dgv_bp.Rows.Count > 0)
            {
                dgv_bp.Rows[0].Selected = true;
            }
            idx = 0;
            search();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(idx != -1)
            {
                Detail_Master_BusinessPartner frm_bp = new Detail_Master_BusinessPartner(dgv_bp.Rows[idx]);
                frm_bp.Frm_masterbp = this;
                frm_bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tidak ada data yang di select!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
