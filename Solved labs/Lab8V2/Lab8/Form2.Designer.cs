namespace Lab8
{
    partial class Form2
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab8.DataSet1();
            this.localitatiTableAdapter = new Lab8.DataSet1TableAdapters.LocalitatiTableAdapter();
            this.btnSelectie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(32, 13);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 0;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(253, 13);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 1;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(372, 13);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocalitateDataGridViewTextBoxColumn,
            this.dLocalitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.localitatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // idLocalitateDataGridViewTextBoxColumn
            // 
            this.idLocalitateDataGridViewTextBoxColumn.DataPropertyName = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.HeaderText = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.Name = "idLocalitateDataGridViewTextBoxColumn";
            this.idLocalitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dLocalitateDataGridViewTextBoxColumn
            // 
            this.dLocalitateDataGridViewTextBoxColumn.DataPropertyName = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.HeaderText = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.Name = "dLocalitateDataGridViewTextBoxColumn";
            this.dLocalitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitatiBindingSource
            // 
            this.localitatiBindingSource.DataMember = "Localitati";
            this.localitatiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelectie
            // 
            this.btnSelectie.Location = new System.Drawing.Point(142, 13);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(75, 23);
            this.btnSelectie.TabIndex = 4;
            this.btnSelectie.Text = "Selectie";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 311);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelectie;
    }
}