using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int sum = 0;
            //displaying array using foreach loop
            foreach (int val in arr)
            {
                Console.WriteLine(val);
                sum = sum + val;
            }
            Console.WriteLine("sum of array elements are " + sum);
            Console.ReadKey();
        }
    }
}


