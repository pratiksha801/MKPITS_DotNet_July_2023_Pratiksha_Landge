using System;
namespace areaofcircle
{
    class programofareaofcircle
    {
        public static void Main()
        {
            int r;
            float a, ci;
            Console.WriteLine("Enter radius of circle");
            r = Convert.ToInt32(Console.ReadLine());
            a = 3.14f * r * r;
            ci = 2 * 3.14f * r;
            Console.WriteLine("Area = " + a);
            Console.WriteLine("Circumference = " + ci);
            Console.ReadKey();

        }
    }
}
