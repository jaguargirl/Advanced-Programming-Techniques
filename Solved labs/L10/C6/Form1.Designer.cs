namespace C6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtIdPersoana = new System.Windows.Forms.TextBox();
            this.lblIdPersoana = new System.Windows.Forms.Label();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.cmbLocalitate = new System.Windows.Forms.ComboBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.PictureBox();
            this.lblSpImagine = new System.Windows.Forms.Label();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.dataSet1 = new C6.DataSet1();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoaneTableAdapter = new C6.DataSet1TableAdapters.PersoaneTableAdapter();
            this.idPersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiTableAdapter = new C6.DataSet1TableAdapters.LocalitatiTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn,
            this.idLocalitateDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.dLocalitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persoaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 169);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(103, 14);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(66, 23);
            this.btnModificare.TabIndex = 68;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(283, 13);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 69;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(32, 13);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(65, 23);
            this.btnAdaugare.TabIndex = 66;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtCNP);
            this.Panel1.Controls.Add(this.txtIdPersoana);
            this.Panel1.Controls.Add(this.lblIdPersoana);
            this.Panel1.Controls.Add(this.txtSpImagine);
            this.Panel1.Controls.Add(this.cmbLocalitate);
            this.Panel1.Controls.Add(this.txtSalariu);
            this.Panel1.Controls.Add(this.txtNume);
            this.Panel1.Controls.Add(this.PB);
            this.Panel1.Controls.Add(this.lblSpImagine);
            this.Panel1.Controls.Add(this.lblLocalitate);
            this.Panel1.Controls.Add(this.lblSalariu);
            this.Panel1.Controls.Add(this.lblCNP);
            this.Panel1.Controls.Add(this.lblNume);
            this.Panel1.Location = new System.Drawing.Point(341, 56);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(358, 169);
            this.Panel1.TabIndex = 65;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(88, 43);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(94, 20);
            this.txtCNP.TabIndex = 15;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtIdPersoana
            // 
            this.txtIdPersoana.Location = new System.Drawing.Point(88, 146);
            this.txtIdPersoana.Name = "txtIdPersoana";
            this.txtIdPersoana.Size = new System.Drawing.Size(81, 20);
            this.txtIdPersoana.TabIndex = 12;
            // 
            // lblIdPersoana
            // 
            this.lblIdPersoana.AutoSize = true;
            this.lblIdPersoana.Location = new System.Drawing.Point(20, 146);
            this.lblIdPersoana.Name = "lblIdPersoana";
            this.lblIdPersoana.Size = new System.Drawing.Size(18, 13);
            this.lblIdPersoana.TabIndex = 11;
            this.lblIdPersoana.Text = "ID";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(88, 123);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(81, 20);
            this.txtSpImagine.TabIndex = 10;
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // cmbLocalitate
            // 
            this.cmbLocalitate.DataSource = this.localitatiBindingSource;
            this.cmbLocalitate.DisplayMember = "DLocalitate";
            this.cmbLocalitate.FormattingEnabled = true;
            this.cmbLocalitate.Location = new System.Drawing.Point(88, 97);
            this.cmbLocalitate.Name = "cmbLocalitate";
            this.cmbLocalitate.Size = new System.Drawing.Size(81, 21);
            this.cmbLocalitate.TabIndex = 9;
            this.cmbLocalitate.ValueMember = "IdLocalitate";
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(88, 69);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(81, 20);
            this.txtSalariu.TabIndex = 8;
            this.txtSalariu.Leave += new System.EventHandler(this.txtSalariu_Leave);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(88, 15);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(251, 20);
            this.txtNume.TabIndex = 6;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(201, 41);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(145, 123);
            this.PB.TabIndex = 5;
            this.PB.TabStop = false;
            // 
            // lblSpImagine
            // 
            this.lblSpImagine.AutoSize = true;
            this.lblSpImagine.Location = new System.Drawing.Point(20, 123);
            this.lblSpImagine.Name = "lblSpImagine";
            this.lblSpImagine.Size = new System.Drawing.Size(31, 13);
            this.lblSpImagine.TabIndex = 4;
            this.lblSpImagine.Text = "Poza";
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Location = new System.Drawing.Point(20, 97);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(53, 13);
            this.lblLocalitate.TabIndex = 3;
            this.lblLocalitate.Text = "Localitate";
            // 
            // lblSalariu
            // 
            this.lblSalariu.AutoSize = true;
            this.lblSalariu.Location = new System.Drawing.Point(20, 71);
            this.lblSalariu.Name = "lblSalariu";
            this.lblSalariu.Size = new System.Drawing.Size(39, 13);
            this.lblSalariu.TabIndex = 2;
            this.lblSalariu.Text = "Salariu";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(20, 43);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 1;
            this.lblCNP.Text = "CNP";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(20, 15);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(365, 14);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 70;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(175, 14);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(57, 23);
            this.btnStergere.TabIndex = 67;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(472, 18);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 20);
            this.lblOp.TabIndex = 71;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.dataSet1;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // idPersoanaDataGridViewTextBoxColumn
            // 
            this.idPersoanaDataGridViewTextBoxColumn.DataPropertyName = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.HeaderText = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.Name = "idPersoanaDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            // 
            // idLocalitateDataGridViewTextBoxColumn
            // 
            this.idLocalitateDataGridViewTextBoxColumn.DataPropertyName = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.HeaderText = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.Name = "idLocalitateDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            // 
            // dLocalitateDataGridViewTextBoxColumn
            // 
            this.dLocalitateDataGridViewTextBoxColumn.DataPropertyName = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.HeaderText = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.Name = "dLocalitateDataGridViewTextBoxColumn";
            // 
            // localitatiBindingSource
            // 
            this.localitatiBindingSource.DataMember = "Localitati";
            this.localitatiBindingSource.DataSource = this.dataSet1;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.lblOp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnModificare;
        internal System.Windows.Forms.Button btnConfirmare;
        internal System.Windows.Forms.Button btnAdaugare;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtCNP;
        internal System.Windows.Forms.TextBox txtIdPersoana;
        internal System.Windows.Forms.Label lblIdPersoana;
        internal System.Windows.Forms.TextBox txtSpImagine;
        internal System.Windows.Forms.ComboBox cmbLocalitate;
        internal System.Windows.Forms.TextBox txtSalariu;
        internal System.Windows.Forms.TextBox txtNume;
        internal System.Windows.Forms.PictureBox PB;
        internal System.Windows.Forms.Label lblSpImagine;
        internal System.Windows.Forms.Label lblLocalitate;
        internal System.Windows.Forms.Label lblSalariu;
        internal System.Windows.Forms.Label lblCNP;
        internal System.Windows.Forms.Label lblNume;
        internal System.Windows.Forms.Button btnRenuntare;
        internal System.Windows.Forms.Button btnStergere;
        internal System.Windows.Forms.Label lblOp;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private DataSet1TableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

