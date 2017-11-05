namespace AñosFelices
{
    partial class frmConsultarRecAlim
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.cmbDato = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Grilla1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(555, 512);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 34);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(555, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 34);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(317, 73);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(108, 20);
            this.txtDato.TabIndex = 17;
            // 
            // cmbDato
            // 
            this.cmbDato.FormattingEnabled = true;
            this.cmbDato.Items.AddRange(new object[] {
            "",
            "DNI Paciente",
            "Habitacion"});
            this.cmbDato.Location = new System.Drawing.Point(173, 73);
            this.cmbDato.Name = "cmbDato";
            this.cmbDato.Size = new System.Drawing.Size(121, 21);
            this.cmbDato.TabIndex = 16;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(106, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Buscar por:";
            // 
            // Grilla1
            // 
            this.Grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla1.Location = new System.Drawing.Point(83, 137);
            this.Grilla1.Name = "Grilla1";
            this.Grilla1.Size = new System.Drawing.Size(549, 338);
            this.Grilla1.TabIndex = 14;
            // 
            // frmConsultarRecAlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 595);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.cmbDato);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Grilla1);
            this.Name = "frmConsultarRecAlim";
            this.Text = "frmConsultarRecAlim";
            this.Load += new System.EventHandler(this.frmConsultarRecAlim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ComboBox cmbDato;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView Grilla1;
    }
}