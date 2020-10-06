using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        private Button[] lb = new Button[3];
        public Form2()
        {
            InitializeComponent();
            lb[0] = btnActualizare;
            lb[1] = btnSalvare; 
            lb[2] = btnRenuntare; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Model1.Config(true, dataGridView1, lb);
            refresh(); 
        }
        private void refresh()
        {
            persoaneTableAdapter.Fill(dataSet1.Persoane);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            Model1.Config(false, dataGridView1, lb);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                persoaneTableAdapter.Update(dataSet1.Persoane);
                Model1.Config(true, dataGridView1, lb);
                refresh(); 
            }
            catch (Exception exc) 
            {
                Model1.trateazaEroare(exc); 
            } 
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            Model1.Config(true, dataGridView1, lb); 
            refresh(); 
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!Model1.confirmare()) e.Cancel = true; 
        } 
    }
}
