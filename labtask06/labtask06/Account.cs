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
        public int Deposite(int dep)
        {
            balance = balance + dep;
            return balance;
        }
        public int Withdraw(int wd)
        {
            balance = balance - wd;
            return balance;
        }
        public void Transfer(int tk, Account receiver)
        {
            if (tk <= balance)
            {
                balance = balance - tk;
                receiver.balance = tk + balance;
            }
            else
            {
                Console.WriteLine("Not sufficient balance");
            }
        }
        public void ShowBlance()
        {

            Console.WriteLine("Your Account Blance is: " + balance);
        }
        public void ShowAc()
        {
            Console.WriteLine("Your account Info: ");
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Account Balance: " + balance);
        }

    }
}
