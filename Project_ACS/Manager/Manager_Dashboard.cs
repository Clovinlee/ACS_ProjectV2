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

        DataSet ds_keluar;
        DataSet ds_masuk;

        public void refreshData()
        {
            ds_keluar = new DataSet();
            ds_masuk = new DataSet();

            DB.executeDataSet(ds_masuk, "SELECT * FROM HISTORY_BARANG_KELUAR_MASUK WHERE status = 1", null,"msk");
            DB.executeDataSet(ds_keluar, "SELECT * FROM HISTORY_BARANG_KELUAR_MASUK WHERE status = 0", null, "klr");


            System.Windows.Forms.DataVisualization.Charting.Series masuk = chart_keluarmasuk.Series[1];
            System.Windows.Forms.DataVisualization.Charting.Series keluar = chart_keluarmasuk.Series[0];
            
            for(int i = 0; i < 12; i++)
            {
                
            }

            masuk.Points.AddXY("Maeasuk1", 15);
            masuk.Points.AddXY("Masuk2", 25);
            masuk.Points.AddXY("Masuk3", 35);
            masuk.Points.AddXY("Masuk4", 45);
            masuk.Points.AddXY("Masuk5", 55);

            keluar.Points.AddXY("Keluaras1", 50);
            keluar.Points.AddXY("Keluar1", 150);
            keluar.Points.AddXY("Keluar1", 250);
            keluar.Points.AddXY("Keluar1", 350);
            keluar.Points.AddXY("Keluar1", 450);

        }

        private void pl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
