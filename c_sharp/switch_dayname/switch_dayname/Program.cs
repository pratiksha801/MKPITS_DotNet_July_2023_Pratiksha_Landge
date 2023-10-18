using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_dayname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.WriteLine("enter dayno between 1 and 7");
            dayno = Convert.ToInt32(Console.ReadLine());
            switch (dayno)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                
                    default:
                        Console.WriteLine("some other day");
                    break;
            }
            Console.ReadLine();
        }
    }
}
