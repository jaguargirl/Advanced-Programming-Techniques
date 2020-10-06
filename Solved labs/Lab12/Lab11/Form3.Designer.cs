namespace Lab11
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
            this.idComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPartenerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab11.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idComandaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comenziContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdComanda = new System.Windows.Forms.TextBox();
            this.btnComandaNoua = new System.Windows.Forms.Button();
            this.btnModificareComanda = new System.Windows.Forms.Button();
            this.btnStergereComanda = new System.Windows.Forms.Button();
            this.comenziTableAdapter = new Lab11.DataSet1TableAdapters.ComenziTableAdapter();
            this.comenziContinutTableAdapter = new Lab11.DataSet1TableAdapters.ComenziContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandaDataGridViewTextBoxColumn,
            this.nrComandaDataGridViewTextBoxColumn,
            this.dataComandaDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.dPartenerDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comenziBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idComandaDataGridViewTextBoxColumn
            // 
            this.idComandaDataGridViewTextBoxColumn.DataPropertyName = "IdComanda";
            this.idComandaDataGridViewTextBoxColumn.HeaderText = "IdComanda";
            this.idComandaDataGridViewTextBoxColumn.Name = "idComandaDataGridViewTextBoxColumn";
            // 
            // nrComandaDataGridViewTextBoxColumn
            // 
            this.nrComandaDataGridViewTextBoxColumn.DataPropertyName = "NrComanda";
            this.nrComandaDataGridViewTextBoxColumn.HeaderText = "NrComanda";
            this.nrComandaDataGridViewTextBoxColumn.Name = "nrComandaDataGridViewTextBoxColumn";
            // 
            // dataComandaDataGridViewTextBoxColumn
            // 
            this.dataComandaDataGridViewTextBoxColumn.DataPropertyName = "DataComanda";
            this.dataComandaDataGridViewTextBoxColumn.HeaderText = "DataComanda";
            this.dataComandaDataGridViewTextBoxColumn.Name = "dataComandaDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // dPartenerDataGridViewTextBoxColumn
            // 
            this.dPartenerDataGridViewTextBoxColumn.DataPropertyName = "DPartener";
            this.dPartenerDataGridViewTextBoxColumn.HeaderText = "DPartener";
            this.dPartenerDataGridViewTextBoxColumn.Name = "dPartenerDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // comenziBindingSource
            // 
            this.comenziBindingSource.DataMember = "Comenzi";
            this.comenziBindingSource.DataSource = this.dataSet1;
            this.comenziBindingSource.PositionChanged += new System.EventHandler(this.comenziBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandaDataGridViewTextBoxColumn1,
            this.nrCrtDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.dProdusDataGridViewTextBoxColumn,
            this.umDataGridViewTextBoxColumn,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.comenziContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // idComandaDataGridViewTextBoxColumn1
            // 
            this.idComandaDataGridViewTextBoxColumn1.DataPropertyName = "IdComanda";
            this.idComandaDataGridViewTextBoxColumn1.HeaderText = "IdComanda";
            this.idComandaDataGridViewTextBoxColumn1.Name = "idComandaDataGridViewTextBoxColumn1";
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            // 
            // dProdusDataGridViewTextBoxColumn
            // 
            this.dProdusDataGridViewTextBoxColumn.DataPropertyName = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.HeaderText = "DProdus";
            this.dProdusDataGridViewTextBoxColumn.Name = "dProdusDataGridViewTextBoxColumn";
            // 
            // umDataGridViewTextBoxColumn
            // 
            this.umDataGridViewTextBoxColumn.DataPropertyName = "Um";
            this.umDataGridViewTextBoxColumn.HeaderText = "Um";
            this.umDataGridViewTextBoxColumn.Name = "umDataGridViewTextBoxColumn";
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
            // comenziContinutBindingSource
            // 
            this.comenziContinutBindingSource.DataMember = "ComenziContinut";
            this.comenziContinutBindingSource.DataSource = this.dataSet1;
            // 
            // txtIdComanda
            // 
            this.txtIdComanda.Location = new System.Drawing.Point(547, 12);
            this.txtIdComanda.Name = "txtIdComanda";
            this.txtIdComanda.Size = new System.Drawing.Size(100, 20);
            this.txtIdComanda.TabIndex = 2;
            // 
            // btnComandaNoua
            // 
            this.btnComandaNoua.Location = new System.Drawing.Point(547, 51);
            this.btnComandaNoua.Name = "btnComandaNoua";
            this.btnComandaNoua.Size = new System.Drawing.Size(111, 23);
            this.btnComandaNoua.TabIndex = 3;
            this.btnComandaNoua.Text = "Comanda Noua";
            this.btnComandaNoua.UseVisualStyleBackColor = true;
            this.btnComandaNoua.Click += new System.EventHandler(this.btnComandaNoua_Click);
            // 
            // btnModificareComanda
            // 
            this.btnModificareComanda.Location = new System.Drawing.Point(547, 94);
            this.btnModificareComanda.Name = "btnModificareComanda";
            this.btnModificareComanda.Size = new System.Drawing.Size(111, 23);
            this.btnModificareComanda.TabIndex = 4;
            this.btnModificareComanda.Text = "Modificare Comanda";
            this.btnModificareComanda.UseVisualStyleBackColor = true;
            // 
            // btnStergereComanda
            // 
            this.btnStergereComanda.Location = new System.Drawing.Point(547, 138);
            this.btnStergereComanda.Name = "btnStergereComanda";
            this.btnStergereComanda.Size = new System.Drawing.Size(111, 23);
            this.btnStergereComanda.TabIndex = 5;
            this.btnStergereComanda.Text = "Stergere Comanda";
            this.btnStergereComanda.UseVisualStyleBackColor = true;
            this.btnStergereComanda.Click += new System.EventHandler(this.btnStergereComanda_Click);
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // comenziContinutTableAdapter
            // 
            this.comenziContinutTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 355);
            this.Controls.Add(this.btnStergereComanda);
            this.Controls.Add(this.btnModificareComanda);
            this.Controls.Add(this.btnComandaNoua);
            this.Controls.Add(this.txtIdComanda);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdComanda;
        private System.Windows.Forms.Button btnComandaNoua;
        private System.Windows.Forms.Button btnModificareComanda;
        private System.Windows.Forms.Button btnStergereComanda;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource comenziBindingSource;
        private DataSet1TableAdapters.ComenziTableAdapter comenziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPartenerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comenziContinutBindingSource;
        private DataSet1TableAdapters.ComenziContinutTableAdapter comenziContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
    }
}