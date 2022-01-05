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
    public partial class Warehouse_Request : Form
    {
        public Warehouse_Request()
        {
            InitializeComponent();
            loadBarang();
            loadWarehouse();
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet dataset;
        string querystr = "";

        void loadWarehouse()
        {
            cmbWarehouse.Items.Clear();
            cmbWarehouse.Items.Add("");
            dataset = new DataSet();
            querystr = "SELECT ID, INITCAP(NAMA) AS \"NAMA\" FROM WAREHOUSE WHERE ID != :0";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "WAREHOUSE");
            cmbWarehouse.DataSource = dataset.Tables["WAREHOUSE"]; 
            cmbWarehouse.ValueMember = "ID"; 
            cmbWarehouse.DisplayMember = "NAMA"; 
            settingDgv();
        }

        void settingDgv()
        {
            //dgvWarehouse.Columns[3].Visible = false;
            dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvBarang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvBarang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column1 = dgvBarang.Columns[0];
            column1.Width = 70;
            DataGridViewColumn column3 = dgvBarang.Columns[2];
            column3.Width = 55;
            DataGridViewColumn column5 = dgvBarang.Columns[3];
            column5.Width = 140;

            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column2 = dgvCart.Columns[0];
            column2.Width = 70;
            DataGridViewColumn column4 = dgvCart.Columns[2];
            column4.Width = 100;
        }

        void loadBarang()
        {
            dataset = new DataSet();
            querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY || ' Dus' AS Qty FROM BARANG";
            querystr = "SELECT DISTINCT B.KODE AS KODE, B.NAMA AS NAMA, BW.QTY || ' Dus' AS QTY FROM BARANG B, BARANG_WAREHOUSE BW, WAREHOUSE W WHERE B.ID = BW.ID_BARANG AND BW.ID_WAREHOUSE = :0";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "BARANG");
            dgvBarang.DataMember = "BARANG";
            dgvBarang.DataSource = dataset;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvBarang.Columns.Add(btn);
            btn.HeaderText = "TAMBAH";
            btn.Text = "Tambah";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            dataset = new DataSet();
            querystr = "SELECT KODE AS Kode, NAMA AS Nama, QTY || ' Dus' AS Qty FROM BARANG WHERE 1=2";
            DB.executeDataSet(dataset, querystr, null, "BARANG");
            dgvCart.DataMember = "BARANG";
            dgvCart.DataSource = dataset;
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            String tgl = dtp1.Value.ToString("dd-M-yyyy");
            //MessageBox.Show(tgl);
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbWarehouse.SelectedValue.ToString());
        }
    }
}
