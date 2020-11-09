using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask06
{
    class Account
    {
         String accName;
         String acid;
         int balance;

        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public String Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {
            
        }
        public Account(String accName, String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposite(int amount)
        { balance += amount; }
        public void Withdraw(int amount) { balance -= amount; }
        public void Transfer(int amount, Account receiver)
        {
            if (amount <= balance)
            {
                balance -= amount;
                receiver.balance = amount + balance;
                Console.WriteLine("Balance transfer successful.Amount:" + amount);
            }
            else
            { Console.WriteLine("Not sufficient balance"); }
        }

    }
}
