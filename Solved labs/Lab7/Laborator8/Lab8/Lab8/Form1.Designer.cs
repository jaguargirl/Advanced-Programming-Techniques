namespace Lab8
{
    partial class FFacultati
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
            this.cmbProfesori = new System.Windows.Forms.ComboBox();
            this.profesoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab8.DataSet1();
            this.profesoriTableAdapter = new Lab8.DataSet1TableAdapters.ProfesoriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesori";
            // 
            // cmbProfesori
            // 
            this.cmbProfesori.DataSource = this.profesoriBindingSource;
            this.cmbProfesori.DisplayMember = "numeProf";
            this.cmbProfesori.FormattingEnabled = true;
            this.cmbProfesori.Location = new System.Drawing.Point(149, 110);
            this.cmbProfesori.Name = "cmbProfesori";
            this.cmbProfesori.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesori.TabIndex = 1;
            this.cmbProfesori.ValueMember = "idProf";
            // 
            // profesoriBindingSource
            // 
            this.profesoriBindingSource.DataMember = "Profesori";
            this.profesoriBindingSource.DataSource = this.dataSet1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vizualizeaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FFacultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbProfesori);
            this.Controls.Add(this.label1);
            this.Name = "FFacultati";
            this.Text = "FFacultati";
            this.Load += new System.EventHandler(this.FFacultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProfesori;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource profesoriBindingSource;
        private DataSet1TableAdapters.ProfesoriTableAdapter profesoriTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

