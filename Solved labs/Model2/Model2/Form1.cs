using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Model2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Consum' table. You can move, or remove it, as needed.
            this.consumTableAdapter.Fill(this.dataSet1.Consum);
            // TODO: This line of code loads data into the 'dataSet1.Lucrari' table. You can move, or remove it, as needed.
            this.lucrariTableAdapter.Fill(this.dataSet1.Lucrari);
            filtreaza();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
        private void filtreaza() 
        { 
            try
            { 
                consumBindingSource.Filter = "IdLucrare=" + listBox1.SelectedValue; 
            } 
            catch { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtreaza();
        }
    }
}
