using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Money
    {
        //Class ini menginisiasi nominal uang sebelum user memasukan uang
        private int _value = 0;

        public int GetValue()
        {
            return _value;
        }

        public void SetValue(int value)
        {
            _value = value;
        }
    }
}
