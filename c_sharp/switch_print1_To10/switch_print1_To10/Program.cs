using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace switch_print1_To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to print numbers from 1 to 10 using while loop
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;

            }


            Console.ReadKey();
        }
    }
}

