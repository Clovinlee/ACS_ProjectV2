using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ACS
{
    class Barang
    {
        private int id;
        private string kode;
        private string nama;
        private string deskripsi;
        private int harga;
        private string kategori;
        private string merk;
        private int multiplier;
        private int qty;

        public Barang(int id, string kode, string nama, string deskripsi, int harga, string kategori, string merk, int multiplier, int qty)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.deskripsi = deskripsi;
            this.harga = harga;
            this.kategori = kategori;
            this.merk = merk;
            this.multiplier = multiplier;
            this.qty = qty;
        }
        public int getId() { return id; }
        public string getKode() { return kode; }
        public string getNama() { return nama; }
        public string getDeskripsi() { return deskripsi; }
        public int getHarga() { return harga; }
        public string getKategori() { return kategori; }
        public string getMerk() { return merk; }
        public int getMultiplier() { return multiplier; }
        public int getQty() { return qty; }
    }
}
