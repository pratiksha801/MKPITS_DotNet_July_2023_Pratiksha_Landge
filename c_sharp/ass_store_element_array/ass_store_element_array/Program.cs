using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_store_element_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i=0;i<num.Length;i++)
            { 
                Console.WriteLine("input 10 number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
                for (int i=0;i<num.Length;i++)
            {
                Console.WriteLine("element - {0}={1}", i, num[i]);
                         
            }
            Console.WriteLine("\t");
            Console.WriteLine("element in array");
                for (int i=0;i<num.Length;i++)
            {
                Console.Write("{0},", num[i]);
            }
            Console.ReadLine();
        }
    }
}
