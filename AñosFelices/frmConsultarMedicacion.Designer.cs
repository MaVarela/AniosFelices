﻿namespace AñosFelices
{
    partial class frmConsultarMedicacion
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
            this.dgvMedicacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(586, 493);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 34);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(586, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 34);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(299, 59);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(108, 20);
            this.txtDato.TabIndex = 10;
            // 
            // cmbDato
            // 
            this.cmbDato.FormattingEnabled = true;
            this.cmbDato.Items.AddRange(new object[] {
            "",
            "DNI Paciente",
            "Nombre",
            "Apellido"});
            this.cmbDato.Location = new System.Drawing.Point(155, 59);
            this.cmbDato.Name = "cmbDato";
            this.cmbDato.Size = new System.Drawing.Size(121, 21);
            this.cmbDato.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(88, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Buscar por:";
            // 
            // dgvMedicacion
            // 
            this.dgvMedicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicacion.Location = new System.Drawing.Point(65, 123);
            this.dgvMedicacion.Name = "dgvMedicacion";
            this.dgvMedicacion.Size = new System.Drawing.Size(654, 338);
            this.dgvMedicacion.TabIndex = 7;
            // 
            // frmConsultarMedicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 582);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.cmbDato);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvMedicacion);
            this.Name = "frmConsultarMedicacion";
            this.Text = "Consultar Medicacion";
            this.Load += new System.EventHandler(this.frmConsultarMedicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicacion)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMedicacion;
    }
}