using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shortcut_properties
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
            p.Name = textBox1.Text; // it will call set method 
            p.Age = Convert.ToInt32(textBox2.Text);
            p.Address = textBox3.Text;


            StringBuilder sb = new StringBuilder();
            sb.Append("name : " + p.Name + "\n"); // it will call get method
            sb.Append("age : " + p.Age + "\n");
            sb.Append("address : " + p.Address + "\n");
            label4.Text = sb.ToString();

        }
    }
}

        
    

