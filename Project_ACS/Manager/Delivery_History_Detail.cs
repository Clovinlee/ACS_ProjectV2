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
    public partial class Delivery_History_Detail : Form
    {
        public Delivery_History_Detail(string k)
        {
            kode = k;
            InitializeComponent();
        }
        string kode;
        private void Delivery_History_Detail_Load(object sender, EventArgs e)
        {
            DataTable d = DB.get($"SELECT HO.*,BP.NAMA AS NamaBP, (CASE WHEN HO.STATUS = 0 THEN 'Canceled' WHEN HO.STATUS = 1 THEN 'Pending' WHEN HO.STATUS = 2 THEN 'Late' WHEN HO.STATUS = 3 THEN 'Finished' ELSE 'Returned' END) as statusString FROM H_ORDER_SUPPLIER HO JOIN BUSINESS_PARTNER BP ON BP.ID = HO.ID_PARTNER WHERE HO.KODE='{kode}'");
          
            lblKode.Text = d.Rows[0].Field<string>("KODE");
            lblPartner.Text = d.Rows[0].Field<string>("NamaBP");
            lblEstimasi.Text = d.Rows[0].Field<DateTime>("ETA").ToString("dd/MM/yyyy");
            lblStatus.Text = d.Rows[0].Field<string>("statusString");
            lblQty.Text = d.Rows[0].Field<decimal>("QTY").ToString();
            lblWarehouse.Text = "Warehouse "+d.Rows[0].Field<decimal>("ID_WAREHOUSE").ToString();
            lblTotal.Text = "Rp"+d.Rows[0].Field<decimal>("GRAND_TOTAL").ToString("N");

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
