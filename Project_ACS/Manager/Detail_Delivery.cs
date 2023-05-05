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
            if (cbb_partner.SelectedIndex != -1)
            {
                if (cbb_partner.SelectedIndex == 0)
                {
                    //FINISHED
                    dataset = new DataSet();
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 3 WHERE KODE = '{kode}'", null);
                    querystr = $"SELECT B.ID , B.QTY , DO.QTY , BW.QTY , HO.ID_PARTNER , BP.NAMA FROM BARANG B ,  D_ORDER_SUPPLIER DO , BARANG_WAREHOUSE BW , BUSINESS_PARTNER BP , H_ORDER_SUPPLIER HO WHERE DO.KODE_ORDER = '{kode}' AND DO.ID_BARANG = B.ID AND B.ID = BW.ID_BARANG AND HO.KODE = DO.KODE_ORDER AND HO.ID_PARTNER = BP.ID";
                    DB.executeDataSet(dataset, querystr, null, "BARANG");
                    for (int n = 0; n < dataset.Tables["BARANG"].Rows.Count; n++)
                    {
                        int tambahan = Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[3].ToString()) + Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[2].ToString());
                        String angkatambah = tambahan.ToString();

                        int condition = Convert.ToInt32(DB.executeScalar("select count(*) from barang_warehouse where id_barang=" + dataset.Tables["BARANG"].Rows[n].ItemArray[0].ToString() + " and id_warehouse = " + User.User_login.Id_warehouse, null));
                        if (condition == 0)
                        {
                            //B.ID , B.QTY , DO.QTY , BW.QTY , HO.ID_PARTNER , BP.NAMA
                            int maxid = Convert.ToInt32(DB.executeScalar($"SELECT MAX(ID)+1 FROM BARANG_WAREHOUSE", null));
                            querystr = $"INSERT INTO BARANG_WAREHOUSE VALUES({maxid},{User.User_login.Id_warehouse},{dataset.Tables["BARANG"].Rows[n].ItemArray[0]},{dataset.Tables["BARANG"].Rows[n].ItemArray[2]},1)";
                            DB.executeQuery(querystr, null);
                        }
                        else
                        {
                            querystr = $"UPDATE BARANG_WAREHOUSE SET QTY = {angkatambah} WHERE ID_BARANG = {dataset.Tables["BARANG"].Rows[n].ItemArray[0].ToString()} AND ID_WAREHOUSE = {User.User_login.Id_warehouse}";
                            DB.executeQuery(querystr, null);
                            int tambahan1 = Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[1].ToString()) + Convert.ToInt32(dataset.Tables["BARANG"].Rows[n].ItemArray[2].ToString());
                            String angkatambah1 = tambahan1.ToString();
                            querystr = $"UPDATE BARANG SET QTY = {angkatambah1} WHERE ID = {dataset.Tables["BARANG"].Rows[n].ItemArray[0].ToString()}";
                            DB.executeQuery(querystr, null);
                        }
                            String keterangan = "D-" + Convert.ToString(dataset.Tables["BARANG"].Rows[n].ItemArray[4].ToString());
                        querystr = $"INSERT INTO HISTORY_BARANG_KELUAR_MASUK VALUES({dataset.Tables["BARANG"].Rows[n].ItemArray[0].ToString()},TO_DATE('{Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"))}', 'DD/MM/YYYY'),{dataset.Tables["BARANG"].Rows[n].ItemArray[2].ToString()},'{keterangan}',{User.User_login.Id_warehouse},'{dataset.Tables["BARANG"].Rows[n].ItemArray[5].ToString()}',1)";
                        DB.executeQuery(querystr, null);
                    }
                }
                else if (cbb_partner.SelectedIndex == 1)
                {
                    // RETURNED
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 4 WHERE KODE = '{kode}'", null);
                }
                else if (cbb_partner.SelectedIndex == 2)
                {
                    // CANCELLED
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