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
    public partial class Detail_Master_BusinessPartner : Form
    {
        public Detail_Master_BusinessPartner()
        {
            InitializeComponent();
        }

        public Detail_Master_BusinessPartner(DataGridViewRow rw) : this()
        {
            editRow = rw;
        }

        DataGridViewRow editRow;

        public Master_BusinessPartner Frm_masterbp { get; set; }

        private void Detail_Master_BusinessPartner_Load(object sender, EventArgs e)
        {
            
            if(editRow == null)
            {
                btn_update.Text = "Insert";
                lbl_kode.Text = "";
            }
            else
            {
                lbl_kode.Text = editRow.Cells[1].Value.ToString();
                tb_nama.Text = editRow.Cells[2].Value.ToString();
                tb_telepon.Text = editRow.Cells[3].Value.ToString();
                tb_alamat.Text = editRow.Cells[4].Value.ToString();
            }
        }

        private Boolean checkValid()
        {
            if(tb_nama.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                if (editRow == null)
                {
                    //INSERT
                    int id = Convert.ToInt32(DB.executeScalar("select MAX(id)+1 FROM business_partner", null));
                    string kode = "BP"+id.ToString("0000");
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { id, "int32" });
                    listParam.Add(new object[] { kode, "varchar" });
                    listParam.Add(new object[] { tb_nama.Text, "varchar" });
                    listParam.Add(new object[] { tb_telepon.Text, "varchar" });
                    listParam.Add(new object[] { tb_alamat.Text, "varchar" });

                    DB.executeQuery("INSERT INTO BUSINESS_PARTNER VALUES(:0, :1, :2, :3, :4)", listParam);

                    //loadDGV selalu dijalankan setiap update / insert / delete. Ingat
                    Frm_masterbp.loadDgv();

                    MessageBox.Show("Sukses tambah business partner!","Sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //UPDATE
                    List<object[]> listParam = new List<object[]>();
                    listParam.Add(new object[] { tb_nama.Text, "varchar" });
                    listParam.Add(new object[] { tb_telepon.Text, "varchar" });
                    listParam.Add(new object[] { tb_alamat.Text, "varchar" });
                    listParam.Add(new object[] { lbl_kode.Text, "varchar" });

                    DB.executeQuery("UPDATE BUSINESS_PARTNER SET nama = :0, telepon = :1, alamat = :2 WHERE kode = :3", listParam);

                    //loadDGV selalu dijalankan setiap update / insert / delete. Ingat
                    Frm_masterbp.loadDgv();

                    MessageBox.Show("Sukses edit business partner!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Frm_masterbp.frm_menumaster.frm_dashboard.loadData("business partner");
            }
            else
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
