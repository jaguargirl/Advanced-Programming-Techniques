﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laborator4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void t1_Click(object sender, EventArgs e)
        {
            Form1 t1 = new Form1();
            t1.ShowDialog();
        }

        private void t2_Click(object sender, EventArgs e)
        {
            Form3 t2 = new Form3();
            t2.ShowDialog();
        }
    }
}