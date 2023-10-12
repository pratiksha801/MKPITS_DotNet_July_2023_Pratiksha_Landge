using System;
namespace ConsoleApp1
{
    class class1
    {
        enum grade { dist = 90, first = 60, second = 40 }
        public static void Main()
        {
            //Write a program to accept character from the user 
            grade gr;
            gr = grade.dist;
            Console.WriteLine("grade = " + gr);
            Console.WriteLine("grade value = " + Convert.ToInt32(gr));
        }
    }
}
