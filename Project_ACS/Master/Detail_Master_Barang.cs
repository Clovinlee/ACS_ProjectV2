using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ACS.Master
{
    public partial class Detail_Master_Barang : Form
    {
        public Detail_Master_Barang()
        {
            InitializeComponent();
        }

        public Detail_Master_Barang(Master_Barang form1, string mode1, int id1, string kode1, string nama1, string deskripsi1, int harga1, string kategori1, string merk1, int multiplier1, int qty1)
        {
            InitializeComponent();
            parent = form1;
            mode = mode1;
            label1.Text = mode1 + " Barang";
            btn_ok.Text = mode1;
            if (mode1 == "Update")
            {
                barang = new Barang(id1, kode1, nama1, deskripsi1, harga1, kategori1, merk1, multiplier1, qty1);
            }
            else
            {
                idinsert = id1;
            }
            loadCombobox();
            if (mode == "Update")
            {
                txtKode.Text = barang.getKode();
                txtDeskripsi.Text = barang.getDeskripsi();
                txtNama.Text = barang.getNama();
                numMulti.Value = barang.getMultiplier();
                numHarga.Value = barang.getHarga();
                cbb_kategori.Text = barang.getKategori();
                cbb_merk.Text = barang.getMerk();
            }
            else
            {
                txtKode.Text = "-";
            }
        }
        string mode = ""; Barang barang = null; DataSet ds = new DataSet();
        int idinsert = -1; Master_Barang parent = null;
        private void Detail_Master_Barang_Load(object sender, EventArgs e)  { }
        List<int> idkategori = new List<int>();
        List<int> idmerk = new List<int>();
        private void loadCombobox()
        {
            DB.executeDataSet(ds, "SELECT id,nama from kategori", null, "tkategori");
            DB.executeDataSet(ds, "SELECT id,nama from merk", null, "tmerk");
            cbb_kategori.Items.Clear();
            idkategori.Clear();
            idmerk.Clear();
            cbb_merk.Items.Clear();
            cbb_kategori.DataSource = null;
            cbb_merk.DataSource = null;
            DataTable dtkategori = ds.Tables["tkategori"];
            DataTable dtmerk = ds.Tables["tmerk"];
            for (int i = 0; i < dtkategori.Rows.Count; i++)
            {
                idkategori.Add(Convert.ToInt32(dtkategori.Rows[i].ItemArray[0].ToString()));
                cbb_kategori.Items.Add(dtkategori.Rows[i].ItemArray[1].ToString());
            }
            for (int i = 0; i < dtmerk.Rows.Count; i++)
            {
                idmerk.Add(Convert.ToInt32(dtmerk.Rows[i].ItemArray[0].ToString()));
                cbb_merk.Items.Add(dtmerk.Rows[i].ItemArray[1].ToString());
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idkategori.Count+" isi kategori");
            if (txtNama.Text == "" || numHarga.Value < 1 || cbb_kategori.Text == "" || cbb_merk.Text == "" || numMulti.Value < 1)
            {
                MessageBox.Show("Semua field harus diisi");
                return;
            }
            if (txtNama.Text.Length < 2)
            {
                MessageBox.Show("Nama barang minimal 2 huruf ...");
                return;
            }
            int id1kategori = idkategori[cbb_kategori.SelectedIndex];
            int id1merk = idmerk[cbb_merk.SelectedIndex];
            //int id1kategori = -1;
            //int id1merk = 1;
            if (mode == "Update")
            {
                //search
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { txtNama.Text, "varchar" });
                listParam.Add(new object[] { txtDeskripsi.Text, "varchar" });
                listParam.Add(new object[] { (int)numMulti.Value, "int32" });
                listParam.Add(new object[] { (int)numHarga.Value, "int32" });
                listParam.Add(new object[] { id1kategori, "int32" });
                listParam.Add(new object[] { id1merk, "int32" });
                listParam.Add(new object[] { barang.getKode(), "varchar" });
                DB.executeQuery("UPDATE BARANG SET NAMA = :0, DESKRIPSI = :1, MULTIPLIER = :2, HARGA = :3, ID_KATEGORI = :4, ID_MERK = :5 WHERE KODE LIKE '%' || :6 || '%' ", listParam);
                MessageBox.Show("Updated!");
                parent.queryDataset();
                this.Dispose();
            }
            else
            { //insert  
                string kode = genKode(txtNama.Text);
                List<object[]> listParam = new List<object[]>();
                listParam.Add(new object[] { idinsert, "int32" });
                listParam.Add(new object[] { kode, "varchar" });
                listParam.Add(new object[] { txtNama.Text, "varchar" });
                listParam.Add(new object[] { txtDeskripsi.Text, "varchar" });
                listParam.Add(new object[] { (int)numHarga.Value, "int32" });
                listParam.Add(new object[] { id1kategori, "int32" });
                listParam.Add(new object[] { id1merk, "int32" });
                listParam.Add(new object[] { (int)numMulti.Value, "int32" });
                listParam.Add(new object[] { 0, "int32" });
                listParam.Add(new object[] { 1, "int32" });
                DB.executeQuery("INSERT INTO BARANG VALUES(:0,:1,:2,:3,:4,:5,:6,:7,:8,:9)", listParam);
                //MessageBox.Show("ID "+idinsert+" kategori "+id1kategori+" merk "+id1merk);
                MessageBox.Show("Insert success!");
                parent.queryDataset();
                this.Dispose();
            }
        }
        private string genKode(string nama)
        {
            string akhir = "B";
            int skrg = 0;
            if (nama.Contains(" "))
            {
                akhir += nama.Substring(0, 1) + "" + nama.Substring(instr(nama, ' ') + 1, 1);
            }
            else
            {
                akhir += nama.Substring(0, 2);
            }
            akhir = akhir.ToUpper();
            DataSet dsUpdate = new DataSet();
            List<object[]> listParam = new List<object[]>();
            listParam.Add(new object[] { akhir, "varchar" });
            DB.executeDataSet(dsUpdate, "SELECT count(*) from barang where kode like '%' || :0 || '%'", listParam, "tgenkode");
            int sekarang = Convert.ToInt32(dsUpdate.Tables["tgenkode"].Rows[dsUpdate.Tables["tgenkode"].Rows.Count - 1].ItemArray[0].ToString()) + 1;
            if (sekarang < 10)
            {
                akhir += "000" + sekarang;
            }
            else if (sekarang > 9 && sekarang < 100)
            {
                akhir += "00" + sekarang;
            }
            else if (sekarang > 99 && sekarang < 1000)
            {
                akhir += "0" + sekarang;
            }
            else
            {
                akhir += sekarang;
            }
            return akhir;
        }
        private int instr(string nama, char dicari)
        {
            for (int i = 0; i < nama.Length; i++)
            {
                if (nama[i] == dicari)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
