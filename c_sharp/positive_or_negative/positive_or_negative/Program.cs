using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) 
            {
                Console.WriteLine("the num is positie");
            }
            else
            {
                Console.WriteLine("the num is negative");
            }
            Console.ReadLine();
        }
    }
}
