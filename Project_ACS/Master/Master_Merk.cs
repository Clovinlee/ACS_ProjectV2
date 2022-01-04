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
    public partial class Master_Merk : Form
    {
        public Master_Merk()
        {
            InitializeComponent();
            queryDataset();
            btn_close_Click(null, null);
        }
        public Master_Merk(DataSet ds_merk, MainMenu_Master frm_master) : this()
        {
            InitializeComponent();
            this.ds_merk = ds_merk;
            this.frm_menumaster = frm_master;
            queryDataset();
            btn_close_Click(null, null);
        } 
        public MainMenu_Master frm_menumaster;
        public Panel getPl()
        {
            return pl;
        }
        DataSet ds_merk = new DataSet(); int idxclicked = -1;
        public void queryDataset()
        {
            dgv_merk.DataSource = null;
            ds_merk = new DataSet();
            DB.executeDataSet(ds_merk, "SELECT id,nama from merk order by id desc", null, "tmerk");
            dgv_merk.DataSource = ds_merk.Tables["tmerk"];
            settingDGV();
            dgv_merk.Columns["id"].Width = 90;
            setAutoComplete();
        }
        void settingDGV()
        {
            for (int i = 0; i < 2; i++)
            {
                dgv_merk.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_merk.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_merk.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_merk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_merk.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }
        void setAutoComplete()
        {
            AutoCompleteStringCollection cm = new AutoCompleteStringCollection();
            for (int i = 0; i < dgv_merk.RowCount; i++)
            {
                cm.Add(dgv_merk.Rows[i].Cells["id"].Value.ToString());
                cm.Add(dgv_merk.Rows[i].Cells["nama"].Value.ToString());
            }
            textbox_searchkode.AutoCompleteCustomSource = cm;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {  
            modeCRUD("insert");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (idxclicked < 0)
            {
                MessageBox.Show("Anda harus memilih data yang mau diperbaharui", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modeCRUD("update");
            }
        } 
        private void modeCRUD(string mode)
        {
            txtnama.Text = "";
            if (mode == "update")
            {
                groupBox1.Visible = true;
                btnExe.Text = "Update";
                txtnama.Text = dgv_merk.Rows[idxclicked].Cells["nama"].Value.ToString();
                txtid.Text = dgv_merk.Rows[idxclicked].Cells["id"].Value.ToString();
                btnExe.onHoverState.FillColor = Color.FromArgb(128, 255, 255);
            }
            else if (mode == "insert")
            {
                groupBox1.Visible = true;
                btnExe.Text = "Insert";
                txtid.Text = "-";
                btnExe.onHoverState.FillColor = Color.FromArgb(0, 230, 115);
            }
            else
            {
                groupBox1.Visible = false;
                txtid.Text = "";
                btnExe.onHoverState.FillColor = Color.FromArgb(0, 230, 115);
                btnExe.Text = "";
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        { 
            textbox_searchkode.Text = "";
            reloadDGVWithFilter();
            modeCRUD("close");
        }

        private void textbox_searchkode_KeyUp(object sender, KeyEventArgs e)
        {
            reloadDGVWithFilter(); 
        }
        private void reloadDGVWithFilter()
        {
            try
            {
                int intsearch = Convert.ToInt32(textbox_searchkode.Text);
                ds_merk.Tables["tmerk"].DefaultView.RowFilter = string.Format("nama LIKE '%{0}%' or id = {1}", textbox_searchkode.Text, intsearch);
            }
            catch (Exception exc)
            {
                ds_merk.Tables["tmerk"].DefaultView.RowFilter = string.Format("nama LIKE '%{0}%'", textbox_searchkode.Text);
            }
            idxclicked = -1;
            dgv_merk.ClearSelection();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            modeCRUD("close");
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                MessageBox.Show("Semua field harus terisi");
                return;
            }
            if (btnExe.Text == "Insert")
            {
                int idnew = Convert.ToInt32(ds_merk.Tables["tmerk"].Rows[0].ItemArray[0].ToString()) + 1;
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { idnew, "int32" });
                listParam.Add(new object[] { txtnama.Text, "varchar" });
                DB.executeQuery("INSERT INTO MERK VALUES(:0,:1)", listParam);
                queryDataset();
                MessageBox.Show("Insert success!");
                txtnama.Text = "";
                frm_menumaster.refreshFormBarang();

            }
            else if (btnExe.Text == "Update")
            {
                string paramnama = txtnama.Text;
                int paramid = Convert.ToInt32(txtid.Text);
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { paramnama, "varchar" });
                listParam.Add(new object[] { paramid, "int32" });
                DB.executeQuery("UPDATE MERK SET NAMA = :0 WHERE ID = :1 ", listParam);
                queryDataset();
                MessageBox.Show("Update success!");
                modeCRUD("close");
                frm_menumaster.refreshFormBarang();
            }

        }

        private void dgv_merk_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            idxclicked = e.RowIndex;
        }
    }
}
