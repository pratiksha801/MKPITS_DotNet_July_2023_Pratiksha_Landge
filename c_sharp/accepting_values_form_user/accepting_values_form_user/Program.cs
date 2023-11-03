using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        //creating a  parameterized constructor with 4 parameters
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("constructor with  parameters called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
            Console.WriteLine("price : " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string t1 = Console.ReadLine();
            Console.WriteLine("enter author");
            string a1 = Console.ReadLine();
            Console.WriteLine("enter price");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Book b2 = new Book(b1, t1, a1, p1); //this will call parameterized constructor
            b2.display();
            Console.ReadKey();
        }
    }
}
