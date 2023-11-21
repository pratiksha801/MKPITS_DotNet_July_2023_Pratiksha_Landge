using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_class_method
{
    class company
    {
        public string name = "mkcl";
        public void display()
        {
            Console.WriteLine("company name :" + name);
        }
    }
    class franchise : company
    {
        public string name = "mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("franchise name : " + name);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            franchise f = new franchise();
            f.display();
            Console.ReadKey();
        }
    }
}

        
        
        
   

        
    

