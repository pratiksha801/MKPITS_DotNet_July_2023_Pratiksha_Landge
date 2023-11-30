using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_invalidcastexception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("pratu");
            sb.Append("payal");
            Console.WriteLine("sb = " + sb.ToString());
            object obj = sb;
            Console.WriteLine("obj = " + obj.ToString());
            Console.WriteLine("bye");
        }
    }
}
