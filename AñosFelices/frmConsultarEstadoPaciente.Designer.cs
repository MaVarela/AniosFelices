namespace AñosFelices
{
    partial class frmConsultarEstadoPaciente
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.cmbDato = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvEstadoPaciente = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(622, 443);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 29);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(622, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnBuscar_KeyPress);
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(305, 37);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(108, 22);
            this.txtDato.TabIndex = 2;
            this.txtDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato_KeyPress);
            // 
            // cmbDato
            // 
            this.cmbDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDato.FormattingEnabled = true;
            this.cmbDato.Items.AddRange(new object[] {
            "Todos",
            "DNI Paciente",
            "Nombre",
            "Apellido"});
            this.cmbDato.Location = new System.Drawing.Point(153, 36);
            this.cmbDato.Name = "cmbDato";
            this.cmbDato.Size = new System.Drawing.Size(121, 24);
            this.cmbDato.TabIndex = 1;
            this.cmbDato.SelectionChangeCommitted += new System.EventHandler(this.cmbDato_SelectionChangeCommitted);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(68, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 16);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Buscar por:";
            // 
            // dgvEstadoPaciente
            // 
            this.dgvEstadoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoPaciente.Location = new System.Drawing.Point(71, 83);
            this.dgvEstadoPaciente.Name = "dgvEstadoPaciente";
            this.dgvEstadoPaciente.Size = new System.Drawing.Size(662, 338);
            this.dgvEstadoPaciente.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(469, 41);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 15;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.Visible = false;
            // 
            // frmConsultarEstadoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.cmbDato);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvEstadoPaciente);
            this.MaximumSize = new System.Drawing.Size(792, 523);
            this.MinimumSize = new System.Drawing.Size(792, 523);
            this.Name = "frmConsultarEstadoPaciente";
            this.Text = "Consultar Estado de Paciente";
            this.Load += new System.EventHandler(this.frmConsultarEstadoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ComboBox cmbDato;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvEstadoPaciente;
        private System.Windows.Forms.Label lblMensaje;
    }
}