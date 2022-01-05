using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ACS.Manager
{
    public partial class Detail_Stock_Adjustment : Form
    {
        public Detail_Stock_Adjustment()
        {
            InitializeComponent();
        }

        public Detail_Stock_Adjustment(DataSet ds_barang,DataSet ds_adjustment, DataSet ds_barangwarehouse, Inventory_Opname frm_adjust) : this()
        {
            this.ds_barang = ds_barang;
            this.ds_adjustment = ds_adjustment;
            this.ds_barangwarehouse = ds_barangwarehouse;
            this.frm_adjust = frm_adjust;
        }

        Inventory_Opname frm_adjust;
        DataSet ds_adjustment;
        DataSet ds_barang;
        DataSet ds_barangwarehouse;

        private void Detail_Stock_Adjustment_Load(object sender, EventArgs e)
        {
            num_newqty.Controls[0].Visible = false;
            num_oldqty.Controls[0].Visible = false;
        }
        DataRow[] dr2;
        private void btn_check_Click(object sender, EventArgs e)
        {
            DataRow[] dr = ds_barang.Tables[0].Select($"kode = '{tb_kode.Text.ToUpper()}'");
            if(dr.Length == 1)
            {
                string id = dr[0][0].ToString();
                dr2 = ds_barangwarehouse.Tables[0].Select($"id_barang = '{id}'");
                if(dr2.Length == 1)
                {
                    gb_adjust.Enabled = true;
                    gb_adjust.Text = dr[0][2].ToString();
                    num_oldqty.Value = Convert.ToDecimal(dr2[0][3].ToString());

                }
                else
                {
                    MessageBox.Show("Barang tidak ter registrasi di warehouse!");
                }
            }
            else
            {
                MessageBox.Show("Barang tidak ditemukan!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            gb_adjust.Enabled = false;
            num_newqty.Value = 1;
            num_oldqty.Value = 1;
            tb_keterangan.Text = "";
            tb_kode.Text = "";
            gb_adjust.Text = "Stock Adjustment";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(num_newqty.Value == num_oldqty.Value)
            {
                MessageBox.Show("Jumlah baru dan lama tidak boleh sama!");
            }
            else
            {
                int id_insert = Convert.ToInt32(DB.executeScalar("SELECT max(id)+1 from adjustment", null));
                DB.executeQuery($"INSERT INTO ADJUSTMENT VALUES({id_insert},{num_newqty.Value},{num_oldqty.Value},TO_DATE('{System.DateTime.Now.ToShortDateString()}', 'DD/MM/YYYY'),{dr2[0][2]},{User.User_login.Id_warehouse},'{tb_keterangan.Text}')", null);
                DB.executeQuery($"UPDATE BARANG_WAREHOUSE SET QTY = {num_newqty.Value} WHERE ID = {dr2[0][0]}", null);
                frm_adjust.loadDgv();
                MessageBox.Show("Sukses adjust stok!");
                this.Close();
            }
        }
    }
}
