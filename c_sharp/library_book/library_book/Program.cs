using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Book_class
{
    internal class Program
    {
        class book
        {
            string title;
            string author;
            int publicationYear;

            public void getdata(string title, string author, int publicationyear)
            {
                this.author = author;
                this.title = title;
                this.publicationYear = publicationyear;
            }
            public void displaydata()
            {
                Console.WriteLine("Author :" + author);
                Console.WriteLine("title :" + title);
                Console.WriteLine("publicationyear : " + publicationYear);
            }

        }

        static void Main(string[] args)
        {

            book[] bookied = new book[3];
            bookied[0] = new book();
            bookied[1] = new book();
            bookied[2] = new book();
            string auth = null;
            string tit = null;
            int publication = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Authod");
                auth = Console.ReadLine();

                Console.WriteLine("Enter title");
                tit = Console.ReadLine();

                Console.WriteLine("Enter publicationYear");
                publication = Convert.ToInt32(Console.ReadLine());
                bookied[i].getdata(auth, tit, publication);
            }

            for (int i = 0; i < 3; i++)
            {
                bookied[i].displaydata();

            }
            Console.ReadKey();



        }
    }
}




