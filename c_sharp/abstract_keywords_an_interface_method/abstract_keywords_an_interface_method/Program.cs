using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_keywords_an_interface_method
{
    interface bank
    {
        String deposit(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public String deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b = new saving();
            String str = b.deposit(1, 200);
            Console.WriteLine(str);
        }
    }
}

