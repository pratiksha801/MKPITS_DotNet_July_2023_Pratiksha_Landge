using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";

        }
        int pn = 0;
        char op;

        private void button4_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "+";
            op = '+';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "-";
            op = '-';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int res = 0;
            switch (op)
            {
                case '+':
                    res = pn + Convert.ToInt32(textBox1.Text);
                    break;
                case '-':
                    res = pn - Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = res.ToString();
        }
    }
}




                