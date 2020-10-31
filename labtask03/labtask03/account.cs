using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class account
    {
        String accname;
        String acid;
        int balance;
        
        public string getAccName ()
            {
            return accname;
            }
        public void setAccName(String AccName)
        {
            accname = AccName;
        }
        

        
      
           public string getAcId ()
            {
            return acid;
            }
            public void setAcId ( String AcId )
            {
            acid = AcId;

            }
            public int getBalance ()
            {
                return balance;
            }
            public void setBlance ( int Balance )
            {
            balance = Balance;

            }

        public void showinfo() 
        {

            Console.WriteLine("Account Name is :  " + accname);
            Console.WriteLine("Account Id is :  " + acid);
            Console.WriteLine("Account balance :  " + balance);
        }

        public void Deposit (int amount )
        {
            balance = balance + amount;
            Console.WriteLine("TOTAL BALANCE :" + balance);
        }
        public void withdraw ( int amount )
        {
            balance = balance - amount;
            Console.WriteLine("TOTAL BALANCE :" + balance);
        }
    }
}
