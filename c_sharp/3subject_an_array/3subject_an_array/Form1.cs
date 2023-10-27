using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3subject_an_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int[] marks = new int[3];
        int total = 0;
        float per;
        int cnt = 0;

        

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                total = total + marks[i];
            }
            label2.Text = "total marks " + total;
            per = (total / 300.0f) * 100.0f;
            label3.Text = "percentage : " + per;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                marks[cnt] = Convert.ToInt32(textBox1.Text);
                cnt++;
                textBox1.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have entered 3 subject marks now click on result button");

                }
            }


        }

    }
    
}



            
