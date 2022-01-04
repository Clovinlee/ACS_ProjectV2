using Project_ACS.Master;
using System;
using System.Collections;
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
    public partial class MainMenu_Master : Form
    {
        Login frm_login;

        public MainMenu_Master()
        {
            InitializeComponent();
            btn_master.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
        }

        public MainMenu_Master(Login frm_login) : this()
        {
            this.frm_login = frm_login;
        }

        Timer master_collapse;
        Timer barang_collapse;

        private void collapseBarang(object sender, EventArgs e)
        {
            Boolean reverse = false;
            if (pl_submenu_barang.Tag.ToString() == "-1")
            {
                if (pl_submenu_barang.Height < pl_submenu_barang.MaximumSize.Height)
                {
                    pl_submenu_barang.Height += 15;
                    pl_submenu_master.Height += 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_barang.Height = pl_submenu_barang.MaximumSize.Height;
                    pl_submenu_barang.Height = pl_submenu_barang.MaximumSize.Height;
                    barang_collapse.Stop();
                }
            }
            else
            {
                if (pl_submenu_barang.Height > 0)
                {
                    pl_submenu_barang.Height -= 15;
                    pl_submenu_master.Height -= 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_barang.Height = 0;
                    pl_submenu_master.Height = pl_submenu_master.MaximumSize.Height - pl_submenu_barang.MaximumSize.Height;
                    barang_collapse.Stop();
                }
            }
            if (reverse)
            {
                pl_submenu_barang.Tag = Convert.ToInt32(pl_submenu_barang.Tag) * -1;
            }
        }

        private void collapseMaster(object sender, EventArgs e)
        {
            Boolean reverse = false;
            if (pl_submenu_master.Tag.ToString() == "-1")
            {
                int maxH = pl_submenu_master.MaximumSize.Height - pl_submenu_barang.MaximumSize.Height + pl_submenu_barang.Height;
                if (pl_submenu_master.Height < maxH)
                {
                    pl_submenu_master.Height += 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_master.Height = maxH;
                    master_collapse.Stop();
                }
            }
            else
            {
                if (pl_submenu_master.Height > 0)
                {
                    if(pl_submenu_barang.Height > 0)
                    {
                        pl_submenu_master.Height -= 30;
                    }
                    else
                    {
                        pl_submenu_master.Height -= 15;
                    }
                }
                else
                {
                    reverse = true;
                    pl_submenu_master.Height = 0;
                    master_collapse.Stop();
                }
            }
            if (reverse)
            {
                pl_submenu_master.Tag = Convert.ToInt32(pl_submenu_master.Tag) * -1;
            }

        }

        private void btn_master_Click(object sender, EventArgs e)
        {
            if (!master_collapse.Enabled)
            {
                master_collapse.Start();
                if (pl_submenu_master.Tag.ToString() == "1")
                {
                    btn_master.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
                }
                else
                {
                    btn_master.IdleIconRightImage = new Bitmap(res_icons.caret_up_solid);
                }
                btn_master.Reset();
            }
        }

        private void btn_master_inventory_Click(object sender, EventArgs e)
        {
            if (!barang_collapse.Enabled)
            {
                barang_collapse.Start();
                if (pl_submenu_barang.Tag.ToString() == "1")
                {
                    btn_master_inventory.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
                }
                else
                {
                    btn_master_inventory.IdleIconRightImage = new Bitmap(res_icons.caret_up_solid);
                }
                btn_master_inventory.Reset();
            }
        }

        private void MainMenu_Master_Load(object sender, EventArgs e)
        {
            master_collapse = new Timer();
            master_collapse.Interval = 1;
            master_collapse.Tick += new EventHandler(collapseMaster);

            barang_collapse = new Timer();
            barang_collapse.Interval = 1;
            barang_collapse.Tick += new EventHandler(collapseBarang);

            pl_submenu_master.Height = 0;
            pl_submenu_barang.Height = 0;

            initDS();
            initSubForm();
            buttonPress(btn_dashboard,e);
            lbl_nama.Text = "Welcome, " + User.User_login.Nama;
        }

        public void initDS()
        {
            ds_bp = new DataSet();
            ds_users = new DataSet();
            ds_warehouse = new DataSet();
            ds_barang = new DataSet();
            ds_kategori = new DataSet();
            ds_merk = new DataSet();

            DB.executeDataSet(ds_bp, "select * from business_partner", null, "bp");
            DB.executeDataSet(ds_users, "select * from users where status = 1", null, "users");
            DB.executeDataSet(ds_warehouse, "select * from warehouse where status = 1", null, "warehouse"); 
            //DB.executeDataSet(ds_barang, "SELECT b.kode, b.nama, b.deskripsi, b.harga, k.nama as kategori, m.nama as merk, b.MULTIPLIER, b.QTY FROM barang b join kategori k on b.ID_KATEGORI = k.id join merk m on b.ID_MERK = m.id WHERE B.status <> 0 order by b.id desc", null, "barang");
            DB.executeDataSet(ds_kategori, "select * from kategori", null, "kategori");
            DB.executeDataSet(ds_merk, "select * from merk", null, "merk");
        }

        public Master_Dashboard frm_dashboard;
        Master_Warehouse frm_warehouse;
        Master_Akun frm_akun;
        Master_Barang frm_barang;
        Master_Kategori frm_kategori;
        Master_Merk frm_merk;
        Master_BusinessPartner frm_bp;
        ArrayList listPanel;

        DataSet ds_users;
        DataSet ds_warehouse;
        DataSet ds_bp;
        DataSet ds_barang;
        DataSet ds_kategori;
        DataSet ds_merk;

        public void initSubForm()
        {
            frm_dashboard = new Master_Dashboard(ds_bp, ds_users, ds_warehouse, ds_barang, ds_kategori,ds_merk);
            frm_warehouse = new Master_Warehouse();
            frm_akun = new Master_Akun();
            frm_barang = new Master_Barang(ds_barang,this);
            frm_kategori = new Master_Kategori(ds_kategori,this);
            frm_merk = new Master_Merk(ds_merk,this);
            frm_bp = new Master_BusinessPartner(ds_bp, this);

            listPanel = new ArrayList();
            listPanel.Add(frm_dashboard.getPl());
            listPanel.Add(frm_barang.getPl());
            listPanel.Add(frm_kategori.getPl());
            listPanel.Add(frm_merk.getPl());
            listPanel.Add(frm_warehouse.getPl());
            listPanel.Add(frm_akun.getPl());
            listPanel.Add(frm_bp.getPl());
        }
        public void refreshFormBarang() {
            frm_barang.queryDataset();
        }
        private void buttonPress(Object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton b = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            pl_main.Controls.Clear();
            pl_main.Controls.Add((Panel)listPanel[Convert.ToInt32(b.Tag)]);
        }

        private void MainMenu_Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.Show();
            this.Dispose();
        }
    }
}
