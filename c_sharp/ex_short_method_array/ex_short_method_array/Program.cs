using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_short_method_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Array.Sort(arr);
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();22
        }
    }
}
