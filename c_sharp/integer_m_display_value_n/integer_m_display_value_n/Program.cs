using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_m_display_value_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("enter no:");
            m = Convert.ToInt32(Console.ReadLine());
            if (m >= 0)
            {
                Console.WriteLine("value of n = 1");
            }
            else
            {
                Console.WriteLine("value of n = -1");
            }
            Console.ReadLine();
        }
    }
}
