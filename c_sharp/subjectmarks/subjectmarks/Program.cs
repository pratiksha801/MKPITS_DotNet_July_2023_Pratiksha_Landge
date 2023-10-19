using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace subjectmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int marks = 0;
            int total = 0;
            int i = 0;
            int per = 0;
            {
                for (i = 1; i <= 3; i++)
                {
                    Console.WriteLine("enter four subject marks ");
                    marks = Convert.ToInt32(Console.ReadLine());
                    total = total + marks;
                }
                Console.WriteLine("total = " + total);
                per = total / 400;
                Console.WriteLine("percentage" + per);
                if (per >= 75)
                {
                    Console.WriteLine("grade = A");
                }
                else if (per >= 50 && per <= 75)
                {
                    Console.WriteLine("Grade = B");
                }
                else if (per >= 35 && per <= 50)
                {
                    Console.WriteLine("Grade = c");
                }
                else if (per >= 25 && per <= 40)
                {
                    Console.ReadKey();
                }
            }

        }

    }
}

    