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
    public partial class EditMasterWarehouse : Form
    {
        public EditMasterWarehouse(string pjudul, Master_Warehouse pmw)
        {
            InitializeComponent();
            lblJudul.Text = pjudul + " Warehouse";
            judul = pjudul;
            mw = pmw;
        }

        public EditMasterWarehouse(string pjudul, string pid, string pnama, string palamat, string ptelp, Master_Warehouse pmw)
        {
            InitializeComponent();
            lblJudul.Text = pjudul + " Warehouse";
            judul = pjudul;
            txtNama.Text = pnama;
            txtAlamat.Text = palamat;
            txtTelpon.Text = ptelp;
            id = pid;
            mw = pmw;
        }

        string id="";
        string judul;
        string querystr;
        DataSet dataset;
        Master_Warehouse mw;

        private void EditMasterWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Master_Warehouse.f = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataset = new DataSet();
            List<object[]> listParam = new List<object[]>();
            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string telepon = txtTelpon.Text;
            if (nama == "" || alamat == "" || telepon == "")
            {
                MessageBox.Show("Semua field harus terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (judul == "Insert")
                {
                    querystr = "SELECT ID FROM WAREHOUSE WHERE ROWNUM < 2 ORDER BY 1 DESC";
                    DB.executeDataSet(dataset, querystr, null, "LAST_ID");
                    int last_id = Convert.ToInt32(dataset.Tables[0].Rows[0]["ID"].ToString()) + 1;
                    //MessageBox.Show(last_id);
                    listParam.Add(new object[] { last_id.ToString(), "int32" });
                    listParam.Add(new object[] { nama, "varchar" });
                    listParam.Add(new object[] { alamat, "varchar" });
                    listParam.Add(new object[] { telepon, "varchar" });
                    listParam.Add(new object[] {  listUser.Rows[cbb_user.SelectedIndex].Field<decimal>("ID"), "int32" }) ;
                    listParam.Add(new object[] { "1", "int32" });
                    querystr = "INSERT INTO WAREHOUSE VALUES(:0, :1, :2, :3, :4, :5)";
                    MessageBox.Show("Berhasil Insert!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    listParam.Add(new object[] { nama, "varchar" });
                    listParam.Add(new object[] { alamat, "varchar" });
                    listParam.Add(new object[] { telepon, "varchar" });
                    listParam.Add(new object[] { listUser.Rows[cbb_user.SelectedIndex].Field<decimal>("ID"), "int32" });
                    listParam.Add(new object[] { id.ToString(), "int32" });
                    querystr = "UPDATE WAREHOUSE SET NAMA = :0, ALAMAT = :1, TELEPON = :2, ID_USER = :3 WHERE ID = :4";
                    MessageBox.Show("Berhasil Update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                DB.executeQuery(querystr, listParam);
                mw.loadWareHouse();
            }
        }

        DataTable listUser = new DataTable();
        private void EditMasterWarehouse_Load(object sender, EventArgs e)
        { 
            listUser = DB.get("SELECT * FROM USERS where ID_JABATAN=2");
            cbb_user.DataSource = DB.convertDataTableToList(listUser, "USERNAME", "string"); 
            
            if (id != "")
            {
                string choosed = DB.getScalar($"SELECT U.USERNAME FROM WAREHOUSE W JOIN USERS U ON U.ID = W.ID_USER WHERE W.ID={id}");
                cbb_user.SelectedItem = choosed;
                
            } 
        }
    }
}
