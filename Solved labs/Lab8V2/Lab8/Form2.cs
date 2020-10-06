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
    public partial class Form2 : Form
    {
        private Form master; 
        private bool selectie; 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.dataSet1.Localitati);
            btnSelectie.Visible = false;
            config(true); 
            refresh(); 
        }
        public void SetMaster(Form caller) 
        {
            master = caller; 
        }
        public void SetSelectVisible()
        { 
            selectie = true;
        } 
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
            if (selectie) btnSelectie.Visible = v; 
        }

        private void refresh() 
        {
            int pozitie; pozitie = localitatiBindingSource.Position; 
            localitatiTableAdapter.Fill(dataSet1.Localitati);
            localitatiBindingSource.Position = pozitie; 
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try { 
                localitatiTableAdapter.Update(dataSet1.Localitati);
                config(true); refresh();
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            } 
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh(); 
        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)master;
            f.refreshLocalitati(localitatiBindingSource.Position);
            this.Close(); 
        } 
    }
}
