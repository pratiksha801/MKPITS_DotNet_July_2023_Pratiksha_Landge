using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3};
            Array.Clear(arr,0, 3);
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
