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
    public partial class Delivery_Masuk : Form
    {
        public Delivery_Masuk()
        {
            InitializeComponent();
            loadmasuk();
            
        }

        public Panel getPl()
        {
            return pl;
        }
        DataSet dataset;
        string querystr = "";

        void loadmasuk()
        {
            cbb_partner.Items.Clear();
            cbb_partner.Items.Add("Semua");
            cbb_partner.SelectedIndex = 0;
            dataset = new DataSet();
            querystr = "SELECT NAMA FROM BUSINESS_PARTNER";
            DB.executeDataSet(dataset, querystr, null, "PARTNER");
            cbb_partner.DataSource = dataset.Tables["PARTNER"];
            cbb_partner.ValueMember = "NAMA";
            cbb_partner.DisplayMember = "NAMA";
            loaddgv();
            settingDgv();
        }
        void settingDgv()
        {
            //dgvWarehouse.Columns[3].Visible = false;
            dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvBarang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvBarang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            

            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            
        }

        void loaddgv()
        {
            dataset = new DataSet();
            querystr = $"SELECT B.KODE as Kode , B.NAMA AS Nama FROM BARANG B";
            DB.executeDataSet(dataset, querystr, null, "ORDER");
            dgvBarang.DataSource = dataset.Tables["ORDER"];

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
        private void Delivery_Masuk_Load(object sender, EventArgs e)
        {

        }
    }
}
