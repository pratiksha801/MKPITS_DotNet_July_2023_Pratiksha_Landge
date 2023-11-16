using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_single_level_inheritance_another_ex
{
    public class person
    {
        public string name;
        public string address;
    }
    public class employee :person
    {
        public int empno;
        public string name;
        public int salary;
        public string designation;
        public string address;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            employee e1 = new employee();
            e1.empno = 1;
            e1.salary = 50000;
            e1.name = "pratiksha";
            e1.address  = "mumbai"; 
            e1.designation = "clerk";

            Console.WriteLine("empno :" + e1.empno);
            Console.WriteLine("salary :" + e1.salary);
            Console.WriteLine("designation :" + e1.designation);
            Console.WriteLine("name :" + e1.name);
            Console.WriteLine("address :" + e1.address);
        }
    }
}
        
   

