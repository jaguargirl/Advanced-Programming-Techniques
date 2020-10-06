using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ComenziContinut' table. You can move, or remove it, as needed.
            this.comenziContinutTableAdapter.Fill(this.dataSet1.ComenziContinut);
            // TODO: This line of code loads data into the 'dataSet1.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this.dataSet1.Comenzi);
            refreshGrid();
            comenziContinutBindingSource.Filter = "IdComanda=" + txtIdComanda.Text; 

        }
        private void refreshGrid() 
        {
            comenziTableAdapter.Fill(dataSet1.Comenzi);
            comenziContinutTableAdapter.Fill(dataSet1.ComenziContinut);
        }

        private void comenziBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                comenziContinutBindingSource.Filter = "IdComanda=" + txtIdComanda.Text;

            }
            catch { }
        }

        private void btnComandaNoua_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            refreshGrid(); 
        }

        private void btnStergereComanda_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea"; 
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) 
                return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = comenziTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda       
            cmd.CommandText = "Delete From ComenziContinut Where IdComanda = " + txtIdComanda.Text; 

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda      
            cmd.CommandText = "Delete From Comenzi Where IdComanda = " + txtIdComanda.Text;  
            MessageBox.Show(cmd.CommandText);      
            cmd.ExecuteNonQuery(); 

            con.Close();

            // Refresh grid-uri        
            refreshGrid();
        }

    }
}
