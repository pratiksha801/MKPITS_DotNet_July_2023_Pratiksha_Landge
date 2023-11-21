using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base_keywords
{
    class Animal
    {
        public string color = "white";
    }
    class Dog : Animal
    {
        public string color = "red";
        public void displaycolor()
        
        {
            Console.WriteLine("dog color :" + color);//red
            Console.WriteLine("Animal color :" + base.color);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.displaycolor();
            Console.ReadKey();
        }
    }
}



          











        