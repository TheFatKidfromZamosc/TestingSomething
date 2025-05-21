using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UłomneKoczkodany.Program;


namespace UłomneKoczkodany
{
    internal class BankTesting
    {
    [TestClass]
        public class BankTest
        {
            [TestMethod]
            public void WplataRetrurnCorrectResult()
            {
                var ban = new Bank(0, 0);
                bool result = ban.wplata(1000);
                ban.Equals(true);
                double kwota = ban.getStanKonta();
                kwota.Equals(1000);
            }
             [TestMethod]
        public void Wplata_RetrurnIncorrectResult()
            {
                var ban = new Bank(0, 0);
                bool result = ban.wplata(1000);
                ban.Equals(false);
                double kwota = ban.getStanKonta();
                kwota.Equals(99999999);
            }
            [TestMethod]
            public void Wyplata_ReturnCorrectResult()
            {
                var ban = new Bank(1000);
                var result = ban.wyplata(1);
                ban.Equals(true);
                var kwota = ban.getStanKonta();
                kwota.Equals(999);
            }
            [TestMethod]
            public void Wyplata_ReturnIncorrectResult()
            {
                var ban = new Bank(1000);
                var result = ban.wyplata(1);
                ban.Equals(false);
                var kwota = ban.getStanKonta();
                kwota.Equals(999999);
            }
        }


    }
}
