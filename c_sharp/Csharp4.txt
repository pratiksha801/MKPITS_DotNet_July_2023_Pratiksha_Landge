using System;
namespace SquareProgram
{
    class Squareofnum
    {
        public static void Main()
        {
            int num, square;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square="+square);
            Console.ReadKey();
        }
    }
}