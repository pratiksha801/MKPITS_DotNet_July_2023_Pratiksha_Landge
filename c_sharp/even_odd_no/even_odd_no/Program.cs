using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) 

            {
                Console.WriteLine("the number is even");
            }
            else
            { 
                Console.WriteLine("the numbers is odd");
            }
            Console.ReadKey();
        }
                
    }
}
