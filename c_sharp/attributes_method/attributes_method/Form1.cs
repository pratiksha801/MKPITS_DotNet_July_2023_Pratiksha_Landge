using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attributes_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            person1 p = new person1();
            p.name = textBox1.Text;

            p.age = Convert.ToInt32(textBox1.Text);
            p.address = textBox3.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("person name: " + p.name + "\n");
            sb.Append("person age: " + p.age + "\n");
            sb.Append ("person address:" + p.address + "\n");
            p.getdata(p.name,p.age,p.address);
            label4.Text = sb.ToString();
        }
    }
}
