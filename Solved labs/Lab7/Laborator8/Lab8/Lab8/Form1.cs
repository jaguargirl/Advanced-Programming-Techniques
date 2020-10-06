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
    public partial class FFacultati : Form
    {
        public FFacultati()
        {
            InitializeComponent();
        }
        public void refreshProfesori(int pozitie)
        { 
            profesoriTableAdapter.Fill(dataSet1.Profesori);
            cmbProfesori.SelectedIndex = pozitie; 
        } 
        private void FFacultati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Profesori' table. You can move, or remove it, as needed.
            this.profesoriTableAdapter.Fill(this.dataSet1.Profesori);
            refreshProfesori(-1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProfesori f = new FProfesori();
            f.SetMaster(this); 
            f.SetSelectVisible(); 
            f.ShowDialog(); 
            f.ShowDialog(); 
            refreshProfesori(-1);
        }
    }
}
