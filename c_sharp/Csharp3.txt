using System;
namespace multiplicationofthreenumbers
{
    class mulofthreenum
    {
        public static void Main()
        {
            int num1, num2, num3, res;
            Console.WriteLine("Enter 1st Number = ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number = ");
            num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number = ");
            num3 =Convert.ToInt32(Console.ReadLine());
            res=num1*num2*num3;
            Console.WriteLine("Result = " + res);
            Console.ReadKey();

        }
    }
}
