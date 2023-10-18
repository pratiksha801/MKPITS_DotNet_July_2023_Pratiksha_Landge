using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("enter character");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("character is consonent");
                    break;
            }
            Console.ReadLine();
        }
    }
}
