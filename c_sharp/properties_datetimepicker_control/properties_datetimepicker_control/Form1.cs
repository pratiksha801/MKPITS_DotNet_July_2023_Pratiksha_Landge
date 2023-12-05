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

namespace properties_datetimepicker_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(dateTimePicker1.Text);
            label1.Text = dateTimePicker1.Text;
            label2.Text = dateTimePicker1.Value.ToLongDateString();
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Value.Date.Year.ToString();
        }
    }
}
 