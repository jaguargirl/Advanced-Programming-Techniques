namespace Lab8
{
    partial class FProfesori
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
            this.dataSet1 = new Lab8.DataSet1();
            this.profesoriTableAdapter = new Lab8.DataSet1TableAdapters.ProfesoriTableAdapter();
            this.idProfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSelectie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfDataGridViewTextBoxColumn,
            this.numeProfDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(375, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesoriTableAdapter
            // 
            this.profesoriTableAdapter.ClearBeforeFill = true;
            // 
            // idProfDataGridViewTextBoxColumn
            // 
            this.idProfDataGridViewTextBoxColumn.DataPropertyName = "idProf";
            this.idProfDataGridViewTextBoxColumn.HeaderText = "idProf";
            this.idProfDataGridViewTextBoxColumn.Name = "idProfDataGridViewTextBoxColumn";
            this.idProfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeProfDataGridViewTextBoxColumn
            // 
            this.numeProfDataGridViewTextBoxColumn.DataPropertyName = "numeProf";
            this.numeProfDataGridViewTextBoxColumn.HeaderText = "numeProf";
            this.numeProfDataGridViewTextBoxColumn.Name = "numeProfDataGridViewTextBoxColumn";
            this.numeProfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesoriBindingSource
            // 
            this.profesoriBindingSource.DataMember = "Profesori";
            this.profesoriBindingSource.DataSource = this.dataSet1;
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(22, 47);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(219, 47);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(322, 47);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSelectie
            // 
            this.btnSelectie.Location = new System.Drawing.Point(117, 47);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(75, 23);
            this.btnSelectie.TabIndex = 4;
            this.btnSelectie.Text = "Selectie";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // FProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 342);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FProfesori";
            this.Text = "FProfesori";
            this.Load += new System.EventHandler(this.FProfesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource profesoriBindingSource;
        private DataSet1TableAdapters.ProfesoriTableAdapter profesoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSelectie;
    }
}