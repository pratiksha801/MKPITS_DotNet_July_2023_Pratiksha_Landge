using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumof5no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for (int counter=10; counter>=5; counter--)
            {
                Console.WriteLine("enter number");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum" + sum);
            Console.ReadKey();
        }
    }
}
