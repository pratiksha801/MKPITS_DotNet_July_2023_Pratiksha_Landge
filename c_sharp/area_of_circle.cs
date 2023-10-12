using System;
namespace areaofcircle
{
    class programofcircle
    {
        public static void Main()
        {
            int radius;
            float area, circle;
            Console.WriteLine("enter radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circle = 2 * 3.14f * radius;
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference =" + circle);
            Console.ReadKey();
        }         

    }
}