﻿namespace AñosFelices
{
    partial class frmCamas
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
            this.dgvCamas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamas
            // 
            this.dgvCamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamas.Location = new System.Drawing.Point(51, 47);
            this.dgvCamas.Name = "dgvCamas";
            this.dgvCamas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamas.Size = new System.Drawing.Size(318, 145);
            this.dgvCamas.TabIndex = 0;
            // 
            // btnSeleccionarCama
            // 
            this.btnSeleccionarCama.Location = new System.Drawing.Point(294, 215);
            this.btnSeleccionarCama.Name = "btnSeleccionarCama";
            this.btnSeleccionarCama.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCama.TabIndex = 1;
            this.btnSeleccionarCama.Text = "Seleccionar";
            this.btnSeleccionarCama.UseVisualStyleBackColor = true;
            this.btnSeleccionarCama.Click += new System.EventHandler(this.btnSeleccionarCama_Click);
            // 
            // frmCamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.btnSeleccionarCama);
            this.Controls.Add(this.dgvCamas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCamas";
            this.Text = "Camas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamas;
        private System.Windows.Forms.Button btnSeleccionarCama;
    }
}