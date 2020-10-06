using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Curs6
{
    public partial class Form1 : Form {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;

        public Form1() {
            InitializeComponent();
        }

        private void A1() {
           //Incarcare DataTable Produse
           produseTableAdapter.Fill(dataSet1.Produse);
           //Incarcare DataTable Clienti
           clientiTableAdapter.Fill(dataSet1.Clienti);
           //Setare lblOp
           lblOp.Text = "COMANDA NOUA";
           // Protectie la modificare
           txtNrComanda.ReadOnly = true;
           txtTotal.ReadOnly = true;
           nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
           uMDataGridViewTextBoxColumn.ReadOnly = true;
           pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
           idProdusDataGridViewTextBoxColumn.ReadOnly = true;
           // Initializare cmbClient
           cmbClient.SelectedIndex = -1;
       }

        private void A2() {
            if (!validareCampuriObligatorii()) return;
            generez_nr_cda();
            // Scriu inregistrare in Comenzi si ComenziContinut
            adaugaInregistrareComenzi();
            cautaInregistrare();
            adaugaInregistrariComenziContinut();
            golireCampuri();
        }

        private void A3() {
            // Generare NrCrt
            DataRowView current = (DataRowView)comandaContinutManevraBindingSource.Current;
            current["NrCrt"] = comandaContinutManevraBindingSource.Position + 1; 
        }

        private void A4() {
            try {
                if (dataGridView1.CurrentCell.ColumnIndex == 1) {
                    DataRowView current = (DataRowView)produseBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["PretOferta"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4) {
                    comandaContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e) {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            A1();
        }

        private void comandaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e) {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)  {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void calcTotal() {
            decimal t = 0;
            foreach (DataRow r in dataSet1.ComandaContinutManevra) {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

        private void generez_nr_cda() {
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Comenzi.NrComanda) AS NrMax FROM Comenzi";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrComanda.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii() {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "") {
                MessageBox.Show("Completati Client !");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (comandaContinutManevraBindingSource.Count == 0) {
                MessageBox.Show("Completati continut comanda !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void adaugaInregistrareComenzi() {
           string listaCampuri;
           string listaValori;
           DateTime d = dateTimePicker1.Value;
           listaCampuri = "NrComanda, DataComanda, IdClient";
           listaValori = txtNrComanda.Text + ",#" + Convert.ToString(d.Month) + "/"
                         + Convert.ToString(d.Day) + "/"
                         + Convert.ToString(d.Year) + "#,"
                         + cmbClient.SelectedValue;
           cmd.CommandText = "Insert into Comenzi(" + listaCampuri + ") " +
                             "Select " + listaValori;
           MessageBox.Show(cmd.CommandText);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();
        }

        private void cautaInregistrare() {
            cmd.CommandText = "SELECT idComanda From Comenzi Where NrComanda = " +
            txtNrComanda.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariComenziContinut() {
            string listaCampuri = "IdComanda, NrCrt, IdProdus, Cantitate, PretVanzare";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet1.ComandaContinutManevra)
            {
                listaValori = idCda + "," + r["NrCrt"] + "," + r["IdProdus"] + "," +
                r["Cantitate"] + "," + r["PretVanzare"];
                cmd.CommandText = "Insert into ComenziContinut(" + listaCampuri + ") " +
                "Select " + listaValori;
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void golireCampuri() {
            txtNrComanda.Text = "";
            cmbClient.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.ComandaContinutManevra.Clear();
        }
    }
}
