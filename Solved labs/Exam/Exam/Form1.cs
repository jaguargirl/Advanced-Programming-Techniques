using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Note' table. You can move, or remove it, as needed.
            this.noteTableAdapter.Fill(this.dataSet1.Note);
            // TODO: This line of code loads data into the 'dataSet1.Elevi' table. You can move, or remove it, as needed.
            this.eleviTableAdapter.Fill(this.dataSet1.Elevi);
            filtreaza();

        }
        private void filtreaza() 
        {
            try 
            { 
                noteBindingSource.Filter = "IdElev=" + txtId.Text;
            }
            catch { } 
        }

        private void btnPuneNota_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            refresh_grid();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            filtreaza();
        }
        private void refresh_grid() 
        {
            eleviTableAdapter.Fill(dataSet1.Elevi);
            noteTableAdapter.Fill(dataSet1.Note);
        } 
    }
}
