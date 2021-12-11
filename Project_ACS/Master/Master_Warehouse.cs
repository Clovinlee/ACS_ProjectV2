using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_ACS.Master;

namespace Project_ACS
{
    public partial class Master_Warehouse : Form
    {
        public Master_Warehouse()
        {
            InitializeComponent();
            loadWareHouse();
            cmbSort.SelectedIndex = 0;
        }

        DataSet dataset;
        string querystr = "";
        public static EditMasterWarehouse f;
        int selectedRow;

        public Panel getPl()
        {
            return pl;
        }

        public void loadWareHouse()
        {
            dataset = new DataSet();
            querystr = "SELECT NAMA AS \"Nama\", ALAMAT AS \"Alamat\", TELEPON AS \"Nomor Telepon\", ID FROM WAREHOUSE WHERE STATUS = 1";
            DB.executeDataSet(dataset, querystr, null, "WAREHOUSE");
            dgvWarehouse.DataMember = "WAREHOUSE";
            dgvWarehouse.DataSource = dataset;
            settingDgv();
        }

        void settingDgv()
        {
            dgvWarehouse.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvWarehouse.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvWarehouse.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvWarehouse.Columns[3].Visible = false;
            dgvWarehouse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvWarehouse.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvWarehouse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvWarehouse.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }

        void keyUp()
        {
            dataset = new DataSet();
            int status = 0;
            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            List<object[]> listParam = new List<object[]>();
            if (nama != "" && alamat == "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                querystr = "SELECT NAMA AS \"Nama\", ALAMAT AS \"Alamat\", TELEPON AS \"Nomor Telepon\", ID FROM WAREHOUSE WHERE STATUS = 1 AND LOWER(NAMA) LIKE '%' || :0 || '%'";
            }
            else if (nama == "" && alamat != "")
            {
                listParam.Add(new object[] { alamat, "varchar" });
                querystr = "SELECT NAMA AS \"Nama\", ALAMAT AS \"Alamat\", TELEPON AS \"Nomor Telepon\", ID FROM WAREHOUSE WHERE STATUS = 1 AND LOWER(ALAMAT) LIKE '%' || :0 || '%'";
            }
            else if (nama != "" && alamat != "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                listParam.Add(new object[] { alamat, "varchar" });
                querystr = "SELECT NAMA AS \"Nama\", ALAMAT AS \"Alamat\", TELEPON AS \"Nomor Telepon\", ID FROM WAREHOUSE WHERE STATUS = 1 AND LOWER(NAMA) LIKE '%' || :0 || '%' AND LOWER(ALAMAT) LIKE '%' || :1 || '%'";
            }
            else
            {
                loadWareHouse();
                status = 1;
            }
            if (status == 0)
            {
                DB.executeDataSet(dataset, querystr, listParam, "WAREHOUSE");
                dgvWarehouse.DataMember = "WAREHOUSE";
                dgvWarehouse.DataSource = dataset;
            }
        }

        private void txtSearch(object sender, KeyEventArgs e)
        {
            keyUp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0 && selectedRow <= dgvWarehouse.Rows.Count)
            {
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { dgvWarehouse.Rows[selectedRow].Cells[3].Value.ToString(), "int32" });
                string querystr = "SELECT COUNT(*) FROM RAK_WAREHOUSE WHERE ID_WAREHOUSE = :0";
                int cekAda = Convert.ToInt32(DB.executeScalar(querystr, listParam));
                querystr = "SELECT COUNT(*) FROM H_PINDAH WHERE ASAL = :0";
                cekAda += Convert.ToInt32(DB.executeScalar(querystr, listParam));
                querystr = "SELECT COUNT(*) FROM H_PINDAH WHERE TUJUAN = :0";
                cekAda += Convert.ToInt32(DB.executeScalar(querystr, listParam));
                querystr = "SELECT COUNT(*) FROM H_ORDER_SUPPLIER WHERE ID_WAREHOUSE = :0";
                cekAda += Convert.ToInt32(DB.executeScalar(querystr, listParam));
                querystr = "SELECT COUNT(*) FROM H_KELUAR_BARANG WHERE ID_WAREHOUSE = :0";
                cekAda += Convert.ToInt32(DB.executeScalar(querystr, listParam));
                if (cekAda > 0)
                {
                    MessageBox.Show("Data tersebut masih dipakai pada tabel lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Anda yakin hapus warehouse?", "Delete Warehouse", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataset = new DataSet();
                        querystr = "UPDATE WAREHOUSE SET STATUS = 0 WHERE ID = :0";
                        DB.executeDataSet(dataset, querystr, listParam, "WAREHOUSE");
                        loadWareHouse();
                        MessageBox.Show("Berhasil delete warehouse!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih Warehouse dulu", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0 && selectedRow <= dgvWarehouse.Rows.Count)
            {
                string nama = dgvWarehouse.Rows[selectedRow].Cells[0].Value.ToString();
                string alamat = dgvWarehouse.Rows[selectedRow].Cells[1].Value.ToString();
                string telp = dgvWarehouse.Rows[selectedRow].Cells[2].Value.ToString();
                string id = dgvWarehouse.Rows[selectedRow].Cells[3].Value.ToString();
                if (f != null)
                {
                    MessageBox.Show("Masih ada form yang terbuka", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    f = new EditMasterWarehouse("Edit", id, nama, alamat, telp, this);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Pilih Warehouse dulu", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (f != null)
            {
                MessageBox.Show("Masih ada form yang terbuka");
            }
            else
            {
                f = new EditMasterWarehouse("Insert", this);
                f.Show();
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cmbSort.SelectedIndex;
            if (idx == 0)
            {
                dgvWarehouse.Sort(dgvWarehouse.Columns[0], ListSortDirection.Ascending);
            }
            else if (idx == 1)
            {
                dgvWarehouse.Sort(dgvWarehouse.Columns[0], ListSortDirection.Descending);
            }
            else if (idx == 2)
            {
                dgvWarehouse.Sort(dgvWarehouse.Columns[1], ListSortDirection.Ascending);
            }
            else if (idx == 3)
            {
                dgvWarehouse.Sort(dgvWarehouse.Columns[1], ListSortDirection.Descending);
            }
        }
    }
}