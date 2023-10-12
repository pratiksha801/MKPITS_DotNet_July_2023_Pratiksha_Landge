using System;
namespace characcept
{
    class A
    {
        public static void Main()
        {
            char ch;
            Console.WriteLine("enter character");
            ch = Convert.ToChar(Console.Read());
            Console.WriteLine("ch = " + ch);
            Console.ReadKey();

        }
    }
}