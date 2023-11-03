using Constructor_ass1class_product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_ass1class_product
{
    class product
    {
        int productid;
        string productname;
        int price, quantity;
        //creating a constructor with no parameters

        public product()
        {
            productid = 1;
            productname = "cloth";
            price = 400;
            quantity = 4;
        }
        public void display()
        {
            Console.WriteLine("productid = " + productid);
            Console.WriteLine("productname = " + productname);
            Console.WriteLine("price = " + price);
            Console.WriteLine("quantity = " + quantity);
        }
    }
}
class program
{
    static void Main(string[]args)
    {
        product product= new product();
        product.display();
        Console.ReadKey();
    }
}








