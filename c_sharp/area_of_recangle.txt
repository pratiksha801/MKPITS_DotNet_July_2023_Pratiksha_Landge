using System;
namespace areaofrectangle
{
    class area
    {
        public static void Main()
        {
            int leangth, breadth, area;
            Console.WriteLine("enter leangth");
            leangth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = leangth * breadth;
            Console.WriteLine("area " + area);
            Console.ReadKey();
        }

   }
}