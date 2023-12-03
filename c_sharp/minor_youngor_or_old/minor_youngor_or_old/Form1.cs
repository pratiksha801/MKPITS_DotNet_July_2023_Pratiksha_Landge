using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minor_youngor_or_old
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int age = Convert.ToInt32(textBox1.Text);

            if (age<18)
            {
                label2.Text = "Minor";
            }
            else if (age>18 && age<60)
            {
                label2.Text = "Young";
            }
            else
            {
                label2.Text = "old";
            }
        }
    }
}
                    
                    

            
        


           