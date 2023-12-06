using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrange_cascade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account a = new account();
            a.MdiParent = this;
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="admin"&&textBox2.Text =="admin")
            {
                MessageBox.Show("login sucessful");
                panel1.Visible = false;
                label3.Visible =false;
                menuStrip1.Enabled = true;
            }
            else
            {
                MessageBox.Show("invalid credentials,please try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
