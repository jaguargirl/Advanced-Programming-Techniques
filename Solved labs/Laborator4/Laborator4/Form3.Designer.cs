namespace Laborator4
{
    partial class Form3
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
            this.idLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Laborator4.DataSet1();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdLocalitate = new System.Windows.Forms.TextBox();
            this.persoaneTableAdapter = new Laborator4.DataSet1TableAdapters.PersoaneTableAdapter();
            this.localitatiTableAdapter = new Laborator4.DataSet1TableAdapters.LocalitatiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocalitateDataGridViewTextBoxColumn,
            this.idPersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persoaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(188, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // idLocalitateDataGridViewTextBoxColumn
            // 
            this.idLocalitateDataGridViewTextBoxColumn.DataPropertyName = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.HeaderText = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.Name = "idLocalitateDataGridViewTextBoxColumn";
            this.idLocalitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPersoanaDataGridViewTextBoxColumn
            // 
            this.idPersoanaDataGridViewTextBoxColumn.DataPropertyName = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.HeaderText = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.Name = "idPersoanaDataGridViewTextBoxColumn";
            this.idPersoanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            this.salariuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.localitatiBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 238);
            this.listBox1.TabIndex = 1;
            // 
            // localitatiBindingSource
            // 
            this.localitatiBindingSource.DataMember = "Localitati";
            this.localitatiBindingSource.DataSource = this.dataSet1;
            // 
            // txtIdLocalitate
            // 
            this.txtIdLocalitate.DataBindings.Add(new System.Windows.Forms.Binding("Location", this.dataSet1, "Localitati.IdLocalitate", true));
            this.txtIdLocalitate.Location = new System.Drawing.Point(12, 38);
            this.txtIdLocalitate.Name = "txtIdLocalitate";
            this.txtIdLocalitate.Size = new System.Drawing.Size(151, 20);
            this.txtIdLocalitate.TabIndex = 2;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 345);
            this.Controls.Add(this.txtIdLocalitate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIdLocalitate;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private DataSet1TableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
    }
}