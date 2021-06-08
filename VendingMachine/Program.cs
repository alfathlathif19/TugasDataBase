using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int uangPembelian;
            inputMoney _inputMoney = new();
            Money money = new();
            while (money.GetValue() == 0)
            {
                Console.WriteLine("Masukan uang anda dengan nominal 10, 20, 50, atau 100");
                uangPembelian = Convert.ToInt32(Console.ReadLine());
                inputMoney.TotalUang(uangPembelian, money);
            }


            inputUser pembeli = new();
            pembeli.menu(money);

            Console.WriteLine();
            Console.Write("Selamat menikmati minuman anda!");
        }
    }
}
