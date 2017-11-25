namespace AñosFelices
{
    partial class frmDarDeBajaHabitaciones
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCama = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(29, 44);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(469, 187);
            this.dgvHabitaciones.TabIndex = 1;
            // 
            // btnSeleccionarCama
            // 
            this.btnSeleccionarCama.Location = new System.Drawing.Point(254, 257);
            this.btnSeleccionarCama.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarCama.Name = "btnInhabilitar";
            this.btnSeleccionarCama.Size = new System.Drawing.Size(111, 29);
            this.btnSeleccionarCama.TabIndex = 2;
            this.btnSeleccionarCama.Text = "Inhabilitar";
            this.btnSeleccionarCama.UseVisualStyleBackColor = true;
            this.btnSeleccionarCama.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 257);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(260, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(238, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Seleccione la habitación a dar de baja";
            // 
            // frmDarDeBajaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 299);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarCama);
            this.Controls.Add(this.dgvHabitaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(539, 338);
            this.MinimumSize = new System.Drawing.Size(539, 338);
            this.Name = "frmDarDeBajaHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de Baja Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnSeleccionarCama;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescripcion;
    }
}