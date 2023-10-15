using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bio, chem, phy;
            float total;
            Console.WriteLine("enter maths marks");
            bio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chem mark");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter phy");
            phy = Convert.ToInt32(Console.ReadLine());
            total = bio + chem + phy;
            Console.WriteLine("total marks" + total);
            if (total >= 230)
            {
                Console.WriteLine("candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine(" candidate is not eligible for admission");
            }
            Console.ReadLine();
        }
    }
}
