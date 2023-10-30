using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
                int sum = 0;
            Console.WriteLine("enter number");
            for (int i = 0; i < 3; i++)
                num[i] = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("element : {0}+{1}", 1, num[1]) ;
            }
            for (int i=0;i<3;i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("\n sum of all element stored in the array is : " + sum);
            Console.ReadKey();
        
        


                                  
               
            }
        }
    }

