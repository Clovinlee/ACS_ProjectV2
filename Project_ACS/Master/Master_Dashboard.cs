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

        private void loadForm()
        {
            jml_akun = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from users", null));
            jml_warehouse = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from warehouse", null));
            jml_barang = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from barang", null));
            jml_kategori = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from kategori", null));
            jml_merk = Convert.ToInt32(DB.executeScalar("SELECT COUNT(*) from merk", null));

            lbl_jmlakun.Text = jml_akun.ToString();
            lbl_jmlwarehouse.Text = jml_warehouse.ToString();
            lbl_jmlbarang.Text = jml_barang.ToString();
            lbl_jmlakategori.Text = jml_kategori.ToString();
            lbl_jmlmerk.Text = jml_merk.ToString();

            DataSet ds_temp = new DataSet();
            DB.executeDataSet(ds_temp, "select tb.* FROM(SELECT * from users where status = 1 ORDER BY ID DESC) tb WHERE ROWNUM <= 1", null, "akun");
            lbl_lastakun.Text = ds_temp.Tables[0].Rows[0][1].ToString();

            DB.executeDataSet(ds_temp, "select tb.* FROM(SELECT * from warehouse where status = 1 ORDER BY ID DESC) tb WHERE ROWNUM <= 1", null, "wh");
            lbl_lastwarehouse.Text = ds_temp.Tables[1].Rows[0][1].ToString();
        }

        private void Master_Dashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
