using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask06
{
    class Library
    {
         String libName;

        public String LibName
        {​​​​
            get {​​​​ return libName; }​​​​
            set {​​​​ libName = value; }​​​​
        }​​​​
 
         String libAddress;

        public String LibAddress
        {​​​​
            get {​​​​ return libAddress; }​​​​
            set {​​​​ libAddress = value; }​​​​
        }​​​​
        Book[] listofbook;
        int bookcount = 0;

         int totalBook;

        public int TotalBook
        {​​​​
            get {​​​​ return totalBook; }​​​​
            set {​​​​ totalBook = value; }​​​​
        }​​​​
         public Library()
        {

        }
        public Library(string libName, string libAddress,  int totalBook)
        {
            this.libName= libName;
           
            this.libAddress= libAddress;
            this.totalBook= totalBook;
            

        }
        public void ShowInfo()
        {​​​​
            Console.WriteLine("Library Name :" + libName);
            Console.WriteLine("Library Address:" + libAddress);
            Console.WriteLine("Total Book:" + totalBook);

        }​​​​
        public void ShowAllBooks()
        {​​​​
            for (int i = 0; i < bookcount; i++)
            {​​​​
                Console.WriteLine(i);
            }​​​​
        }​​​​
 
    }​​​​
    }
}
