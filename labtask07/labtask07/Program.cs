using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask07
{
    class Program
    {
        static void Main(string[] args)
        {
            account acc1 = new Savings();
            account acc2 = new Savings("costa", 12790896, 50000);
            account acc3 = new SpecialSavings("terasa", 87435629, 150000, 10);
            account acc4 = new Fixed("piu", 7489035, 79900);
            account acc5 = new Overdraft(5000);
            SpecialSavings s1 = new SpecialSavings(10);
            Overdraft od = new Overdraft("piucosta", 9087536, 100600, 10000);

        }
    }
}
