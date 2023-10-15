using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace quadrant_root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine(" enter x value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y value");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("the cordinate point (x,y) lies in the first quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("the cordinate point (x,y) lies in the second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("the cordinate point (x,y) lies in the third quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("the cordinate point (x,y) lies in the four quadrant");
            }
                Console.ReadKey();
            }
        }
    }

