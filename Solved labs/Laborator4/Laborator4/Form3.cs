using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laborator4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.dataSet1.Localitati);
            // TODO: This line of code loads data into the 'dataSet1.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet1.Persoane);

        }
        private void filtreazaLocalitati() { try { 
            persoaneBindingSource.Filter = "IdLocalitate=" + txtIdLocalitate.Text; } catch { } 
        }

    }
}
