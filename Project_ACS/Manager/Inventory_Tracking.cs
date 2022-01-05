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
    public partial class Inventory_Tracking : Form
    {
        public Inventory_Tracking()
        {
            InitializeComponent(); 
            DataSet dtemp1 = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dtemp1, "SELECT NAMA FROM WAREHOUSE WHERE ID = :0 ", listParam, "dtmp"); 
            labelNamaWarehouse.Text = dtemp1.Tables["dtmp"].Rows[0].ItemArray[0].ToString();
            queryDataset();
        }

        public Panel getPl()
        {
            return pl;
        } 
        int idxclicked = -1;
        DataSet ds_barang = new DataSet();
        public void queryDataset()
        {
            ds_barang = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(ds_barang, "SELECT b.kode as \"Kode\", b.nama, b.deskripsi, b.harga, k.nama as kategori, m.nama as merk, b.MULTIPLIER, BW.QTY as \"Qty\" FROM barang b join kategori k on b.ID_KATEGORI = k.id join merk m on b.ID_MERK = m.id JOIN BARANG_WAREHOUSE BW ON B.ID = BW.ID_BARANG WHERE BW.status <> 0 and BW.id_warehouse = :0 ", listParam, "invbarang");
            loadDGV(); 
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();
            for (int i = 0; i < dgv_barang.RowCount; i++)
            {
                cm.Add(dgv_barang.Rows[i].Cells["Kode"].Value.ToString());
                cm.Add(dgv_barang.Rows[i].Cells["nama"].Value.ToString());
            }
            textbox_searchkode.AutoCompleteCustomSource = cm;
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data Tracking"; 
            textbox_searchkode.Text = "";
            dgv_barang.ClearSelection();
            dgvDefColor();
        }

        void dgvDefColor()
        {
            dgv_barang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_barang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_barang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_barang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }
        private void loadDGV()
        {
            dgv_barang.DataSource = ds_barang.Tables["invbarang"];

            //MessageBox.Show("Data count : " + ds_barang.Tables["invbarang"].Rows.Count);
            for (int i = 0; i < dgv_barang.ColumnCount; i++)
            {
                dgv_barang.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            } 
            dgv_barang.Columns["qty"].Width = 40;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        { 
            textbox_searchkode.Text = "";
            queryDataset();
            reloadDGVWithFilter(); 
        }

        private void Inventory_Tracking_Load(object sender, EventArgs e)  {  }

        private void bunifuButton1_Click(object sender, EventArgs e) //button track
        {
            if (idxclicked==-1)
            {
                MessageBox.Show("Silahkan pilih data barang yang mau di-track");
                return;
            }
            //munculin form baru
        }

        private void dgv_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idxclicked = e.RowIndex; 
        }

        private void textbox_searchkode_KeyUp(object sender, KeyEventArgs e)
        {
            reloadDGVWithFilter(); 
        }
        private void reloadDGVWithFilter()
        {
            ds_barang.Tables["invbarang"].DefaultView.RowFilter = string.Format("nama LIKE '%{0}%' or kode LIKE '%{1}%'", textbox_searchkode.Text, textbox_searchkode.Text);
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data Tracking";
            dgv_barang.ClearSelection();
            dgvDefColor();
        }
    }
}
