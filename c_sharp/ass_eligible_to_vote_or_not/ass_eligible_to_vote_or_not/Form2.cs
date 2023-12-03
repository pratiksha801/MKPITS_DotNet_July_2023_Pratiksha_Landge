using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass_eligible_to_vote_or_not
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);

            StringBuilder sb = new StringBuilder();


            if (age >= 18)
            {
                sb.Append("eligible for vote");

            }
            else

            {
                sb.Append("not eligible for vote");


            }

            label2.Text = sb.ToString();
        }
    }
}
