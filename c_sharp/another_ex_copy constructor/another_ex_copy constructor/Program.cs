using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class book
    {
        int bookid;
        string title;
        //creating constructor
        public book()
        {
            bookid = 123;
            title = "vb.net";
        }
        //creating a copy constructor
        public book(book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
        }
        //method to display the data
        public void display()
        {
            Console.WriteLine("book id " + bookid);
            Console.WriteLine("book title " + title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book book2 = new book(book1);
            Console.WriteLine("book1 details are :");
            book1.display();
            Console.WriteLine("book2 details are :");
            book2.display();


            Console.ReadKey();
        }
    }
}

