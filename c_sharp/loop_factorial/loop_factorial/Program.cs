using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace loop_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            // wap to print 1 to 10 using for loop
            for (int pratiksha=num;pratiksha >0;pratiksha--)
            {
                fact = fact * pratiksha;
            }
            Console.WriteLine("fact = " + fact);
            Console.ReadLine();
        }
    }
}
