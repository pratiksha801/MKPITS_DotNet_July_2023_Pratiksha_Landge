using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine(" static constructor called");
            title = "mkpits";
        }
        public static void display()
        {
            Console.WriteLine("title : " + title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            book.display();
            Console.ReadKey();
        }
    }
}
