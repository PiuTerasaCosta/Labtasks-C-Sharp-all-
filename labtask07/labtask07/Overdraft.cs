using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask07
{
    class Overdraft:account
    {
        double overdraftLimit;

        public Overdraft(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public Overdraft(string name, int? accNo, double balance, double overdraftLimit) : base(name, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("withdraw is not possible as the amount reached to least balance");
            }
        }

    }
}
