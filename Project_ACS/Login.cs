using System;
using Project_ACS.Manager;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;

namespace Project_ACS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //PROJECT BEGIN!

        private void Login_Load(object sender, EventArgs e)
        {
            string output = DB.init("chris", "clovinlee"); // GANTI SESUAI ORACLE MASING2
            if (output != "")
            {
                MessageBox.Show(output, "Database Initialization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_eye_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = !tb_password.UseSystemPasswordChar;
            if (tb_password.UseSystemPasswordChar)
            {
                lbl_eye.Image = new Bitmap(res_icons.eye_slash_solid);
                tb_password.PasswordChar = '●';
            }
            else
            {
                lbl_eye.Image = new Bitmap(res_icons.eye_solid);
                tb_password.PasswordChar = '\0';
            }
        }

        private void resetText()
        {
            tb_username.Text = "";
            tb_password.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Username / Password tidak boleh kosong!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = new DataSet();

                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { tb_username.Text, "varchar" });
                listParam.Add(new object[] { tb_password.Text, "varchar" });
                DB.executeDataSet(ds, "SELECT * FROM USERS WHERE USERNAME = :0 AND PASSWORD = :1",listParam,"usr");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string[] usr_data = new string[dr.ItemArray.Length];
                    for(int i = 0; i < usr_data.Length; i++)
                    {
                        usr_data[i] = dr.ItemArray[i].ToString();
                    }

                    User u = new User(usr_data[0], usr_data[1], usr_data[2], usr_data[3], usr_data[4], usr_data[5], usr_data[6], usr_data[7]);
                    User.User_login = u;
                }

                if(User.User_login == null)
                {
                    MessageBox.Show("Username / Password Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string id_j = User.User_login.Id_jabatan;
                    this.Hide();
                    resetText();
                    if (id_j == "1") //Master
                    {
                        MainMenu_Master frm_master = new MainMenu_Master(this);
                        frm_master.ShowDialog();
                    }else if(id_j == "2") //Manager
                    {
                        MainMenu_Manager frm_manager = new MainMenu_Manager(this);
                        frm_manager.ShowDialog();
                    }
                    else if(id_j == "3") //Pegawai
                    {
                        // TODO : This
                        // MainMenu_Pegawai frm_pegawai= new MainMenu_Pegawai();
                        // frm_pegawai.ShowDialog();
                    }
                }
            }
        }
    }
}
