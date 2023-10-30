using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2method_returning_array
{
    internal class Program
    {
        //method returning array
        static void acceptarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array elements are :" + sum);
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            acceptarray(num);

            int[] num1 = { 11, 22, 33 };
            acceptarray(num1);

            Console.ReadKey();
        }
    }
}


