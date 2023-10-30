using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.WriteLine("enter number");
            for (int i = 0; i < 3; i++)
            {
               
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            Console.WriteLine("/n the value store into the array in reverse are:");
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine("{0}", num[i]);
                
            }
            Console.ReadKey();


        }
    }
}
        

    

