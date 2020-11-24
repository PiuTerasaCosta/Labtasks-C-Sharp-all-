using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask7
{
    class Program
    {
        static void Main(string[] args)
        {
            account account1 = new Savings();
            Console.WriteLine();
            account account2 = new Savings("piu", 6784965, 140000);
            Console.WriteLine();
            account account3 = new SpecialSavings("terasa", 799366544, 255000, 25);
            Console.WriteLine();
            account account4 = new Fixed("costa", 437755844, 56000);
            Console.WriteLine();
            account account5 = new Overdraft(6000);
            Console.WriteLine();
            SpecialSavings s1 = new SpecialSavings(30);
            Console.WriteLine();
            Overdraft o1 = new Overdraft("piucosta", 597357234, 150000, 10000);

        }
    }
}
