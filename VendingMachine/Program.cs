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
            inputMoney _inputMoney = new inputMoney();
            Money money = new Money();
            while (money.GetValue() == 0)
            {
                Console.WriteLine("Masukan uang anda dengan nominal 10, 20, 50, atau 100");
                uangPembelian = Convert.ToInt32(Console.ReadLine());
                _inputMoney.totalUang(uangPembelian, money);
            }


            inputUser pembeli = new inputUser();
            pembeli.menu(money);

            Console.WriteLine();
            Console.Write("Selamat menikmati minuman anda!");
        }
    }
}
