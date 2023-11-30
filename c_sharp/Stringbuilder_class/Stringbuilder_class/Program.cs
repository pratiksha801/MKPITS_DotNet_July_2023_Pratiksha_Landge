using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("pratu");
            sb.Append("payal");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("bye");
        }
    }
}
