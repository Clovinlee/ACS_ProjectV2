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
    public partial class Inventory_Opname : Form
    {
        public Inventory_Opname()
        {
            InitializeComponent();
            loadDgv();
            ds_adjustment = new DataSet();
            DB.executeDataSet(ds_barang, "select * from barang", null, "brg");
            DB.executeDataSet(ds_barangwarehouse, "select * from barang_warehouse", null, "brgwh");

        }

        public Panel getPl()
        {
            return pl;
        }
        
        DataSet ds_adjustment;
        DataSet ds_barang;
        DataSet ds_barangwarehouse;

        void loadDgvColor()
        {
            dgv_adjust.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_adjust.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_adjust.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_adjust.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }

        public void loadDgv()
        {
            ds_adjustment.Tables[0].Rows.Clear();
            DB.executeDataSet(ds_adjustment, "select * from business_partner order by id DESC", null, "bp");
            dgv_adjust.AllowUserToResizeRows = false;
            //ds_bp = new DataSet();
            //DB.executeDataSet(ds_bp, "select id,kode,nama,telepon,alamat from business_partner ORDER BY id DESC", null, "bp");
            dgv_adjust.DataSource = ds_adjustment.Tables[0];
            dgv_adjust.Columns[0].Visible = false;
            lbl_jml.Text = "Showing " + dgv_adjust.RowCount + " data from Stock Adjustment";
            dgv_adjust.ClearSelection();
            loadDgvColor();
            search();
        }

        private void search()
        {//buat reload ulang dgv sesuai kondisi filter
            DataRow[] dr = ds_barang.Tables[0].Select($"kode LIKE '%{tb_kodebarang.Text}%'");
            string id = "";
            if(dr.Length == 1)
            {
                id = dr[0][0].ToString();
            }
            ds_adjustment.Tables["bp"].DefaultView.RowFilter = string.Format("ID LIKE '%{0}%' and ID_BARANG LIKE '%{1}%' and telepon LIKE '%{2}%'", tb_id.Text, id, tb_keterangan.Text);
            dgv_adjust.ClearSelection();
            loadDgvColor();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        public void clear()
        {
            loadDgv();
            tb_id.Text = "";
            tb_keterangan.Text = "";
            tb_kodebarang.Text = "";
            dt_picker.Value = System.DateTime.Now;
        }

        private void btn_searchdate_Click(object sender, EventArgs e)
        {
            ds_adjustment.Tables["bp"].DefaultView.RowFilter = string.Format("TANGGAL = {0}", dt_picker.Value.ToString());
            dgv_adjust.ClearSelection();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Detail_Stock_Adjustment frm_adj = new Detail_Stock_Adjustment(ds_barang,ds_adjustment,ds_barangwarehouse);
        }
    }
}
