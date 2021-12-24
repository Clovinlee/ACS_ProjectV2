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
    public partial class Add_Akun : Form
    {
        public Add_Akun(Master_Akun form1)
        {
            parent = form1;
            InitializeComponent();
        }
        DataSet ds;
        DataSet dataset;
        Master_Akun parent = null;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "" && txtNama.Text != "" && txtAlamat.Text != "" && txtEmail.Text != "" && cbb_jabatan.SelectedIndex != -1)
            {
                ds = new DataSet();
                DB.executeDataSet(ds, $"SELECT count(*) FROM USERS WHERE username = '{txtUsername.Text}'", null , "listuser");
                DataTable dtuser = ds.Tables["listuser"];
                if (dtuser.Rows[0].ItemArray[0].ToString() == "0")
                {
                    dataset = new DataSet();
                    String querystr = "SELECT u.USERNAME AS \"Username\", u.NAMA AS \"Nama\", j.NAMA AS \"Jabatan\", u.ALAMAT AS \"Alamat\", u.EMAIL AS \"Email\" FROM USERS u , JABATAN j WHERE u.ID_JABATAN = j.ID";
                    DB.executeDataSet(dataset, querystr, null, "USERS");
                    DataTable dtlistuser = dataset.Tables["USERS"];
                    int rowid = dtlistuser.Rows.Count;
                    DB.executeQuery($"INSERT INTO USERS VALUES({rowid+1},'{txtNama.Text}','{txtUsername.Text}','{txtPass.Text}',{cbb_jabatan.SelectedIndex+1},'{txtAlamat.Text}','{txtEmail.Text}',1)", null);
                    MessageBox.Show("Insert success!");
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

        private void cbb_jabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
