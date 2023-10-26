using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_character_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[3];
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter charecter");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i=0;i<3;i++)
            {
                Console.Write("{0}",ch[i]);
            }
            Console.ReadKey();

        }
    }
}
