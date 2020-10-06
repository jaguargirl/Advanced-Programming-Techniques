using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Exam
{
    public partial class Form2 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Materii' table. You can move, or remove it, as needed.
            this.materiiTableAdapter.Fill(this.dataSet1.Materii);
            // TODO: This line of code loads data into the 'dataSet1.Elevi' table. You can move, or remove it, as needed.
            this.eleviTableAdapter.Fill(this.dataSet1.Elevi);
            cmbMaterie.SelectedValue = -1;

        }

        private void txtNota_Leave(object sender, EventArgs e)
        {
            decimal p;
            if (txtNota.Text == "") { }
            else
            {
                try
                {
                    p = Convert.ToDecimal(txtNota.Text);
                    if (p < 1 || p > 10)
                    {
                        MessageBox.Show("Introduceti o valoare intre 1 si 10 pentru nota");
                        txtNota.Text = "";
                        txtNota.Focus();
                    }
                }
                catch {
                    MessageBox.Show("Atentie! Nota trebuie sa fie o valoare numerica");
                    txtNota.Text = "";
                    txtNota.Focus();
                }
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (validareCampuri())
            {
                //con.ConnectionString = eleviTableAdapter.Connection.ConnectionString;
                con.ConnectionString = con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\\Univ\\Info 3\\Tehnici avansate de programare\\Teme\\Examen.accdb;";
                cmd.Connection = con;
                con.Open();
                string listaCampuri; 
                string listaValori;
                DateTime d = dateTimePicker1.Value;
                listaCampuri = "IdElev, Data, IdMaterie, Nota";
                listaValori = txtIdElev.Text + ",#" + Convert.ToString(d.Day) + "-" + Convert.ToString(d.Month) + "-" + Convert.ToString(d.Year) + "#," + cmbMaterie.SelectedValue + "," + txtNota.Text;
                cmd.CommandText = "INSERT INTO Note(" + listaCampuri + ") " + "SELECT " + listaValori;
                MessageBox.Show(cmd.CommandText);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch { }
                con.Close();
                golireCampuri();
            }
 
               
        }
        private bool validareCampuri()
        {
            //Validare de completare obligatorie campul Client     
            if (cmbMaterie.Text == "")
            {
                MessageBox.Show("Selectati Materia!");
                cmbMaterie.Focus();
                return false;
            }
            if (txtNota.Text == "")
            {
                MessageBox.Show("Introduceti Nota");
                txtNota.Focus();
                return false;
            }
            if (txtIdElev.Text == "")
            {
                MessageBox.Show("Introduceti Id Elev");
                txtIdElev.Focus();
                return false;
            }
            return true;
        }
        private void golireCampuri()
        { txtNota.Text = ""; 
            cmbMaterie.SelectedIndex = -1;
            txtIdElev.Text = "";
        } 
    }
}
