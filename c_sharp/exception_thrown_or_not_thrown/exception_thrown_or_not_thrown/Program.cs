using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_thrown_or_not_thrown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("enter number1");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n; //error will come here and program terminates
            }
            catch (Exception ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine(" cannot divide bt zero");
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("res = " + res);
                Console.WriteLine("bye");


            }
        }
    }
}
