using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FPersoane : Form
    {
        public FPersoane()
        {
            InitializeComponent();
        }

        private void FPersoane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Persoane1' table. You can move, or remove it, as needed.
            this.persoane1TableAdapter.Fill(this.dataSet1.Persoane1);

        }
    }
}
