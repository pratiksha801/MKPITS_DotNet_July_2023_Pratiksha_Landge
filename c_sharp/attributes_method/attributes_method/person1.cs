using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_method
{

    class person1
    {
        public string name;
        public int age;
        public string address;
        public void getdata(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

    }
}
