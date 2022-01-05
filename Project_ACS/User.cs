using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ACS
{
    class User
    {
        private string id;
        private string nama;
        private string username;
        private string password;
        private string id_jabatan;
        private string alamat;
        private string email;
        private string status;
        private string nama_jabatan;
        private string id_warehouse;
        private static User user_login = null;

        public User(string id, string nama, string username, string password, string id_jabatan, string alamat, string email, string status)
        {
            this.id = id;
            this.nama = nama;
            this.username = username;
            this.password = password;
            this.id_jabatan = id_jabatan;
            this.alamat = alamat;
            this.email = email;
            this.status = status;
            getNamaJabatan();
            getIdWarehouse();
            Console.WriteLine(id_warehouse);
        }

        public void getIdWarehouse()
        {
            this.id_warehouse = Convert.ToString(DB.executeScalar($"select id_user from warehouse where id_user = {this.id}",null));
        }

        private void getNamaJabatan()
        {
            this.nama_jabatan = (string)DB.executeScalar("select nama from jabatan where id = " + this.id_jabatan,null);
        }

        public string Id_warehouse { get => id_warehouse; }
        public string Id { get => id; }
        public string Nama { get => nama; }
        public string Username { get => username; }
        public string Password { get => password; }
        public string Id_jabatan { get => id_jabatan; }
        public string Alamat { get => alamat; }
        public string Email { get => email; }
        public string Status { get => status; }
        public static User User_login { get => user_login; set => user_login = value; }
        public string Nama_jabatan { get => nama_jabatan; }
    }
}
