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
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamas
            // 
            this.dgvCamas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamas.Location = new System.Drawing.Point(51, 47);
            this.dgvCamas.MultiSelect = false;
            this.dgvCamas.Name = "dgvCamas";
            this.dgvCamas.RowHeadersVisible = false;
            this.dgvCamas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamas.Size = new System.Drawing.Size(318, 145);
            this.dgvCamas.TabIndex = 0;
            // 
            // btnSeleccionarCama
            // 
            this.btnSeleccionarCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCama.Location = new System.Drawing.Point(128, 220);
            this.btnSeleccionarCama.Name = "btnSeleccionarCama";
            this.btnSeleccionarCama.Size = new System.Drawing.Size(111, 29);
            this.btnSeleccionarCama.TabIndex = 1;
            this.btnSeleccionarCama.Text = "Seleccionar";
            this.btnSeleccionarCama.UseVisualStyleBackColor = true;
            this.btnSeleccionarCama.Click += new System.EventHandler(this.btnSeleccionarCama_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(258, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarCama);
            this.Controls.Add(this.dgvCamas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(427, 300);
            this.Name = "frmCamas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamas;
        private System.Windows.Forms.Button btnSeleccionarCama;
        private System.Windows.Forms.Button btnCancelar;
    }
}