using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_element_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5];
            int duplicate = 0;
            for (int cnt =0; cnt <3;cnt++)
            {
                Console.WriteLine("element of array1:");
                a1[cnt]=Convert.ToInt32(Console.ReadLine());
            }
            for (int cnt=0;cnt <3;cnt++)
            {
                for (int cnt1=0; cnt1 <3;cnt1++)
                {
                    if (cnt ==2)
                    {
                        break;
                    }
                    if (a1[cnt] == a1[cnt1])
                    {
                        duplicate=duplicate+1;
                    }
                }
                Console.WriteLine("number of duplicate element array="+(duplicate));
                Console.ReadKey();
            }
        }
    }
}
