using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_minumum_maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;


            Console.WriteLine("enter 5 integer:");
            for (int i=0;i< arr.Length; i++)
            {
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                    
                
            }
            Console.WriteLine("maximum element: " + max);
            Console.WriteLine("minimum element: " + min);
            Console.ReadKey();

        }
    }
}
