using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolstrip_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();    
            r .MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a .MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
