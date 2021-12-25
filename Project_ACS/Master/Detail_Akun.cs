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
    public partial class Detail_Akun : Form
    {
        public Detail_Akun(Master_Akun form1)
        {
            parent = form1;
            InitializeComponent();
        }
        public String username;
        public String password;
        public String nama;
        public String alamat;
        public String email;
        public String jabatan;
        Master_Akun parent = null;
        DataSet ds;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtEmail.Text != "" && cbb_jabatan.SelectedIndex != -1)
            {
                ds = new DataSet();
                DB.executeDataSet(ds, $"SELECT count(*) FROM USERS WHERE username = '{txtUsername.Text}'", null, "listuser");
                DataTable dtlistuser = ds.Tables["listuser"];
                if (dtlistuser.Rows[0].ItemArray[0].ToString() == "0" || txtUsername.Text == username)
                {
                    DB.executeQuery($"UPDATE USERS SET USERNAME = '{txtUsername.Text}' , NAMA = '{txtNama.Text}' , PASSWORD = '{txtPass.Text}' , ALAMAT = '{txtAlamat.Text}' , EMAIL = '{txtEmail.Text}' , ID_JABATAN = {cbb_jabatan.SelectedIndex + 1} WHERE USERNAME = '{username}'",null);
                    MessageBox.Show("Updated!");
                    parent.loadAkun();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("User Sudah Dipakai");
                }
            }
            else
            {
                MessageBox.Show("Masih ada Field yang Kosong!");
            }
        }

        private void Detail_Akun_Load(object sender, EventArgs e)
        {
            
            ds = new DataSet();
            String querystr = $"SELECT * FROM USERS WHERE username = '{username}'";
            DB.executeDataSet(ds, querystr, null, "selecteduser");
            DataTable dtuser = ds.Tables["selecteduser"];
            
            txtUsername.Text = dtuser.Rows[0].ItemArray[2].ToString();
            txtNama.Text = dtuser.Rows[0].ItemArray[1].ToString();
            txtPass.Text = dtuser.Rows[0].ItemArray[3].ToString();
            txtAlamat.Text = dtuser.Rows[0].ItemArray[5].ToString();
            txtEmail.Text = dtuser.Rows[0].ItemArray[6].ToString();
            cbb_jabatan.SelectedIndex = Convert.ToInt32(dtuser.Rows[0].ItemArray[4].ToString()) - 1;
        }
    }
}
