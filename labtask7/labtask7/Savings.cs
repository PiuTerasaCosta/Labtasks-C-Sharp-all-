using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask7
{
    class Savings:account 
    {
        

        public Savings(string name, int? accNo, double balance) : base(name, accNo, balance)
        {
            maximumTransaction = 100;
        }
        public Savings()
        {
            maximumTransaction = 30;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500 && TransactionNum <= maximumTransaction)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("withdraw is not possible for insufficient balance");
            }
        }

    }
}
