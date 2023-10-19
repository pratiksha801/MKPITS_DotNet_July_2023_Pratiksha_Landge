using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<num;i++)
            {
              if(fact==0)
                {
                    fact = 1;
                    break;
                }
            }
                if (num%2==0)
                {
                    Console.WriteLine("it is prime num");
                }
            else
                {
                    Console.WriteLine("not prime num");
                }
            Console.ReadKey();
        }
    }
}
