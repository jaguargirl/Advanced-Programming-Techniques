namespace Lab2
{
    partial class FLocalitati
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
            this.dataSet1 = new Lab2.DataSet1();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiTableAdapter = new Lab2.DataSet1TableAdapters.LocalitatiTableAdapter();
            this.dLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dLocalitateDataGridViewTextBoxColumn,
            this.idLocalitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.localitatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dLocalitateDataGridViewTextBoxColumn
            // 
            this.dLocalitateDataGridViewTextBoxColumn.DataPropertyName = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.HeaderText = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.Name = "dLocalitateDataGridViewTextBoxColumn";
            this.dLocalitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLocalitateDataGridViewTextBoxColumn
            // 
            this.idLocalitateDataGridViewTextBoxColumn.DataPropertyName = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.HeaderText = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.Name = "idLocalitateDataGridViewTextBoxColumn";
            this.idLocalitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FLocalitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 246);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FLocalitati";
            this.Text = "FLocalitati";
            this.Load += new System.EventHandler(this.FLocalitati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalitateDataGridViewTextBoxColumn;
    }
}