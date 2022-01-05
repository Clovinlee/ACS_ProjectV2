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
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
            refreshData();
        }

        public Panel getPl()
        {
            return pl;
        }

        DataSet ds_keluarmasuk;

        public void refreshData()
        {
            ds_keluarmasuk = new DataSet();
            DB.executeDataSet(ds_keluarmasuk, "SELECT NVL(tb1.bulan,tb2.bulan) AS bulan, NVL(tb1.totalqty,0) AS keluar, NVL(tb2.totalqty,0) AS masuk FROM(select SUM(QTY) AS totalqty, TO_CHAR(TANGGAL, 'MM') AS bulan from HISTORY_BARANG_KELUAR_MASUK WHERE TO_CHAR(TANGGAL, 'YYYY') = TO_CHAR(SYSDATE, 'YYYY') AND status = 0 GROUP BY TO_CHAR(TANGGAL, 'MM') ORDER BY 2) tb1 FULL OUTER JOIN (select SUM(QTY) AS totalqty, TO_CHAR(TANGGAL, 'MM') AS bulan from HISTORY_BARANG_KELUAR_MASUK WHERE TO_CHAR(TANGGAL, 'YYYY') = TO_CHAR(SYSDATE, 'YYYY') AND status = 1 GROUP BY TO_CHAR(TANGGAL, 'MM') ORDER BY 2) tb2 ON tb1.bulan = tb2.bulan ORDER BY 1 ASC", null, "data");
            loadDgvKeluarMasuk();
        }

        public void loadDgvKeluarMasuk()
        {
            List<string> listBulan = new List<string>();
            listBulan.Add("Januari");
            listBulan.Add("Februari");
            listBulan.Add("Maret");
            listBulan.Add("April");
            listBulan.Add("Mei");
            listBulan.Add("Juni");
            listBulan.Add("Juli");
            listBulan.Add("Agustus");
            listBulan.Add("September");
            listBulan.Add("Oktober");
            listBulan.Add("November");
            listBulan.Add("Desember");

            List<int[]> listKeluarMasuk = new List<int[]>();
            for(int i = 0; i < listBulan.Count; i++)
            {
                bool valid = false;
                foreach (DataRow dr in ds_keluarmasuk.Tables[0].Rows)
                {
                    if(Convert.ToInt32(dr[0].ToString()) == i + 1)
                    {
                        listKeluarMasuk.Add(new int[] { Convert.ToInt32(dr[1]), Convert.ToInt32(dr[2]) });
                        valid = true;
                    }
                }
                if(valid == false)
                {
                    listKeluarMasuk.Add(new int[] { 0,0 });
                }
                dgv_keluarmasuk.Rows.Add(new object[] { listBulan[i], listKeluarMasuk });
            }
        }

        private void pl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
