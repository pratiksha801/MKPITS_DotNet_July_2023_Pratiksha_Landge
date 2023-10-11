using System;
namespace areaofrect
{
     class areaprogramofrect
    {
        public static void Main()
        {
            int l, b, a;
            Console.WriteLine("Enter Length = ");
            l=Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter Breadth = ");
            b=Convert.ToInt32 (Console.ReadLine());
            a = l * b;
            Console.WriteLine("Area = " + a);
            Console.ReadKey();
        }
    }
}
