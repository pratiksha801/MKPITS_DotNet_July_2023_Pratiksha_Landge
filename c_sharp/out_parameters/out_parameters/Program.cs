using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_parameters
{
    internal class Program
    {
        static void calculate(int radius, out float area, out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area, circ;
            calculate(radius, out area, out circ);
            Console.WriteLine("area = " + area);
            Console.WriteLine("circ = " + circ);
            Console.ReadKey();
        }
    }
}


