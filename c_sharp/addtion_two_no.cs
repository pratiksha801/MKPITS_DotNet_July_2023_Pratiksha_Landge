using System;

namespace sumoftwonu
{
    class program
    {
        public static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("result:" + add);
            Console.ReadKey();
        }
    }
}

       
