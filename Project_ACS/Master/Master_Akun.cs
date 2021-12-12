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
    public partial class Master_Akun : Form
    {
        public Master_Akun()
        {
            InitializeComponent();
            loadAkun();
        }
        DataSet dataset;
        string querystr = "";
        
        int selectedRow;
        public Panel getPl()
        {
            return pl;
        }
        public void loadAkun()
        {
            dataset = new DataSet();
            querystr = "SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID";
            DB.executeDataSet(dataset, querystr, null, "USERS");
            dgvAkun.DataMember = "USERS";
            dgvAkun.DataSource = dataset;
            settingDgv();
        }
        void settingDgv()
        {
            dgvAkun.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgvAkun.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAkun.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgvAkun.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224);
        }
        void keyUp()
        {
            dataset = new DataSet();
            int status = 0;
            string nama = txtNama.Text;
            string username = txtUsername.Text;
            string jabatan = txtJabatan.Text;
            List<object[]> listParam = new List<object[]>();
            if (nama == "" && username != "" && jabatan == "")
            {
                listParam.Add(new object[] { username, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.USERNAME) LIKE '%{username}%'";
            }
            else if (nama != "" && username == "" && jabatan == "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.NAMA) LIKE '%{nama}%'";
            }
            else if (nama == "" && username == "" && jabatan != "")
            {
                listParam.Add(new object[] { jabatan, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(j.NAMA) LIKE '%{jabatan}%'";
            }
            else if (nama != "" && username != "" && jabatan == "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                listParam.Add(new object[] { username, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.NAMA) LIKE '%{nama}%' AND LOWER(u.USERNAME) LIKE '%{username}%'";
            }
            else if (nama != "" && username == "" && jabatan != "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                listParam.Add(new object[] { jabatan, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.NAMA) LIKE '%{nama}%' AND LOWER(j.NAMA) LIKE '%{jabatan}%'";
            }
            else if (nama == "" && username != "" && jabatan != "")
            {
                listParam.Add(new object[] { username, "varchar" });
                listParam.Add(new object[] { jabatan, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.USERNAME) LIKE '%{username}%' AND LOWER(j.NAMA) LIKE '%{jabatan}%'";
            }
            else if (nama != "" && username != "" && jabatan != "")
            {
                listParam.Add(new object[] { nama, "varchar" });
                listParam.Add(new object[] { username, "varchar" });
                listParam.Add(new object[] { jabatan, "varchar" });
                querystr = $"SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.STATUS = 1 AND u.ID_JABATAN = j.ID AND LOWER(u.NAMA) LIKE '%{nama}%' AND LOWER(u.USERNAME) LIKE '%{username}%' AND LOWER(j.NAMA) LIKE '%{jabatan}%'";
            }
            else
            {
                loadAkun();
                status = 1;
            }
            if (status == 0)
            {
                DB.executeDataSet(dataset, querystr, null, "USERS");
                dgvAkun.DataMember = "USERS";
                dgvAkun.DataSource = dataset;
            }
        }
        private void txtSearch(object sender, KeyEventArgs e)
        {
            keyUp();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
