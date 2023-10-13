using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("is a leap year");
            }
            else
            {
                Console.WriteLine("is not leap year");
                Console.ReadKey();
            }
        }
    }
}


