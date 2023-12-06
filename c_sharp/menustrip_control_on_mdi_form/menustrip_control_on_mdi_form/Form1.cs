using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip_control_on_mdi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void registrationformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationform r = new registrationform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountformToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
