namespace Lab8
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocalitati = new System.Windows.Forms.ComboBox();
            this.btnLocalitati = new System.Windows.Forms.Button();
            this.dataSet1 = new Lab8.DataSet1();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiTableAdapter = new Lab8.DataSet1TableAdapters.LocalitatiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(49, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localitati";
            // 
            // cmbLocalitati
            // 
            this.cmbLocalitati.DataSource = this.localitatiBindingSource;
            this.cmbLocalitati.DisplayMember = "DLocalitate";
            this.cmbLocalitati.FormattingEnabled = true;
            this.cmbLocalitati.Location = new System.Drawing.Point(153, 103);
            this.cmbLocalitati.Name = "cmbLocalitati";
            this.cmbLocalitati.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalitati.TabIndex = 1;
            this.cmbLocalitati.ValueMember = "IdLocalitate";
            // 
            // btnLocalitati
            // 
            this.btnLocalitati.Location = new System.Drawing.Point(316, 100);
            this.btnLocalitati.Name = "btnLocalitati";
            this.btnLocalitati.Size = new System.Drawing.Size(75, 23);
            this.btnLocalitati.TabIndex = 2;
            this.btnLocalitati.Text = "OK";
            this.btnLocalitati.UseVisualStyleBackColor = true;
            this.btnLocalitati.Click += new System.EventHandler(this.btnLocalitati_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 274);
            this.Controls.Add(this.btnLocalitati);
            this.Controls.Add(this.cmbLocalitati);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocalitati;
        private System.Windows.Forms.Button btnLocalitati;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
    }
}

