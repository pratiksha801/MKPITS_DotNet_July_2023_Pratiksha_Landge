using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_blueprint_class
{
    interface shape
    {
        void draw();
    }
    class rectangle : shape
    {
        public void draw()

        {
            Console.WriteLine("draw method of rectangle class");

        }
    }
    class circle : shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of circle class");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
        }
    }
}
    
       
  
