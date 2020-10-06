using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.dataSet1.Localitati);
            refreshLocalitati(-1);
        }
        private void refreshLocalitati(int pozitie)
        { 
            localitatiTableAdapter.Fill(dataSet1.Localitati);
            cmbLocalitati.SelectedIndex = pozitie; 
        }

        private void btnLocalitati_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); 
            f.ShowDialog(); 
            refreshLocalitati(-1);
        }
    }
}
