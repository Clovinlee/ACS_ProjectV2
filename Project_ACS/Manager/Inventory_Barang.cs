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
    public partial class Inventory_Barang : Form
    {
        public Inventory_Barang()
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
            DB.executeDataSet(ds_barang, "SELECT id,nama from kategori", null, "tkategori");
            DB.executeDataSet(ds_barang, "SELECT id,nama from merk", null, "tmerk");
            fillCBB();
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();
            for (int i = 0; i < dgv_barang.RowCount; i++)
            {
                cm.Add(dgv_barang.Rows[i].Cells["Kode"].Value.ToString());
                cm.Add(dgv_barang.Rows[i].Cells["nama"].Value.ToString());
            }
            textbox_searchkode.AutoCompleteCustomSource = cm;
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data from Barang";
            cbb_kategori.Text = ""; cbb_merk.Text = "";
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
        private void fillCBB()
        {
            cbb_kategori.Items.Clear();
            cbb_merk.Items.Clear();
            cbb_kategori.Items.Add("");
            cbb_merk.Items.Add("");
            DataTable dtkategori = ds_barang.Tables["tkategori"];
            DataTable dtmerk = ds_barang.Tables["tmerk"]; 
            for (int i = 0; i < dtkategori.Rows.Count; i++)
            {
                cbb_kategori.Items.Add(dtkategori.Rows[i].ItemArray[1].ToString());
            }
            for (int i = 0; i < dtmerk.Rows.Count; i++)
            {
                cbb_merk.Items.Add(dtmerk.Rows[i].ItemArray[1].ToString());
            }
        }
        private void loadDGV()
        {
            dgv_barang.DataSource = ds_barang.Tables["invbarang"];

            //MessageBox.Show("Data count : " + ds_barang.Tables["invbarang"].Rows.Count);
            for (int i = 0; i < dgv_barang.ColumnCount; i++)
            {
                dgv_barang.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_barang.Columns["harga"].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgv_barang.Columns["qty"].Width = 40;
        }
        private void Inventory_Barang_Load(object sender, EventArgs e)
        { } 
        private void btn_next_Click(object sender, EventArgs e)
        { }

        private void btn_refresh_Click(object sender, EventArgs e)
        { 
            cbb_kategori.Text = "";
            cbb_merk.Text = "";
            textbox_searchkode.Text = "";
            queryDataset();
            reloadDGVWithFilter();
        }
        private void reloadDGVWithFilter()
        { 
            ds_barang.Tables["invbarang"].DefaultView.RowFilter = string.Format("(nama LIKE '%{0}%' or kode LIKE '%{1}%') and kategori LIKE '%{2}%' and merk LIKE '%{3}%' ", textbox_searchkode.Text, textbox_searchkode.Text, cbb_kategori.Text, cbb_merk.Text);
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data from Barang";
            dgv_barang.ClearSelection();
            dgvDefColor();
        }

        private void cbb_merk_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadDGVWithFilter();
        }

        private void cbb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadDGVWithFilter(); 
        }

        private void dgv_barang_CellClick(object sender, DataGridViewCellEventArgs e)  {  idxclicked = e.RowIndex;  }

        private void textbox_searchkode_KeyUp(object sender, KeyEventArgs e)
        { 
            reloadDGVWithFilter();
        }
    }
}
