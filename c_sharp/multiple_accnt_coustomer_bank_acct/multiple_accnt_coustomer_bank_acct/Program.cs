using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_accnt_coustomer_bank_acct
{
    class Bank
    {

        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            accounts.Remove(account);
        }

        public void DisplayAccounts(Customer customer)
        {
            Console.WriteLine("Accounts for :" + customer.Name);
            foreach (var account in accounts)
            {
                if (account.Customer == customer)
                {
                    Console.WriteLine("Account number: {0}, Balance: {1}", account.Number, account.Balance);
                }
            }
        }
    }

    class Account
    {
        public int Number { get; set; }
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Account(int number, decimal balance, Customer customer)
        {
            Number = number;
            Balance = balance;
            Customer = customer;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char exit;
            Bank bank = new Bank();
            Console.WriteLine("Enter Customer Name : ");
            Customer customer = new Customer(name: Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter Account Number : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    Account account = new Account(number1, 5000, customer);
                    bank.AddAccount(account);
                    Console.WriteLine("press D for deposit and W for withdrawl : ");
                    char choice = Console.ReadLine()[0];
                    if (choice == 'D')
                    {
                        Console.WriteLine("Enter amount :");
                        account.Deposit(Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (choice == 'W')
                    {
                        account.Withdraw(Convert.ToInt32(Console.ReadLine()));
                    }
                    Console.WriteLine("Do u want to exit program press y or n");
                    exit = Console.ReadLine()[0];
                    if (exit == 'y')
                    {
                        break;
                    }
                }
                Console.WriteLine("Do u want to add another account press y or n");
                exit = Console.ReadLine()[0];
                if (exit == 'n')
                {
                    break;
                }

            }
            bank.DisplayAccounts(customer);
            Console.ReadKey();
        }
    }
}

