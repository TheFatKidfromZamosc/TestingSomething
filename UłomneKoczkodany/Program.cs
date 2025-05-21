namespace UłomneKoczkodany
{
    internal class Program
    {
        public class Bank

        {
            private double stanKonta;
            public int nrKlienta { get; private set; }
            public Bank(int nrKlienta, double stanKonta = 0)
            {
                this.nrKlienta = nrKlienta;
                this.stanKonta = stanKonta;
            }
            public double getStanKonta() => stanKonta;
            public bool wplata(double kwota)
            {
                if (kwota > 0)
                {
                    stanKonta += kwota;
                    return true;
                }
                return false;
            }
            public bool wyplata(double kwota)
            {
                if (kwota <=0)
                    return false;
                if (stanKonta > kwota)
                {
                    stanKonta -= kwota;
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            var cos = new Bank(1000);
            cos.wplata(100000);
            Console.WriteLine(cos.getStanKonta());
            cos.wyplata(1000);
            Console.WriteLine(cos.getStanKonta());
        }
    }
}
