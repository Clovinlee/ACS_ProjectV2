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
    public partial class Warehouse_History : Form
    {
        public Warehouse_History()
        {
            InitializeComponent();
            loadHistory();
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet dataset;
        string querystr = "";

        public void loadHistory()
        {
            dataset = new DataSet();
            querystr = "SELECT W1.NAMA AS \"Asal\", W2.NAMA AS \"Tujuan\", H.TOTAL_QTY AS \"Total Quantity\", H.TANGGAL AS \"Tanggal\", (CASE H.STATUS WHEN 1 THEN 'DITERIMA' WHEN 0 THEN 'PENDING' ELSE 'DITOLAK' END) AS \"Status\", H.KODE as KODE FROM H_PINDAH H, WAREHOUSE W1, WAREHOUSE W2 WHERE H.ASAL = W1.ID AND H.TUJUAN = W2.ID AND (W1.ID = :0 OR W2.ID = :0) ORDER BY Tanggal DESC";
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { User.User_login.Id_warehouse, "int32" });
            DB.executeDataSet(dataset, querystr, listParam, "HISTORY");
            dgvHistory.DataMember = "HISTORY";
            dgvHistory.DataSource = dataset;
            settingDgv();
        }

        void settingDgv()
        {
            //dgvWarehouse.Columns[3].Visible = false;
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvHistory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
            dgvHistory.Columns["KODE"].Visible = false;
            //dgvHistory.ClearSelection();
        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //buat munculin detail
            int idx = e.RowIndex;
            string kode = dgvHistory.Rows[idx].Cells["KODE"].Value.ToString();
            Warehouse_History_Detail w = new Warehouse_History_Detail(kode);
            w.ShowDialog();

        }
    }
}
