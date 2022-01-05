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
    public partial class Detail_Tracking : Form
    {
        public Detail_Tracking()
        {
            InitializeComponent();
        }
        public Detail_Tracking(String nama, String warehouse, int idbarang, int idwarehouse)
        {
            InitializeComponent();
            labelNamaBarang.Text = nama+" di "+warehouse;
            DataSet ds_barang = new DataSet(); 
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] {idwarehouse, "int32" });
            listParam.Add(new object[] { idbarang, "int32" });
            DB.executeDataSet(ds_barang, "SELECT H.TANGGAL, H.QTY, h.status, h.keterangan  FROM BARANG B JOIN HISTORY_BARANG_KELUAR_MASUK H ON B.ID = H.ID_BARANG WHERE H.ID_WAREHOUSE = :0 and B.ID = :1 order by h.TANGGAL desc", listParam, "invbarang");
            dgv_barang1.DataSource = ds_barang.Tables["invbarang"]; 
            dgv_barang1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 102, 204);
            dgv_barang1.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_barang1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 135, 224);
            dgv_barang1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 135, 224); 
            for (int i = 0; i < dgv_barang1.ColumnCount; i++)
            {
                dgv_barang1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_barang1.Columns["status"].Visible = false; 
            ds_barang.Tables["invbarang"].Columns.Add("Asal");
            ds_barang.Tables["invbarang"].Columns.Add("Tujuan");
            ds_barang.Tables["invbarang"].Columns.Add("Keterangan Tracking");
            namawarehouse = warehouse;
            idw = idwarehouse;
            idb = idbarang;
        }
        string namawarehouse = ""; int idw = 0; int idb = 0;
        private void Detail_Tracking_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_barang1.RowCount; i++)
            { 
                string[] list = dgv_barang1.Rows[i].Cells["keterangan"].Value.ToString().Split('-');
                string detail = list[0];
                int idx = Convert.ToInt32(list[1]);  
                String tujuan = "";
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { idx , "int32" });

                if (dgv_barang1.Rows[i].Cells["status"].Value.ToString() == "0")
                {
                    dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(224, 128, 128); //keluar = merah  
                    dgv_barang1.Rows[i].Cells["Asal"].Value = namawarehouse;
                  
                    if (detail == "P")
                    { 
                        dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Pindah Keluar";
                        tujuan = DB.executeScalar("SELECT NAMA FROM WAREHOUSE WHERE ID = :0", listParam).ToString();
                    }
                    else
                    {  
                        dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Delivery Keluar";
                        tujuan = DB.executeScalar("SELECT NAMA FROM BUSINESS_PARTNER WHERE ID = :0 ", listParam).ToString();
                    }
                    dgv_barang1.Rows[i].Cells["Tujuan"].Value = tujuan;
                }
                else
                {
                    dgv_barang1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192); //masuk = hijau  
                    dgv_barang1.Rows[i].Cells["Tujuan"].Value = namawarehouse;

                    if (detail == "P")
                    {
                        dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Pindah Masuk";
                        tujuan = DB.executeScalar("SELECT NAMA FROM WAREHOUSE WHERE ID = :0", listParam).ToString();
                    }
                    else
                    {
                        dgv_barang1.Rows[i].Cells["Keterangan Tracking"].Value = "Delivery Masuk";
                        tujuan = DB.executeScalar("SELECT NAMA FROM BUSINESS_PARTNER WHERE ID = :0 ", listParam).ToString();
                    }
                    dgv_barang1.Rows[i].Cells["Asal"].Value = tujuan;
                }
                 
            }
            dgv_barang1.Columns["keterangan"].Visible = false;

        }
        private void isiKolomSisa() { 
            
        }

    }
}
