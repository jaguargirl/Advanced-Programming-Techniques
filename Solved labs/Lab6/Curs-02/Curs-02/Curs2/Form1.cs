using System;
using System.Windows.Forms;
using System.Data;

namespace Curs2
{
    public partial class Form1 : Form
    {
        const int DLocalitateIndex = 6;   
        const int IdLocalitateIndex = 4;
        const int IdPersoanaIndex = 0;    
        const int NumeIndex = 1;   
        const int CNPIndex = 2;    
        const int SalariuIndex = 3;   
        const int SpImagineIndex = 5; 
        public Form1()
        {
            InitializeComponent();
        }
        
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;
            dataGridView1.Columns[NumeIndex].ReadOnly = v;    
            dataGridView1.Columns[CNPIndex].ReadOnly = v;    
            dataGridView1.Columns[SalariuIndex].ReadOnly = v;     
            dataGridView1.Columns[SpImagineIndex].ReadOnly = v;    
            dataGridView1.Columns[DLocalitateIndex].ReadOnly = v; 
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void refresh()
        {
            persoaneTableAdapter.Fill(dataSet1.Persoane);
            localitatiTableAdapter.Fill(dataSet1.Localitati);
            completeazaLocalitate();
        }
        private void completeazaLocalitate() 
        {
            String idLoc;
            int idLocalitate;
            DataRow r;
            foreach (DataRowView x in persoaneBindingSource) 
            { 
                idLoc = x["IdLocalitate"].ToString();
                idLocalitate = Convert.ToInt32(idLoc);
                r = dataSet1.Tables["Localitati"].Rows.Find(idLocalitate);
                if (r != null) 
                { 
                    x["DLocalitate"] = r[1].ToString();
                } 
                else 
                { 
                    MessageBox.Show("Nu exista localitate cu id " + idLocalitate); 
                } 
            }
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.dataSet1.Localitati);
            // TODO: This line of code loads data into the 'dataSet11.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet1.Persoane);
            //A1
            config(true);
            refresh();
            dataGridView1.Columns[IdPersoanaIndex].ReadOnly = true;
            dataGridView1.Columns[IdLocalitateIndex].ReadOnly = true; 
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
            dataGridView1.Columns[IdPersoanaIndex].ReadOnly = true;
            dataGridView1.Columns[IdLocalitateIndex].ReadOnly = true; 
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            //A4
            try
            {
                persoaneTableAdapter.Update(dataSet1.Persoane);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;
                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
            if (btnRenuntare.Focused) {     
                dataGridView1.CancelEdit();     
                //A3            
                config(true);    
                refresh();          
                return;      
            } 
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
             DataRowView crt; 
            try
            { 
                 if (dataGridView1.CurrentCell.ColumnIndex == DLocalitateIndex){          
                     crt = (DataRowView)localitatiBindingSource.Current;      
                     dataGridView1.CurrentRow.Cells[IdLocalitateIndex].Value = crt["IdLocalitate"];     
                 }         
            }       
            catch{}  
        }
        private bool completareCampuri() 
        {           
            bool raspuns = true;  
            foreach (DataRow r in dataSet1.Persoane)
            { 
                if (r.RowState == DataRowState.Deleted)
                    continue;
                if (r["Nume"] == DBNull.Value) 
                { 
                    MessageBox.Show("Completati Nume la linia cu Id " + r["IdPersoana"]); 
                    raspuns = false;
                } 
                if (r["CNP"] == DBNull.Value)
                { MessageBox.Show("Completati CNP la linia cu Id " + r["IdPersoana"]);
                    raspuns = false; 
                } 
            } return raspuns;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

            if (dataGridView1.CurrentCell.ColumnIndex == SpImagineIndex)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                { 
                    string s = openFileDialog1.FileName; 
                    dataGridView1.CurrentRow.Cells[SpImagineIndex].Value = s;
                    pictureBox1.ImageLocation = s; 
                }
        }
     }
 }
