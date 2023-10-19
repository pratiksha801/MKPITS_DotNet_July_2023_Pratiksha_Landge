using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_tableno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int table = 0;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++) 
            {
                table = num * 1;
                Console.WriteLine("{0}*{1}={2},", num, i, table);
            }
            Console.ReadKey();
            }
        }
    }

