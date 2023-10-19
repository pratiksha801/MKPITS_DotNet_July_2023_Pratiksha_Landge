using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outercounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outercounter;
            int innercounter;
            for (outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (innercounter = 1; innercounter <= 3; innercounter++)
                {
                    Console.Write(outercounter + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
