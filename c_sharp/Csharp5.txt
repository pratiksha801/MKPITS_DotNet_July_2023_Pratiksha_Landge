using System;

namespace Sumoftwonum
{
    class Sumoftwonums
    {
        public static void Main()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter first num");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second num");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum " + sum);
            Console.WriteLine();

        }
    }
}
