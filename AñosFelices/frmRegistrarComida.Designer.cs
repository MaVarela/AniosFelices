namespace AñosFelices
{
    partial class frmRegistrarComida
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
            this.txtComida = new System.Windows.Forms.TextBox();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCama = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(157, 277);
            this.txtComida.MaxLength = 10;
            this.txtComida.Multiline = true;
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(301, 126);
            this.txtComida.TabIndex = 90;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(473, 106);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(31, 23);
            this.btnPacientes.TabIndex = 87;
            this.btnPacientes.Text = "+";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(157, 65);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(112, 21);
            this.cmbTurno.TabIndex = 86;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(414, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 429);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 84;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(157, 108);
            this.txtPaciente.MaxLength = 10;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(301, 20);
            this.txtPaciente.TabIndex = 78;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(157, 24);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(301, 20);
            this.txtUsuario.TabIndex = 75;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(40, 279);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(97, 13);
            this.lblComida.TabIndex = 83;
            this.lblComida.Text = "Comida Preparada:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(97, 239);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 81;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Location = new System.Drawing.Point(46, 196);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(92, 13);
            this.lblCama.TabIndex = 80;
            this.lblCama.Text = "Número de Cama:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(22, 152);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(116, 13);
            this.lblHabitacion.TabIndex = 79;
            this.lblHabitacion.Text = "Número de Habitación:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(85, 112);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 77;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(99, 68);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 76;
            this.lblTurno.Text = "Turno:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(91, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 74;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Enabled = false;
            this.txtHabitacion.Location = new System.Drawing.Point(158, 148);
            this.txtHabitacion.MaxLength = 50;
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(60, 20);
            this.txtHabitacion.TabIndex = 92;
            // 
            // txtCama
            // 
            this.txtCama.Enabled = false;
            this.txtCama.Location = new System.Drawing.Point(158, 193);
            this.txtCama.MaxLength = 50;
            this.txtCama.Name = "txtCama";
            this.txtCama.ReadOnly = true;
            this.txtCama.Size = new System.Drawing.Size(60, 20);
            this.txtCama.TabIndex = 91;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(157, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha.TabIndex = 93;
            // 
            // frmRegistrarComida
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(529, 477);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.txtCama);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCama);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarComida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Comida";
            this.Load += new System.EventHandler(this.frmRegistrarComida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtComida;
        internal System.Windows.Forms.Button btnPacientes;
        internal System.Windows.Forms.ComboBox cmbTurno;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.TextBox txtPaciente;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label lblComida;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label lblCama;
        internal System.Windows.Forms.Label lblHabitacion;
        internal System.Windows.Forms.Label lblPaciente;
        internal System.Windows.Forms.Label lblTurno;
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.TextBox txtHabitacion;
        internal System.Windows.Forms.TextBox txtCama;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
    }
}