using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_another_ex_method_deposite
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual String deposit(int actno, int amount)
        {
            return "deposite method of account class";
        }
        public String showbalance()
        {
            return "balance amount : " + balance;
        }
    }
    class Current : Account
    {
        //overriding the base class deposite method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "ammount deposit successfully in current class";
        }
    }
    public class TestBase
    {
        public static void Main()
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current
            Account act = new Current();
            String res = act.deposit(123, 2000);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);


        }
    }
}
        
        
    