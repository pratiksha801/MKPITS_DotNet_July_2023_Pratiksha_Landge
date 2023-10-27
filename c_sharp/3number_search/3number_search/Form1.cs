using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3number_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];

        int cnt = 0;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
                if (cnt < 5)
                {
                    num[cnt] = Convert.ToInt32(textBox1.Text);
                    cnt++;
                    textBox1.Clear();
                    textBox1.Focus();
                    if (cnt == 5)
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        MessageBox.Show("you have entered 5 numbers ");

                    }
                }


            }

            private void button2_Click(object sender, EventArgs e)
            {
                int flag = 0;
                int unum = Convert.ToInt32(textBox2.Text);
                int index = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == unum)
                    {
                        flag = 1;
                        index = i + 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    label2.Text = "num found in array at position : " + index;
                }
                else
                {
                    label2.Text = "not found in an array";
                }
            }
        }
    }


        
    

