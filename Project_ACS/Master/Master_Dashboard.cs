using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Project_ACS
{
    public partial class Master_Dashboard : Form
    {
        public Master_Dashboard()
        {
            InitializeComponent();
        }

        public Master_Dashboard(DataSet ds_bp, DataSet ds_users, DataSet ds_warehouse, DataSet ds_barang, DataSet ds_kategori, DataSet ds_merk) : this()
        {
            this.ds_bp = ds_bp;
            this.ds_akun = ds_users;
            this.ds_warehouse = ds_warehouse;
            this.ds_barang = ds_barang;
            this.ds_kategori = ds_kategori;
            this.ds_merk = ds_merk;
        }

        public MainMenu_Master frm_menu;

        public Panel getPl()
        {
            loadForm();
            return pl;
        }

        int jml_akun = 0;
        int jml_warehouse = 0;
        int jml_barang = 0;
        int jml_kategori = 0;
        int jml_merk = 0;
        int jml_bp = 0;

        private void loadForm()
        {
            loadData("business partner");
            loadData("barang");
            loadData("kategori");
            loadData("merk");
            loadData("warehouse");
            loadData("akun");
        }

        DataSet ds_akun;
        DataSet ds_warehouse;
        DataSet ds_bp;
        DataSet ds_barang;
        DataSet ds_kategori;
        DataSet ds_merk;

        public void loadData(string mode)
        {
            if(mode.ToLower() == "business partner")
            {
                jml_bp = Convert.ToInt32(ds_bp.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlbp.Text = jml_bp.ToString();
                DataRow[] tmp = ds_bp.Tables[0].Select("id = max(id)");
                lbl_lastbp.Text = tmp[0][2].ToString();
                lbl_lastbptelp.Text = tmp[0][3].ToString();
                lbl_lastbpalamat.Text = tmp[0][4].ToString();
            }
            else if(mode.ToLower() == "barang")
            {
                jml_barang = Convert.ToInt32(ds_barang.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlbarang.Text = jml_barang.ToString();
                DataRow[] tmp = ds_barang.Tables[0].Select("id = max(id)");
                lbl_lastbarang.Text = tmp[0][2].ToString();
                lbl_lastbarangmerk.Text = (ds_merk.Tables[0].Select($"id = {tmp[0][6]}"))[0][1].ToString();
                lbl_lastbarangkategori.Text = (ds_kategori.Tables[0].Select($"id = {tmp[0][5]}"))[0][1].ToString();
            }
            else if(mode.ToLower() == "kategori")
            {
                jml_kategori = Convert.ToInt32(ds_kategori.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlakategori.Text = jml_kategori.ToString();
            }
            else if(mode.ToLower() == "merk")
            {
                jml_merk = Convert.ToInt32(ds_merk.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlmerk.Text = jml_merk.ToString();
            }else if(mode.ToLower() == "warehouse")
            {
                jml_warehouse = Convert.ToInt32(ds_warehouse.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlwarehouse.Text = jml_warehouse.ToString();
                DataRow[] tmp = ds_warehouse.Tables[0].Select("id = max(id)");
                lbl_lastwarehouse.Text = tmp[0][1].ToString();
            }else if(mode.ToLower() == "akun")
            {
                jml_akun = Convert.ToInt32(ds_akun.Tables[0].Compute("Count(id)", "5=5"));

                lbl_jmlakun.Text = jml_akun.ToString();
                DataRow[] tmp = ds_akun.Tables[0].Select("id = max(id)");
                lbl_lastakun.Text = tmp[0][1].ToString();
            }
        }

        private void Master_Dashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
