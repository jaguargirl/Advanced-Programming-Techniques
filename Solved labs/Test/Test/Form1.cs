using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
         private OleDbConnection con = new OleDbConnection();     
        private OleDbCommand cmd = new OleDbCommand();           
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Lucrari' table. You can move, or remove it, as needed.
            this.lucrariTableAdapter.Fill(this.dataSet1.Lucrari);
            // TODO: This line of code loads data into the 'dataSet1.Materiale' table. You can move, or remove it, as needed.
            this.materialeTableAdapter.Fill(this.dataSet1.Materiale);

        }
        private void A3() {     
            // Generare NrCrt          
            DataRowView current = (DataRowView)model2BindingSource.Current;          
            current["NrCrt"] = model2BindingSource.Position + 1;   
        }

        private void model2BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
            calcTotal();
        }
        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)materialeBindingSource.Current;

                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdMaterial"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    materialeBindingSource.EndEdit();
                    calcTotal(); 
                }
            }
            catch { }
        }

        private void calcTotal() // Calcul total valori 
        {
            decimal t = 0;   
            foreach (DataRow r in dataSet1.Model2)  
            {        
                if (r["Cost"] != DBNull.Value  ) 
                    t += (decimal)r["Cost"];       
            }                   

           txtTotal.Text = Convert.ToString(t);     
        }
        private void adaugaInregistrareComenzi()
        {
            con.ConnectionString = materialeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "IdLucrare, Data, Nrc, IdMaterial, Cantitate";
            con.Open();
            foreach (DataRow r in dataSet1.Model2)
            {
                listaValori = cmbLucrare.SelectedValue + ",#" + Convert.ToString(d.Day) + "-" + Convert.ToString(d.Month) + "-" + Convert.ToString(d.Year) + "#," + r["NrCrt"] + "," + r["IdMaterial"] + "," + r["Cantitate"];
                cmd.CommandText = "Insert into Consum(" + listaCampuri + ") " + "Select " + listaValori;
                MessageBox.Show(cmd.CommandText); 
                cmd.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            adaugaInregistrareComenzi();
            golireCampuri();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }
        private void golireCampuri()
        { 
            cmbLucrare.SelectedIndex=-1; 
            txtTotal.Text = "";
            dataSet1.Model2.Clear();
        } 
          private void A5(DataGridViewRowCancelEventArgs e) { 
            const string mesaj = "Confirmati stergerea";     
          const string titlu = "Stergere inregistrare";   
          var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,MessageBoxIcon.Warning);  
          if (rezultat == DialogResult.No) 
          e.Cancel = true;  
         } 
         private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
         {         
         A5(e);
         calcTotal();
         }
         
         private boolean validareCampObligatorii()
         {
         if (comandaContinutManevraBindingSource.Count == 0)   
         {          
         MessageBox.Show("Completati continut comanda !");   
         dataGridView1.Focus();           
         return false;     
         }           
         return true; 
         }
    }*/
    }
}
