using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3 };
            int[] arr1 = new int[3];
            Array.Copy(arr, arr1, 3);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}

            

