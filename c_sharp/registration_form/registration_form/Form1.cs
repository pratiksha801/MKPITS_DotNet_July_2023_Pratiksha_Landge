using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("username" + textBox1.Text + "\n");
            sb.Append("password" + textBox1.Text + "\n");
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked) 
            {
                gender = radioButton2.Text;
            }
            sb.Append("gender :" + gender + "\n");
            if (checkBox1.Checked)
            {
                sb.Append("course joined :" + checkBox1.Text + "\n");
            }
            if (checkBox2.Checked)
            {
                sb.Append("course joined :" + checkBox2.Text + "\n");
            }
            sb.Append("city :" + comboBox1.Text + "\n");
            label6.Text = sb.ToString();

        }
    }
}
