﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet11.Persoane);
            // TODO: This line of code loads data into the 'dataSet11.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet11.Persoane);
            // TODO: This line of code loads data into the 'dataSet1.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet1.Persoane);

        }
    }
}