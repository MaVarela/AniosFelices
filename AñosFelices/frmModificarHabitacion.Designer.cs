﻿using System.Windows.Forms;
namespace AñosFelices
{
    partial class frmModificarHabitacion
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
            this.lblNroHabitacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNroHabitacion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamas
            // 
            this.dgvCamas.AllowUserToAddRows = false;
            this.dgvCamas.AllowUserToDeleteRows = false;
            this.dgvCamas.AllowUserToResizeColumns = false;
            this.dgvCamas.AllowUserToResizeRows = false;
            this.dgvCamas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamas.Location = new System.Drawing.Point(185, 206);
            this.dgvCamas.MultiSelect = false;
            this.dgvCamas.Name = "dgvCamas";
            this.dgvCamas.ReadOnly = true;
            this.dgvCamas.RowHeadersVisible = false;
            this.dgvCamas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamas.Size = new System.Drawing.Size(245, 131);
            this.dgvCamas.TabIndex = 4;
            // 
            // lblNroHabitacion
            // 
            this.lblNroHabitacion.AutoSize = true;
            this.lblNroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHabitacion.Location = new System.Drawing.Point(21, 25);
            this.lblNroHabitacion.Name = "lblNroHabitacion";
            this.lblNroHabitacion.Size = new System.Drawing.Size(101, 16);
            this.lblNroHabitacion.TabIndex = 4;
            this.lblNroHabitacion.Text = "Nro. Habitación";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 87);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(21, 148);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // txtNroHabitacion
            // 
            this.txtNroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroHabitacion.Location = new System.Drawing.Point(137, 25);
            this.txtNroHabitacion.Name = "txtNroHabitacion";
            this.txtNroHabitacion.ReadOnly = true;
            this.txtNroHabitacion.Size = new System.Drawing.Size(73, 22);
            this.txtNroHabitacion.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AllowDrop = true;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(137, 87);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(293, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(137, 148);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(126, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(126, 239);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(31, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(185, 362);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(319, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(216, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(436, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(243, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "*";
            // 
            // frmModificarHabitacion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 409);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNroHabitacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNroHabitacion);
            this.Controls.Add(this.dgvCamas);
            this.MaximumSize = new System.Drawing.Size(488, 448);
            this.MinimumSize = new System.Drawing.Size(488, 448);
            this.Name = "frmModificarHabitacion";
            this.Text = "Modificar Habitación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamas;
        private System.Windows.Forms.Label lblNroHabitacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNroHabitacion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private Label label10;
        private Label label1;
        private Label label2;
    }
}