using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    class inputUser : uangKembalian
    {
        public void menu(Money money)
        {
            //Method ini akan menampilkan menu yang dimiliki vending machine pada user
            //Selain itu, method ini akan menerima pesanan user berdasarkan kode unik yang telah di input
            Console.WriteLine("Semua minuman memiliki harga 10 ribu rupiah");

            showData tampil = new showData();

            Console.WriteLine("Masukan pilihan minuman anda sesuai dengan kode nomor yang tertera : ");

            pilihanUser(Console.ReadLine(), money);
        }

        private void pilihanUser(string pilihanMinuman, Money money)
        {
            //Setelah menerima kode unik dari method menu, sistem akan menampilkan kembalian user setelah diproses
            //Method ini juga akan menampilkan sebuah kalimat sesuai dengan minuman yang di pilih user
            bool _pilihanMinuman = false;
            while (!_pilihanMinuman)
            {
                switch (pilihanMinuman)
                {
                    case "1":
                        kembalian(money);
                        _pilihanMinuman = true;
                        break;
                    case "2":
                        kembalian(money);
                        _pilihanMinuman = true;
                        break;
                    case "3":
                        kembalian(money);
                        _pilihanMinuman = true;
                        break;
                    default:
                        Console.WriteLine("Kode minuman yang dimasukan salah, perhatikan kode minuman yang tertera");
                        pilihanUser(Console.ReadLine(), money);
                        _pilihanMinuman = false;
                        break;
                }
            }
        }
    }
}
