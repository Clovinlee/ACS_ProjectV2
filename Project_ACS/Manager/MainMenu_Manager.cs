using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace Project_ACS.Manager
{
    public partial class MainMenu_Manager : Form
    {
        Login frm_login;
        public MainMenu_Manager()
        {
            InitializeComponent();
        }

        public MainMenu_Manager(Login frm_login) : this()
        {
            this.frm_login = frm_login;
        }

        Timer delivery_collapse;
        Timer inventory_collapse;
        Timer warehouse_collapse;

        Manager_Dashboard frm_dashboard;
        
        Inventory_Barang frm_inventory_barang;
        Inventory_Opname frm_inventory_opname;
        Inventory_Rak frm_inventory_rak;
        Inventory_Tracking frm_inventory_tracking;

        Delivery_History frm_delivery_history;
        Delivery_Keluar frm_delivery_keluar;
        Delivery_Masuk frm_delivery_masuk;

        Warehouse_Access frm_warehouse_access;
        Warehouse_Request frm_warehouse_request;
        Warehouse_History frm_warehouse_history;

        ArrayList listPanel = new ArrayList();

        private void MainMenu_Manager_Load(object sender, EventArgs e)
        {
            pl_leftbar.VerticalScroll.Visible = false;

            pl_submenu_delivery.Height = 0;
            pl_submenu_inventory.Height = 0;
            pl_submenu_warehouse.Height = 0;

            delivery_collapse = new Timer();
            delivery_collapse.Interval = 1;
            delivery_collapse.Tick += new EventHandler(collapseDelivery);

            inventory_collapse = new Timer();
            inventory_collapse.Interval = 1;
            inventory_collapse.Tick += new EventHandler(collapseInventory);

            warehouse_collapse = new Timer();
            warehouse_collapse.Interval = 1;
            warehouse_collapse.Tick += new EventHandler(collapseWarehouse);

            initSubForm();
            initDS();
            buttonPress(btn_dashboard, e);

            lbl_nama.Text = "Welcome, " + User.User_login.Nama;
        }

        public void initDS()
        {

        }

        public void initSubForm()
        {
            frm_dashboard = new Manager_Dashboard();

            frm_inventory_barang = new Inventory_Barang();
            frm_inventory_opname = new Inventory_Opname();
            frm_inventory_rak = new Inventory_Rak();
            frm_inventory_tracking = new Inventory_Tracking();

            frm_delivery_history = new Delivery_History();
            frm_delivery_keluar = new Delivery_Keluar();
            frm_delivery_masuk = new Delivery_Masuk();

            frm_warehouse_access = new Warehouse_Access();
            frm_warehouse_history = new Warehouse_History();
            frm_warehouse_request = new Warehouse_Request();

            listPanel.Add(frm_dashboard.getPl());

            listPanel.Add(frm_inventory_barang.getPl());
            listPanel.Add(frm_inventory_rak.getPl());
            listPanel.Add(frm_inventory_opname.getPl());
            listPanel.Add(frm_inventory_tracking.getPl());

            listPanel.Add(frm_delivery_masuk.getPl());
            listPanel.Add(frm_delivery_keluar.getPl());
            listPanel.Add(frm_delivery_history.getPl());

            listPanel.Add(frm_warehouse_access.getPl());
            listPanel.Add(frm_warehouse_request.getPl());
            listPanel.Add(frm_warehouse_history.getPl());
        }

        private void collapseDelivery(object sender, EventArgs e) {
            Boolean reverse = false;
            if (pl_submenu_delivery.Tag.ToString() == "-1")
            {
                if(pl_submenu_delivery.Height < pl_submenu_delivery.MaximumSize.Height)
                {
                    pl_submenu_delivery.Height += 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_delivery.Height = pl_submenu_delivery.MaximumSize.Height;
                    delivery_collapse.Stop();
                }
            }
            else
            {
                if(pl_submenu_delivery.Height > 0)
                {
                    pl_submenu_delivery.Height -= 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_delivery.Height = 0;
                    delivery_collapse.Stop();
                }
            }
            if (reverse)
            {
                pl_submenu_delivery.Tag = (Convert.ToInt32(pl_submenu_delivery.Tag) * -1).ToString();
            }
        }
        
        private void collapseInventory(object sender, EventArgs e){
            Boolean reverse = false;
            if (pl_submenu_inventory.Tag.ToString() == "-1")
            {
                if (pl_submenu_inventory.Height < pl_submenu_inventory.MaximumSize.Height)
                {
                    pl_submenu_inventory.Height += 25;
                }
                else
                {
                    reverse = true;
                    pl_submenu_inventory.Height = pl_submenu_inventory.MaximumSize.Height;
                    inventory_collapse.Stop();
                }
            }
            else
            {
                if (pl_submenu_inventory.Height > 0)
                {
                    pl_submenu_inventory.Height -= 25;
                }
                else
                {
                    reverse = true;
                    pl_submenu_inventory.Height = 0;
                    inventory_collapse.Stop();
                }
            }
            if (reverse)
            {
                pl_submenu_inventory.Tag = (Convert.ToInt32(pl_submenu_inventory.Tag) * -1).ToString();
            }
        }
        
        private void collapseWarehouse(object sender, EventArgs e)
        {
            Boolean reverse = false;
            if (pl_submenu_warehouse.Tag.ToString() == "-1")
            {
                if (pl_submenu_warehouse.Height < pl_submenu_warehouse.MaximumSize.Height)
                {
                    pl_submenu_warehouse.Height += 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_warehouse.Height = pl_submenu_warehouse.MaximumSize.Height;
                    warehouse_collapse.Stop();
                }
            }
            else
            {
                if (pl_submenu_warehouse.Height > 0)
                {
                    pl_submenu_warehouse.Height -= 15;
                }
                else
                {
                    reverse = true;
                    pl_submenu_warehouse.Height = 0;
                    warehouse_collapse.Stop();
                }
            }
            if (reverse)
            {
                pl_submenu_warehouse.Tag = (Convert.ToInt32(pl_submenu_warehouse.Tag) * -1).ToString();
            }
        }
        
        private void btn_inventory_Click(object sender, EventArgs e)
        {
            if (!inventory_collapse.Enabled)
            {
                inventory_collapse.Start();
                if (pl_submenu_inventory.Tag.ToString() == "-1")
                {
                    btn_inventory.IdleIconRightImage = new Bitmap(res_icons.caret_up_solid);
                }
                else
                {
                    btn_inventory.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
                }
                btn_inventory.Reset();
            }
        }
        
        private void btn_delivery_Click(object sender, EventArgs e)
        {
            if (!delivery_collapse.Enabled)
            {
                delivery_collapse.Start();
                if (pl_submenu_delivery.Tag.ToString() == "-1")
                {
                    btn_delivery.IdleIconRightImage = new Bitmap(res_icons.caret_up_solid);
                }
                else
                {
                    btn_delivery.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
                }
                btn_delivery.Reset();
            }
        }
        
        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            if (!warehouse_collapse.Enabled)
            {
                warehouse_collapse.Start();
                if (pl_submenu_warehouse.Tag.ToString() == "-1")
                {
                    btn_warehouse.IdleIconRightImage = new Bitmap(res_icons.caret_up_solid);
                }
                else
                {
                    btn_warehouse.IdleIconRightImage = new Bitmap(res_icons.caret_down_solid);
                }
                btn_warehouse.Reset();
            }
        }

        private void buttonPress(object sender, EventArgs e)
        {
            BunifuButton b = (BunifuButton)sender;
            pl_main.Controls.Clear();
            int btag = Convert.ToInt32(b.Tag.ToString());
            switch (btag)
            {
                case 0:
                    frm_dashboard.refreshData();
                    break;
                case 1: 
                    frm_inventory_barang.queryDataset();
                    break;
                case 2:
                    break;
                case 3:
                    frm_inventory_opname.refreshData();
                    break;
                case 4:
                    frm_inventory_tracking.queryDataset();
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:
                    frm_warehouse_access.loadReq();
                    break;
                case 9:
                    frm_warehouse_request.loadBarang();
                    frm_warehouse_request.settingDgv();
                    break;
                case 10:
                    frm_warehouse_history.loadHistory();
                    break;
                case 11:

                    break;
            }
            pl_main.Controls.Add((Panel)listPanel[btag]);
        }

        private void MainMenu_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.Show();
            this.Dispose();
        }
    }
}
