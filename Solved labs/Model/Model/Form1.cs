using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Model
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Ingrediente' table. You can move, or remove it, as needed.
            this.ingredienteTableAdapter.Fill(this.dataSet1.Ingrediente);

        }
         private void A3() 
         {            
             // Generare NrCrt   
             DataRowView current = (DataRowView)modelBindingSource.Current;        
             current["NrCrt"] = modelBindingSource.Position + 1;   
         }

         private void modelBindingSource_CurrentChanged(object sender, EventArgs e)
         {
             A3();
         }
         private void A4()
         {
             string cant;
             decimal p;
             try
             {
                 if (dataGridView1.CurrentCell.ColumnIndex == 1)
                 {
                     DataRowView current = (DataRowView)ingredienteBindingSource.Current;

                     dataGridView1.CurrentRow.Cells[2].Value = current["UM"]; 
                     dataGridView1.CurrentRow.Cells[3].Value = current["PretAchizitie"];
                     dataGridView1.CurrentRow.Cells[6].Value = current["IdIngredient"]; 
                     calcTotal();
                 } 
                 if (dataGridView1.CurrentCell.ColumnIndex == 4) 
                 {
                     cant = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
                     if (cant == "") 
                         return;
                     try 
                     { 
                         p = Convert.ToDecimal(cant); 
                     }
                     catch 
                     {
                         MessageBox.Show("Format eronat"); 
                         //cant.Focus();
                     }
                     modelBindingSource.EndEdit();
                     calcTotal(); 
                 }
                 
             }
             catch { }
         }
        private void calcTotal() // Calcul total valori  
        {       
            decimal t = 0;          
            foreach (DataRow r in dataSet1.Model)         
            {           
                if (r["Cost"] != DBNull.Value  )      
                    t += (decimal)r["Cost"];    
            }           
            txtTotal.Text = Convert.ToString(t);    
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private bool validareCampuriObligatorii()
        {
            //string ingredient = Convert.ToString((dataGridView1.CurrentRow.Cells["DIngredient"] as DataGridViewComboBoxCell).FormattedValue.ToString());
            string cant;
            if (txtDenumire.Text == "") 
            {
                MessageBox.Show("Completati Denumirea Retetei !"); 
                txtDenumire.Focus();
                return false;
            }
            if (modelBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut reteta !");
                dataGridView1.Focus();
                return false; 
            }
            /*if (ingredient == "")
            {
                MessageBox.Show("Alegeti ingredientul !");
                return false; 
            }*/
            cant = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            if (cant == "")
            { 
                MessageBox.Show("Completati cantitatea !");
                return false;
            }
                
            return true;
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            if (validareCampuriObligatorii())
            {
                adaugaReteta();
            }

        }
        private void adaugaReteta()
        {
            con.ConnectionString = ingredienteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con; 
             string listaCampuri;
             string listaValori;
             listaCampuri = "DReteta, Nrc, IdIngredient, Cantitate";
                con.Open();
                 foreach (DataRow r in dataSet1.Model)
                 {
                     listaValori = txtDenumire.Text + "," + r["NrCrt"] + "," + r["IdIngredient"] + "," + r["Cantitate"];
                     cmd.CommandText = "Insert into Retete(" + listaCampuri + ") " + "Select " + listaValori;
                     MessageBox.Show(cmd.CommandText);
                     cmd.ExecuteNonQuery();
                 } 
            con.Close();
             }
        }

    }
