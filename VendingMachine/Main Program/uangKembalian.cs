using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class uangKembalian
    {
        public int InisiasiUang { get; set; }

        public static void Kembalian(Money money)
        {
            //Nominal uang yang telah disimpan akan diperiksa besarannya
            //Apabila lebih dari 10 maka sistem akan memberikan kembalian sesuai dengan nominal uang yang diberikan user
            if (money.GetValue() > 10)
            {
                money.SetValue(money.GetValue() - 10);
                Console.WriteLine("Kembalian anda {0}", money.GetValue());
            }
        }
    }
}
