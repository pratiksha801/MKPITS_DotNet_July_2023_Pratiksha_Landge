using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_method
{
    class car
    {
        public void start()
        {
            Console.WriteLine("Car is starting");
        }
    }
    class wagnor : car
    {
        public void startmusic()
        {
            Console.WriteLine("music is starting");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            wagnor r = new wagnor();
            r.start();
            r.startmusic();
            Console.ReadLine();
        }
    }
}
