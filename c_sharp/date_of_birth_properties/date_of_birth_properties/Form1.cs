using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_of_birth_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("dob" + age);
           // string yr = age.Substring(5);
           int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("dob yr " +  yr);   
            int cry = DateTime.Now.Year;
            MessageBox.Show("current yr " + cry);
            int diff = cry - Convert.ToInt32(yr);
            MessageBox.Show("your age is " + diff);

        }
    }
}
