using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask06
{
    class Library
    {
        Book b;
        String libName;
        String libAddress;
        String[] listOfBook;
        int totalBook;
        public Library()
        { }
        public Library(String ln, String la, String[] lb, int tb)
        {
            libName = ln;
            libAddress = la;
            listOfBook = lb;
            totalBook = tb;
        }

        void ShowLibInfo() 
        {
            Console.WriteLine("Library name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Library List of Book: " + listOfBook);
            Console.WriteLine("Total Book: " + totalBook);
        }
        void ShowAllBooks() 
        {
            Console.WriteLine("All Books are: ");
            b.ShowInfo();
        }
        public void Showallinfo()
        {
            ShowAllBooks();
            ShowLibInfo();
        }
        void AddNewBook(Book book)
        {
            listOfBook[totalBook + 1] += book;
            totalBook++;
        }
        void DeleteBook(Book book) 
        {
            totalBook--;
        }
        void AddNewBookCopy(Book book, int copy)
        {
            listOfBook[totalBook + 1] += book;
            totalBook++;
        }
    }​​​​
 }

