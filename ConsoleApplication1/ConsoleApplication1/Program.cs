using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Money
    {
        private double Money1;
        private double Money2;
        private double Money3;

        public double getAdd()
        {
            return Money1 + Money2 + Money3;
        }

        public void setMoney1(double M1)
        {
            Money1 = M1;
        }

        public void setMoney2(double M2)
        {
            Money2 = M2;
        }

        public void setMoney3(double M3)
        {
            Money3 = M3;
        }

        public static Money operator +(Money Money2, Money Money3)
        {
            Money money = new Money();
            money.Money1 = Money2.Money1 + Money3.Money1;
            money.Money2 = Money2.Money2 + Money3.Money2;
            money.Money3 = Money2.Money3 + Money3.Money3;
            return money;
        }
    }

        class MoneyClass
    {
        static void Main(string[] args)
        {
            Money m1 = new Money();
            Money m2 = new Money();
            Money m3 = new Money();
            double Add = 0.0;

            m1.setMoney1(2.0);
            m1.setMoney2(4.0);
            m1.setMoney3(5.0);

            m2.setMoney1(3.0);
            m2.setMoney2(6.0);
            m2.setMoney3(8.0);

            Add = m1.getAdd();
            Console.WriteLine("Addition of m1 : {0}" , Add);
            Add = m2.getAdd();
            Console.WriteLine("Addition of m2 : {0}" , Add);

            m3 = m1 + m2;

            Add = m3.getAdd();
            Console.WriteLine("Addition of m3 : {0}", Add);
            Console.ReadKey();
        }
    }
}