using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public abstract class account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amount);
        public string withdrawl(int amount)
        {
            string res = null;
            if (balance > amount)
            {
                res = "insuffient fund.cannot withdrawl money!";
            }
            else
            {
                balance = balance - amount;
                res = "amount withdrawl successfully , balance is " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balnce amount is : " + balance.ToString();
        }
    }
    public class saving : account
    {
        public override string deposit(int amount)
        {
            int interest = 300;
            balance = balance + amount + interest;
            return "amount deposited successfully,balance is : " + balance.ToString();
        }
    }
    public class current : account
    {
        public override string deposit(int amount)
        {
            balance = balance + amount;
            return "amount deposited successfully,balance is : " + balance.ToString();
        }
    }
}
