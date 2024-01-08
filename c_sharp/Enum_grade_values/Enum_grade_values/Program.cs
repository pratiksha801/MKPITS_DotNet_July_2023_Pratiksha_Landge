using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_grade_values
{
    internal class Program
    {
        enum grade {  a=90, b=60, c=40};

        static void Main(string[] args)
        {
            int g = Convert.ToInt32(grade.b);
            Console.WriteLine("value of b is" + g);
            Console.ReadLine();
        }
    }
}
