using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand(); 
        private OleDbDataReader rdr; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A1(true);
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v; 
            lblAutor.Visible = !v;
            lblParola.Visible = v; 
            txtParola.Visible = v;
            lblUtilizator.Visible = v; 
            txtUtilizator.Visible = v;
            if (v)
                btnStart.Text = "Log In"; 
            else
                btnStart.Text = "Log Out"; 
        }
         private Boolean Logare_OK()   
         {        
             if (txtUtilizator.Text == "")    
             {      
                 MessageBox.Show("Completati utilizator !");  
                 txtUtilizator.Focus();          
                 return false;       
             }         
             if (txtParola.Text == "")             
             {            
                 MessageBox.Show("Completati parola !");    
                 txtParola.Focus();            
                 return false;       
             } 
             con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\\Univ\\Info 3\\Tehnici avansate de programare\\BD-02.accdb";           
             cmd.Connection = con;       
             cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " + "where Nume='" + txtUtilizator.Text + "'";    
             con.Open();     
             rdr = cmd.ExecuteReader();           
             if (rdr.Read()) 
             {        
                 if (txtParola.Text != rdr.GetString(1))
                 {    
                     MessageBox.Show("Parola eronata");    
                     txtParola.Focus();             
                     con.Close();        
                     return false;       
                 }         
                 con.Close();
                return true;     
            }            
             else
             {
                 MessageBox.Show("Utilizator eronat"); 
                 txtUtilizator.Focus();
                 con.Close(); 
                 return false;
             }
         }

         private void btnStart_Click(object sender, EventArgs e)
         {
             if (btnStart.Text == "Log In") 
             {
                 if (Logare_OK()) A1(false);
             }
             else A1(true); 
         }

         private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
         {
             FPersoane f = new FPersoane(); 
             f.ShowDialog(); 
         }

         private void localitatiToolStripMenuItem_Click(object sender, EventArgs e)
         {
             FLocalitati f = new FLocalitati();
             f.ShowDialog(); 
         }
 
    }
}
