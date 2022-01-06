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
    public partial class Detail_Delivery : Form
    {
        public Detail_Delivery(Delivery_History form1)
        {
            parent = form1;
            InitializeComponent();
            tb_kodeorder.Text = kode;
        }
        public String kode;
        Delivery_History parent = null;
        String querystr;
        DataSet dataset;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(cbb_partner.SelectedIndex != -1)
            {
                if(cbb_partner.SelectedIndex == 0)
                {
                    dataset = new DataSet();
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 3 WHERE KODE = '{kode}'", null);
                    querystr = $"SELECT B.ID , B.QTY , DO.QTY FROM BARANG B ,  D_ORDER_SUPPLIER DO WHERE DO.KODE_ORDER = '{kode}' AND DO.ID_BARANG = B.ID";
                    DB.executeDataSet(dataset,querystr, null,"BARANG");
                    for (int n = 0; n < dataset.Tables["BARANG"].Rows.Count;n++)
                    {
                        int tambahan = Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[1].ToString()) + Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[2].ToString());
                        String angkatambah = tambahan.ToString();
                        querystr = $"UPDATE BARANG_WAREHOUSE SET QTY = {angkatambah} WHERE ID_BARANG = {dataset.Tables["BARANG"].Rows[n].ItemArray[0].ToString()} AND ID_WAREHOUSE = {User.User_login.Id_warehouse}";
                        DB.executeQuery(querystr, null);
                    }
                }
                else if (cbb_partner.SelectedIndex == 1)
                {
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 4 WHERE KODE = '{kode}'", null);
                }
                else if (cbb_partner.SelectedIndex == 2)
                {
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 0 WHERE KODE = '{kode}'", null);
                }
                MessageBox.Show("Berhasil Diupdate!");
                parent.loaddgv();
                this.Dispose();
            }
        }

        private void Detail_Delivery_Load(object sender, EventArgs e)
        {
            tb_kodeorder.Text = kode;
        }
    }
}
