using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    internal class Program
    {
        enum grade { a, b, c };
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(grade.b);
            Console.WriteLine("value of b is " + g);
            Console.WriteLine();
        }
    }
}
