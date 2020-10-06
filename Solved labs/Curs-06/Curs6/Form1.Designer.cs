namespace Curs6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Curs6.DataSet1();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spPozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClient = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataComanda = new System.Windows.Forms.Label();
            this.txtNrComanda = new System.Windows.Forms.TextBox();
            this.lblNrComanda = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.clientiTableAdapter = new Curs6.DataSet1TableAdapters.ClientiTableAdapter();
            this.produseTableAdapter = new Curs6.DataSet1TableAdapters.ProduseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(577, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCrtDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.spPozaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comandaContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 176);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.DataSource = this.produseBindingSource;
            this.dProdusDataGridViewTextBoxColumn.DisplayMember = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            this.dProdusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dProdusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            // 
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            // 
            // spPozaDataGridViewTextBoxColumn
            // 
            this.spPozaDataGridViewTextBoxColumn.DataPropertyName = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.HeaderText = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.Name = "spPozaDataGridViewTextBoxColumn";
            // 
            // comandaContinutManevraBindingSource
            // 
            this.comandaContinutManevraBindingSource.DataMember = "ComandaContinutManevra";
            this.comandaContinutManevraBindingSource.DataSource = this.dataSet1;
            this.comandaContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.comandaContinutManevraBindingSource_CurrentChanged);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(278, 26);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 36;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.clientiBindingSource;
            this.cmbClient.DisplayMember = "DPartener";
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(105, 92);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 35;
            this.cmbClient.ValueMember = "IdPartener";
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.dataSet1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(18, 92);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 34;
            this.lblClient.Text = "Client";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // lblDataComanda
            // 
            this.lblDataComanda.AutoSize = true;
            this.lblDataComanda.Location = new System.Drawing.Point(18, 63);
            this.lblDataComanda.Name = "lblDataComanda";
            this.lblDataComanda.Size = new System.Drawing.Size(30, 13);
            this.lblDataComanda.TabIndex = 32;
            this.lblDataComanda.Text = "Data";
            // 
            // txtNrComanda
            // 
            this.txtNrComanda.Location = new System.Drawing.Point(105, 26);
            this.txtNrComanda.Name = "txtNrComanda";
            this.txtNrComanda.Size = new System.Drawing.Size(100, 20);
            this.txtNrComanda.TabIndex = 31;
            // 
            // lblNrComanda
            // 
            this.lblNrComanda.AutoSize = true;
            this.lblNrComanda.Location = new System.Drawing.Point(18, 34);
            this.lblNrComanda.Name = "lblNrComanda";
            this.lblNrComanda.Size = new System.Drawing.Size(66, 13);
            this.lblNrComanda.TabIndex = 30;
            this.lblNrComanda.Text = "Nr Comanda";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(385, 29);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(157, 20);
            this.lblOp.TabIndex = 29;
            this.lblOp.Text = "COMANDA  NOUA";
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 333);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataComanda);
            this.Controls.Add(this.txtNrComanda);
            this.Controls.Add(this.lblNrComanda);
            this.Controls.Add(this.lblOp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataComanda;
        private System.Windows.Forms.TextBox txtNrComanda;
        private System.Windows.Forms.Label lblNrComanda;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.BindingSource comandaContinutManevraBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DataSet1TableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spPozaDataGridViewTextBoxColumn;
    }
}

