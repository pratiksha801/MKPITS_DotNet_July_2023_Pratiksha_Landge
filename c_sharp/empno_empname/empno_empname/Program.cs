using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empno_empname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, basic_salary;
            string empname, designation;
            float total_salary;
            float bonus = 0;
            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("basic_salary");
            basic_salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter designation");
            designation = Convert.ToString(Console.ReadLine());

            if (designation == "manager")
            {
                bonus = basic_salary * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = basic_salary * 0.55f;
            }
            else if (designation == "peun")
            {
                bonus = basic_salary * 0.10f;
            }
            else
            {
                Console.WriteLine("you are not part of company");
            }

            total_salary = basic_salary + bonus;
            Console.WriteLine("emo no:{0}\n emoname:{1} \nbasic salary:{2} \n designation:{3} \n total salary:{4}" + empno + empname + basic_salary + designation + total_salary);
            Console.ReadKey();

        }
    }
}
