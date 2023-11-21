using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_base_class_constructor
{
    class company
    {
        public string name = "mkcl";
        public company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name :" + name);
        }
    }
    class franchise : company
    {
        public string name = "mkpit";
        public franchise()
        {
            Console.WriteLine("derived class constructor");
            Console.WriteLine("franchise name " + name);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            franchise f = new franchise();
            Console.ReadKey();
        }
    }
}
            
        
        
    
        
        

