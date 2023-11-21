using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_method_abstract_keywords_ex2
{
    interface bank
    {
        string deposit(int actno, int amount);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        int interest = 500;
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "actno  : " + actno + " bal is : " + bal;
        }
    }

    class current : bank
    {
        int actno;
        int bal = 1000;

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno  : " + actno + " bal is : " + bal;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            switch (acttype)
            {
                case "saving":
                    b = new current();
                    break;
                case "current":
                    b = new current();
                    break;
            }
            string res = b.deposit(1, 700);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}



        
       