using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch(NullReferenceException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}
