using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "pratiksha");
            ht.Add("002", "payal");
            ht.Add("003", "arohi");
            ht.Add("004", "amit");
            ht.Add("005", "shivanya");
            ht.Add("006", "sharu");
            ht.Add("007", "neharika");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "pratiksha");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}









