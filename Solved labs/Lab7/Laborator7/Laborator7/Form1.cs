using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laborator7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns[0].ReadOnly = true; //IdPersoana read only 
        }
        private void config(bool v)
        {             //pt.vizualizare v = true pt.actualizare v=false 

            dataGridView1.AllowUserToAddRows = !v; 
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.Columns[1].ReadOnly = v;
            dataGridView1.Columns[2].ReadOnly = v;
            dataGridView1.Columns[3].ReadOnly = v;

            dataGridView2.AllowUserToAddRows = !v;
            dataGridView2.AllowUserToDeleteRows = !v;
            dataGridView2.Columns[0].ReadOnly = v;
            dataGridView2.Columns[1].ReadOnly = v;
            dataGridView2.Columns[2].ReadOnly = v;

            btnActualizare.Enabled = v;

            btnSalvare.Visible = !v; btnRenuntare.Visible = !v;
        }

        private void refresh()
        { 
            dataSet1.Persoane.Clear();
            dataSet1.Auto.Clear();
            try 
            { 
                dataSet1.Persoane.ReadXml("Persoane.xml");
                dataSet1.Auto.ReadXml("Auto.xml");
            } 
            catch { } 
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false); 
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            dataSet1.Persoane.WriteXml("Persoane.xml"); 
            dataSet1.Auto.WriteXml("Auto.xml");
            config(true); 
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true); 
            refresh(); 
        }

        /*private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat"); 
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            config(true);
            refresh(); 
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea"; 
            const string titlu = "Stergere inregistrare";
            string cnp = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) 
            { 
                e.Cancel = true;
                return;
            }
            if (existaAuto(cnp)) 
            { 
                //MessageBox.Show("Este proprietar Auto! Nu se poate sterge");
                e.Cancel = true; 
                return; 
            } 
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //MessageBox.Show("Validare camp " + e.ColumnIndex);
            decimal d; 
            string s;

            s = e.FormattedValue.ToString();
            string ids = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            Int32 id = Convert.ToInt32(ids);

            // Validare completare obligatorie        
            if (s == "" && !btnActualizare.Enabled) 
            {          
                //MessageBox.Show("Completati campul " + numeColoana(e.ColumnIndex));   
                e.Cancel = true; 
                return;    
            }

            //Validare de tip numeric
            if (e.ColumnIndex == 2)
                try
                { 
                    d = Convert.ToInt64(s); 
                }
                catch 
                { 
                    //MessageBox.Show("Format eronat");
                    e.Cancel = true; 
                    return;
                }
            //Validare cheie semantica    
            if (e.ColumnIndex == 2 && existaCNP(id, s))
            { 
                //MessageBox.Show("CNP deja existent");
                e.Cancel = true;
                return; 
            } 
        }

        private string numeColoana(int c) 
        { 
            if (c == 1)
                return "Nume";
            else if (c == 2) 
                return "CNP"; 
            else if (c == 3) 
                return "Salariu";
            return ""; 
        }
        private Boolean existaCNP(int id, string cnp)
        { 
            int idCrt; 
            string cnpCrt; 
            foreach (DataRow r in dataSet1.Persoane)
            {
                idCrt = (Int32)(r["IdPersoana"]);
                cnpCrt = r["CNP"].ToString();
            if (cnpCrt == cnp && idCrt != id)
                return true; 
            }
            return false; 
        }

        // Verificare intergitate referentiala la stergere persoana   
        private Boolean existaAuto(string cnp)
        {        
            string cnpCrt;     
            foreach (DataRow r in dataSet1.Auto)      
            {           
                cnpCrt = r["CNPProprietar"].ToString(); 
                if (cnpCrt == cnp) return true;    
            }          
            return false;   
        } 

    }
}
