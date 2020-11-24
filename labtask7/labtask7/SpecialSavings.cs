using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask7
{
    class SpecialSavings:account
    {
        public SpecialSavings(int maximumTransaction)
        {
            this.maximumTransaction = maximumTransaction;
        }
        public SpecialSavings(string name, int? accNo, double balance, int maximumTransactions) : base(name, accNo, balance)
        {
            this.maximumTransaction = maximumTransaction;
        }
        public override void Withdraw(double amount)
        {
            if (TransactionNum <= maximumTransaction && Balance - amount >= amount * 20 / 100)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }

    }
}
