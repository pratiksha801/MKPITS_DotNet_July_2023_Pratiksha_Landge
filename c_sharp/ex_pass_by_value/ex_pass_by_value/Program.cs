using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_pass_by_value
{
    internal class Program
    {
        static void display(int num)
        {
            num = 20;//local veriable
            Console.WriteLine("num inside method" + num);//20
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after passing inside main" + num);//10
            Console.ReadLine();
        }
    }
}
