using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab3A2
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
            // TODO: This line of code loads data into the 'dataSet1.Membri' table. You can move, or remove it, as needed.
            this.membriTableAdapter.Fill(this.dataSet1.Membri);
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\\Univ\\Info 3\\Tehnici avansate de programare\\OSB.accdb;" + "Jet OLEDB:Database Password=mypsw";      
            cmd.Connection = con;    
            cmd.CommandText = "Select Nume from Membri";  
            con.Open();      
            rdr = cmd.ExecuteReader();     
            while (rdr.Read())        
                listBox1.Items.Add(rdr.GetString(0));        
            con.Close(); 

        }
    }
}
