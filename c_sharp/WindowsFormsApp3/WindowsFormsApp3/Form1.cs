using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char op;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                if (op != null)

                    if (textBox1.Text == "+" || textBox1.Text == "-")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text = "2";
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                if (op != null)
                {

                    if (textBox1.Text == "+" || textBox1.Text == "-")
                    {

                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
                else
                {

                    textBox1.Text = textBox1.Text + "3";

                }
            }
        }
        int pn = 0;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                if (op != null)
                {

                    if (textBox1.Text == "+" || textBox1.Text == "-")
                    {

                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
                else
                {

                    textBox1.Text = textBox1.Text + "4";


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                if (op != null)
                {

                    if (textBox1.Text == "+" || textBox1.Text == "-")
                    {

                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
                else
                {

                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "+";
            op = '+';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "-";
            op = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "x";
            op = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "/";
            op = '/';
        }

        private void button12_Click(object sender, EventArgs e)
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
                case '/':
                    res = pn * Convert.ToInt32(textBox1.Text);
                    break;
                case '*':
                    res = pn / Convert.ToInt32(textBox1.Text);
                    break;


            }
            textBox1.Text = res.ToString();
        }
    }
}

  

        



                