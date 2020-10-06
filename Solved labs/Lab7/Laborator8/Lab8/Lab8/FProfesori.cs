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
    public partial class FProfesori : Form
    {
        private Form master;
        private bool selectie; 
        public FProfesori()
        {
            InitializeComponent();
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
            if (selectie)
                btnSelectie.Visible = v; 
        }

        private void refresh()
        {
            int pozitie;
            pozitie = profesoriBindingSource.Position; 
            profesoriTableAdapter.Fill(dataSet1.Profesori);
            profesoriBindingSource.Position = pozitie; 

        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false); 
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try { profesoriTableAdapter.Update(dataSet1.Profesori);
                config(true); 
                refresh(); 
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
        private void FProfesori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Profesori' table. You can move, or remove it, as needed.
            this.profesoriTableAdapter.Fill(this.dataSet1.Profesori);
            btnSelectie.Visible = false; 
            config(true);
            refresh();
        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            FFacultati f = (FFacultati)master; 
            f.refreshProfesori(profesoriBindingSource.Position);
            this.Close(); 
        }
 
    }
}
