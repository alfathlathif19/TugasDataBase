using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class inputMoney
    {
        public void totalUang(int uangPembelian, Money money)
        {
            //Method ini akan menerima nominal uang yang diberikan oleh user, lalu menyimpannya dalam sistem
            switch (uangPembelian)
            {
                case (10):
                    money.SetValue(money.GetValue() + 10);
                    break;
                case (20):
                    money.SetValue(money.GetValue() + 20);
                    break;
                case (50):
                    money.SetValue(money.GetValue() + 50);
                    break;
                case (100):
                    money.SetValue(money.GetValue() + 100);
                    break;
                default:
                    Console.WriteLine("Uang tidak bisa dimasukan, mohon ubah nominalnya");
                    break;
            }
        }
    }
}
