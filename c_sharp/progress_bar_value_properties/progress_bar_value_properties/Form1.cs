﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progress_bar_value_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

