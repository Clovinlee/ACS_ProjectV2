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

        public Master_Dashboard(DataSet ds_bp) : this()
        {
            this.ds_bp = ds_bp;
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
            loadData();
        }

        DataSet ds_akun;
        DataSet ds_warehouse;
        DataSet ds_bp;
        DataSet ds_barang;
        DataSet ds_kategori;
        DataSet ds_merk;


        public void loadData()
        {
            //ds_bp = new DataSet();
            //DB.executeDataSet(ds_bp, "select * from business_partner order by id desc",null,"bp");

            jml_akun = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from users where status = 1", null));
            jml_warehouse = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from warehouse where status = 1", null));
            jml_barang = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from barang where status = 1", null));
            jml_kategori = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from kategori", null));
            jml_merk = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from merk", null));

            lbl_jmlakun.Text = jml_akun.ToString();
            lbl_jmlwarehouse.Text = jml_warehouse.ToString();
            lbl_jmlbarang.Text = jml_barang.ToString();
            lbl_jmlakategori.Text = jml_kategori.ToString();
            lbl_jmlmerk.Text = jml_merk.ToString();

            loadData("business partner");


            DataSet ds_temp = new DataSet();
            DB.executeDataSet(ds_temp, "select tb.* FROM(SELECT * from users where status = 1 ORDER BY ID DESC) tb WHERE ROWNUM <= 1", null, "akun");
            lbl_lastakun.Text = ds_temp.Tables[0].Rows[0][1].ToString();

            DB.executeDataSet(ds_temp, "select tb.* FROM(SELECT * from warehouse where status = 1 ORDER BY ID DESC) tb WHERE ROWNUM <= 1", null, "wh");
            lbl_lastwarehouse.Text = ds_temp.Tables[1].Rows[0][1].ToString();
        }

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

            }else if(mode.ToLower() == "kategori")
            {

            }else if(mode.ToLower() == "merk")
            {

            }else if(mode.ToLower() == "warehouse")
            {

            }else if(mode.ToLower() == "akun")
            {

            }
        }

        private void Master_Dashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
