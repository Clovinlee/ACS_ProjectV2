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
    public partial class Master_Barang : Form
    {
        public Master_Barang()
        {
            InitializeComponent();
            queryDataset();
        } 
        public Panel getPl()
        {
            return pl;
        }
        DataSet ds; int idxclicked = -1; 
        public void queryDataset()
        {
            ds = new DataSet();
            DB.executeDataSet(ds, "SELECT b.kode, b.nama, b.deskripsi, b.harga, k.nama as kategori, m.nama as merk, b.MULTIPLIER, b.QTY FROM barang b join kategori k on b.ID_KATEGORI = k.id join merk m on b.ID_MERK = m.id WHERE B.status <> 0", null, "tbarang");
            loadDGV();
            DB.executeDataSet(ds, "SELECT id,nama from kategori", null, "tkategori");
            DB.executeDataSet(ds, "SELECT id,nama from merk", null, "tmerk");
            fillCBB(); 
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();
            for (int i = 0; i < dgv_barang.RowCount; i++)
            {
                cm.Add(dgv_barang.Rows[i].Cells["kode"].Value.ToString());
                cm.Add(dgv_barang.Rows[i].Cells["nama"].Value.ToString());
            }
            textbox_searchkode.AutoCompleteCustomSource = cm;
            idxclicked = -1;
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data from Barang";
            btn_refresh_Click(null, null);
            dgv_barang.ClearSelection();
            dgvDefColor();
        }
        void dgvDefColor() { 
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
            DataTable dtkategori = ds.Tables["tkategori"];
            DataTable dtmerk = ds.Tables["tmerk"];
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
            dgv_barang.DataSource = null;
            dgv_barang.DataSource = ds.Tables["tbarang"]; 
            for (int i = 0; i < 7; i++)
            {
                dgv_barang.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_barang.Columns["harga"].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgv_barang.Columns["qty"].Width = 40;
        }
        private void pl_Paint(object sender, PaintEventArgs e)  { }

        private void btn_insert_Click(object sender, EventArgs e)
        { 
            DataSet dsUpdate = new DataSet();
            DB.executeDataSet(dsUpdate, "SELECT id from barang where rownum<2 order by 1 desc", null, "tupdate");
            int idd = Convert.ToInt32(dsUpdate.Tables["tupdate"].Rows[0].ItemArray[0].ToString()) + 1;

            Detail_Master_Barang dmb = new Detail_Master_Barang(this, "Insert", idd, "", "", "", 0, "", "", 0, 0);
            dmb.Text = "Insert Barang " + idd;
            dmb.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (idxclicked < 0)
            {
                MessageBox.Show("Anda harus memilih data yang mau diperbaharui", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet dsUpdate = new DataSet();
                DataGridViewRow drow = dgv_barang.Rows[idxclicked];
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { drow.Cells["kode"].Value.ToString(), "varchar" });
                DB.executeDataSet(dsUpdate, "SELECT id from barang where KODE LIKE '%' || :0 || '%' ", listParam, "tupdate");
                int idd = Convert.ToInt32(dsUpdate.Tables["tupdate"].Rows[0].ItemArray[0].ToString());
                Detail_Master_Barang dmb = new Detail_Master_Barang(this, "Update", idd, drow.Cells["kode"].Value.ToString(), drow.Cells["nama"].Value.ToString(), drow.Cells["deskripsi"].Value.ToString(), Convert.ToInt32(drow.Cells["harga"].Value.ToString()), drow.Cells["kategori"].Value.ToString(), drow.Cells["merk"].Value.ToString(), Convert.ToInt32(drow.Cells["multiplier"].Value.ToString()), 0);
                dmb.Text = "Update Barang " + idd;
                dmb.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (idxclicked < 0)
            {
                MessageBox.Show("Anda harus memilih data yang mau dihapus", "Fail", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin untuk menghapus data " + dgv_barang.Rows[idxclicked].Cells["nama"].Value.ToString() + " ? ", "Delete data", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { dgv_barang.Rows[idxclicked].Cells["kode"].Value.ToString(), "varchar" });
                    DB.executeQuery("UPDATE BARANG SET STATUS = 0 WHERE KODE LIKE '%' || :0 || '%' ", listParam);
                    MessageBox.Show("Deleted!");
                    queryDataset();
                }
            } 
        }

        private void textbox_searchkode_KeyUp(object sender, KeyEventArgs e)
        {
            reloadDGVWithFilter(); 
        }
        private void reloadDGVWithFilter()
        {//buat reload ulang dgv sesuai kondisi filter
            ds.Tables["tbarang"].DefaultView.RowFilter = string.Format("(nama LIKE '%{0}%' or kode LIKE '%{1}%') and kategori LIKE '%{2}%' and merk LIKE '%{3}%' ", textbox_searchkode.Text, textbox_searchkode.Text, cbb_kategori.Text, cbb_merk.Text);
            idxclicked = -1; 
            labeljumlah.Text = "Showing " + dgv_barang.RowCount + " data from Barang";
            dgv_barang.ClearSelection();
            dgvDefColor();
        }

        private void dgv_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idxclicked = e.RowIndex; 
            //setiap kali cell di datagrid diclick, index akan terganti
        }

        private void cbb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadDGVWithFilter(); 
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cbb_kategori.Text = "";
            cbb_merk.Text = "";
            textbox_searchkode.Text = "";
            reloadDGVWithFilter(); 
        }

        private void cbb_merk_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadDGVWithFilter(); 
        }
    }
}
