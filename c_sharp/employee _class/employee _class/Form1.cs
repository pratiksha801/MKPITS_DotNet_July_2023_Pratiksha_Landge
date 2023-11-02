using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee__class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creating array of objects
        Employee[] emp = new Employee[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].employeeid = Convert.ToInt32(textBox1.Text);
                emp[cnt].name = textBox1.Text;
                emp[cnt].salary = Convert.ToDouble(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of  employees accepted");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("employee details are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                sb.Append("----------------------------------------\n");
                sb.Append("employee id : " + emp[i].employeeid + "\n");
                sb.Append("employee name : " + emp[i].name + "\n");
                sb.Append("employee salary : " + emp[i].salary + "\n");
                sb.Append("----------------------------------------\n");
            }

            label4.Text = sb.ToString();
            //code to find highest salary
            double high = emp[0].salary;
            int foundat = 0;
            for (int i = 1; i < 3; i++)
            { 
                    if (high< emp[i].salary)
                    {
                        high = emp[i].salary;
                        foundat++;
                    }
               
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("employee with highest salary : \n");
            sb1.Append("employee number : " + emp[foundat].employeeid + "\n");
            sb1.Append("employee name : " + emp[foundat].name + "\n");
            sb1.Append("employee salary : " + emp[foundat].salary + "\n");
            label5.Text = sb1.ToString();


        }
    }
}


