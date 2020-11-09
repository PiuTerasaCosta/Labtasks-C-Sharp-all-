using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask06
{
    class Book
    {
         String bookName;
         String bookAuthor;
         String bookId;
        String bookType;
         int bookCopy;

        public String BookName
        {
            get { return bookName; }
            set { BookName = value; }
        }
        public String BookAuthor
        {
            get { return bookAuthor; }
            set { BookAuthor = value; }
        }
        public String BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public String BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Author: " + bookAuthor);
            Console.WriteLine("ID: " + bookId);
            Console.WriteLine("Type: " + bookType);
            Console.WriteLine("Copy: " + bookCopy);
        }
        public void AddBookCopy(int x)
        {
            bookCopy += x;
        }
    }
}
