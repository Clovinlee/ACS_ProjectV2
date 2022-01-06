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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(cbb_partner.SelectedIndex != -1)
            {
                if(cbb_partner.SelectedIndex == 0)
                {
                    DB.executeQuery($"UPDATE H_ORDER_SUPPLIER SET STATUS = 3 WHERE KODE = '{kode}'", null);
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
