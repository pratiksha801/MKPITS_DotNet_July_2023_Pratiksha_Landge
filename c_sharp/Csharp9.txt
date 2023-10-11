using System;
namespace division 
{
    class programofdivision
    {
        public static void Main()
        {
            int num1, num2, div;
            Console.WriteLine("Enter number 1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 = ");
            num2=Convert.ToInt32(Console.ReadLine());
            div = num1 / num2;
            Console.WriteLine("Division = " + div);
            Console.ReadKey();

        }
    }
}
