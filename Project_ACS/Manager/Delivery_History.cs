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
    public partial class Delivery_History : Form
    {
        public Delivery_History()
        {
            InitializeComponent();
            loadmasuk();
        }
        DataSet dataset;
        DataSet data;
        string querystr = "";
        public static Detail_Delivery f;
        public Panel getPl()
        {
            return pl;
        }
        void loadmasuk()
        {
            cbb_partner.Items.Clear();
            cbb_partner.Items.Add("Semua");
            cbb_partner.SelectedIndex = 0;
            data = new DataSet();
            querystr = "SELECT NAMA FROM BUSINESS_PARTNER";
            DB.executeDataSet(data, querystr, null, "PARTNER");
            cbb_partner.DataSource = data.Tables["PARTNER"];
            cbb_partner.ValueMember = "NAMA";
            cbb_partner.DisplayMember = "NAMA";
            loaddgv();
            settingDgv();
            
        }
        public void loaddgv()
        {
            
            dataset = new DataSet();
            querystr = $"SELECT HO.KODE as Kode , BP.NAMA AS Nama , HO.qty as Qty , HO.ETA as Estimation , (CASE WHEN HO.STATUS = 0 THEN 'Canceled' WHEN HO.STATUS = 1 THEN 'Pending' WHEN HO.STATUS = 2 THEN 'Late' WHEN HO.STATUS = 3 THEN 'Finished' ELSE 'Returned' END)  as STATUS FROM H_ORDER_SUPPLIER HO , BUSINESS_PARTNER BP WHERE BP.ID = HO.ID_PARTNER AND HO.ID_WAREHOUSE = {User.User_login.Id_warehouse}";
            DB.executeDataSet(dataset, querystr, null, "ORDER");
            
            
            dgv_barang.DataSource = dataset.Tables["ORDER"];
        }
        void settingDgv()
        {
            dgv_barang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_barang.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_barang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_barang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            DataGridViewColumn column1 = dgv_barang.Columns[0];
            column1.Width = 70;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void cbb_partner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataset = new DataSet();
            dataset.Clear();
            querystr = $"SELECT HO.KODE as Kode , BP.NAMA AS Nama , HO.qty as Qty , HO.ETA as Estimation , (CASE WHEN HO.STATUS = 0 THEN 'Canceled' WHEN HO.STATUS = 1 THEN 'Pending' WHEN HO.STATUS = 2 THEN 'Late' WHEN HO.STATUS = 3 THEN 'Finished' ELSE 'Returned' END) as STATUS FROM H_ORDER_SUPPLIER HO , BUSINESS_PARTNER BP WHERE HO.ID_PARTNER = {cbb_partner.SelectedIndex+1} AND BP.ID = HO.ID_PARTNER AND HO.ID_WAREHOUSE = {User.User_login.Id_warehouse}";
            DB.executeDataSet(dataset, querystr, null, "UBAH");
            dgv_barang.DataSource = dataset.Tables["UBAH"];
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataset.Clear();
            loaddgv();
        }
        int idx = -1;
        private void dgv_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(idx != -1)
            {
                if (dgv_barang.Rows[idx].Cells[4].Value.ToString() == "Pending" || dgv_barang.Rows[idx].Cells[4].Value.ToString() == "Late")
                {
                    f = new Detail_Delivery(this);
                    f.kode = dgv_barang.Rows[idx].Cells[0].Value.ToString();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hanya bisa mengedit order dengan status pending/late saja!");
                }
            }
        }

        private void dgv_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //munculkan form baru
            Delivery_History_Detail d = new Delivery_History_Detail(dgv_barang.Rows[idx].Cells["Kode"].Value.ToString());
            d.ShowDialog();
        }

        private void Delivery_History_Load(object sender, EventArgs e)
        {

        }
    }
}
