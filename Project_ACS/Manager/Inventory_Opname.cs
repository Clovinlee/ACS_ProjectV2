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
            refreshData();
            DataSet dtemp1 = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dtemp1, "SELECT NAMA FROM WAREHOUSE WHERE ID = :0 ", listParam, "dtmp");
            try
            {
                labelNamaWarehouse.Text = dtemp1.Tables["dtmp"].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception)
            {
                labelNamaWarehouse.Text = "Warehouse " + User.User_login.Id_warehouse;
            }
        }

        public void refreshData()
        {
            ds_adjustment = new DataSet();
            ds_barang = new DataSet();
            ds_barangwarehouse = new DataSet();
            DB.executeDataSet(ds_adjustment, $"select a.id, a.qty, a.real_qty, b.kode, a.keterangan, a.id_barang, a.tanggal from adjustment a, barang b where a.id_barang = b.id and a.id_warehouse = {User.User_login.Id_warehouse} order by a.id desc", null, "adj");
            DB.executeDataSet(ds_barang, "select * from barang", null, "brg");
            loadDgv();
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
            DB.executeDataSet(ds_adjustment, $"select a.id, a.qty, a.real_qty, b.kode, a.keterangan, a.id_barang, a.tanggal from adjustment a, barang b where a.id_barang = b.id and a.id_warehouse = {User.User_login.Id_warehouse} order by a.id desc", null, "adj");
            dgv_adjust.DataSource = ds_adjustment.Tables[0];
            dgv_adjust.AllowUserToResizeRows = false;
            dgv_adjust.Columns[5].Visible = false;
            //ds_bp = new DataSet();
            //DB.executeDataSet(ds_bp, "select id,kode,nama,telepon,alamat from business_partner ORDER BY id DESC", null, "bp");

            ds_barangwarehouse = new DataSet();
            DB.executeDataSet(ds_barangwarehouse, $"select * from barang_warehouse WHERE id_warehouse = '{User.User_login.Id_warehouse}'", null, "brgwh");

            lbl_jml.Text = "Showing " + dgv_adjust.RowCount + " data from Stock Adjustment";
            dgv_adjust.ClearSelection();
            loadDgvColor();
            search();
        }

        private void search()
        {//buat reload ulang dgv sesuai kondisi filter
            ds_adjustment.Tables[0].DefaultView.RowFilter = $"CONVERT(id, System.String) LIKE '%{tb_id.Text}%' and CONVERT(kode, System.String) like '%{tb_kodebarang.Text}%' and keterangan like '%{tb_keterangan.Text}%'";
            dgv_adjust.ClearSelection();
            loadDgvColor();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        public void clear()
        {
            tb_id.Text = "";
            tb_keterangan.Text = "";
            tb_kodebarang.Text = "";
            dt_picker.Value = System.DateTime.Now;
            loadDgv();
        }

        private void btn_searchdate_Click(object sender, EventArgs e)
        {
            //BUG
            ds_adjustment = new DataSet();
            DB.executeDataSet(ds_adjustment, $"select a.id, a.qty, a.real_qty, b.kode, a.keterangan, a.id_barang, a.tanggal from adjustment a, barang b where a.id_barang = b.id AND a.tanggal = TO_DATE('{dt_picker.Value.ToShortDateString()}', 'DD/MM/YYYY') and a.id_warehouse = {User.User_login.Id_warehouse} order by a.id desc", null, "adj");
            dgv_adjust.DataSource = ds_adjustment;
            search();
            dgv_adjust.ClearSelection();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Detail_Stock_Adjustment frm_adj = new Detail_Stock_Adjustment(ds_barang,ds_adjustment,ds_barangwarehouse,this);
            frm_adj.Show();
        }

        private void tb_id_KeyUp(object sender, KeyEventArgs e)
        {
            search();
        }
    }
}
