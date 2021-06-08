using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Tests
{
    [TestClass()]
    public class inputMoneyTests
    {
        [TestMethod()]
        public void TotalUangTest()
        {
            inputMoney input_money = new();
            Money money = new();
            inputMoney.TotalUang(10, money);

            Assert.AreEqual(10, 10);
        }
    }
}