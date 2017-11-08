namespace AñosFelices
{
    partial class frmRegistrarEstadoGeneral
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
            this.txtRecomendaciones = new System.Windows.Forms.TextBox();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRecomendaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCama = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtMedicacion = new System.Windows.Forms.TextBox();
            this.lblMedicacion = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblAzucar = new System.Windows.Forms.Label();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.txtAzucar = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Location = new System.Drawing.Point(179, 605);
            this.txtRecomendaciones.MaxLength = 10;
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(300, 80);
            this.txtRecomendaciones.TabIndex = 107;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(494, 106);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(31, 23);
            this.btnPacientes.TabIndex = 104;
            this.btnPacientes.Text = "+";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(178, 65);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(112, 21);
            this.cmbTurno.TabIndex = 103;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(436, 706);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(313, 706);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 101;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(178, 108);
            this.txtPaciente.MaxLength = 10;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(301, 20);
            this.txtPaciente.TabIndex = 95;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(177, 24);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(301, 20);
            this.txtUsuario.TabIndex = 92;
            // 
            // lblRecomendaciones
            // 
            this.lblRecomendaciones.AutoSize = true;
            this.lblRecomendaciones.Location = new System.Drawing.Point(62, 609);
            this.lblRecomendaciones.Name = "lblRecomendaciones";
            this.lblRecomendaciones.Size = new System.Drawing.Size(99, 13);
            this.lblRecomendaciones.TabIndex = 100;
            this.lblRecomendaciones.Text = "Recomendaciones:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(118, 239);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 98;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Location = new System.Drawing.Point(67, 196);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(92, 13);
            this.lblCama.TabIndex = 97;
            this.lblCama.Text = "Número de Cama:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(43, 152);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(116, 13);
            this.lblHabitacion.TabIndex = 96;
            this.lblHabitacion.Text = "Número de Habitación:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(106, 112);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 94;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(120, 68);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 93;
            this.lblTurno.Text = "Turno:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(111, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 91;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(178, 501);
            this.txtObservaciones.MaxLength = 10;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(300, 80);
            this.txtObservaciones.TabIndex = 109;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(77, 505);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 108;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.Location = new System.Drawing.Point(179, 401);
            this.txtMedicacion.MaxLength = 10;
            this.txtMedicacion.Multiline = true;
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Size = new System.Drawing.Size(300, 80);
            this.txtMedicacion.TabIndex = 111;
            // 
            // lblMedicacion
            // 
            this.lblMedicacion.AutoSize = true;
            this.lblMedicacion.Location = new System.Drawing.Point(30, 405);
            this.lblMedicacion.Name = "lblMedicacion";
            this.lblMedicacion.Size = new System.Drawing.Size(128, 13);
            this.lblMedicacion.TabIndex = 110;
            this.lblMedicacion.Text = "Medicación Administrada:";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.Location = new System.Drawing.Point(113, 281);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(45, 13);
            this.lblPresion.TabIndex = 112;
            this.lblPresion.Text = "Presión:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(88, 318);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 113;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblAzucar
            // 
            this.lblAzucar.AutoSize = true;
            this.lblAzucar.Location = new System.Drawing.Point(115, 358);
            this.lblAzucar.Name = "lblAzucar";
            this.lblAzucar.Size = new System.Drawing.Size(43, 13);
            this.lblAzucar.TabIndex = 114;
            this.lblAzucar.Text = "Azúcar:";
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(179, 277);
            this.txtPresion.MaxLength = 10;
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(65, 20);
            this.txtPresion.TabIndex = 117;
            // 
            // txtAzucar
            // 
            this.txtAzucar.Location = new System.Drawing.Point(179, 356);
            this.txtAzucar.MaxLength = 10;
            this.txtAzucar.Name = "txtAzucar";
            this.txtAzucar.Size = new System.Drawing.Size(65, 20);
            this.txtAzucar.TabIndex = 118;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(179, 315);
            this.txtTemperatura.MaxLength = 10;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(65, 20);
            this.txtTemperatura.TabIndex = 119;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Enabled = false;
            this.txtHabitacion.Location = new System.Drawing.Point(177, 149);
            this.txtHabitacion.MaxLength = 50;
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(60, 20);
            this.txtHabitacion.TabIndex = 121;
            // 
            // txtCama
            // 
            this.txtCama.Enabled = false;
            this.txtCama.Location = new System.Drawing.Point(177, 193);
            this.txtCama.MaxLength = 50;
            this.txtCama.Name = "txtCama";
            this.txtCama.ReadOnly = true;
            this.txtCama.Size = new System.Drawing.Size(60, 20);
            this.txtCama.TabIndex = 120;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(179, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha.TabIndex = 122;
            // 
            // frmRegistrarEstadoGeneral
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(564, 741);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.txtCama);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtAzucar);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.lblAzucar);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblPresion);
            this.Controls.Add(this.txtMedicacion);
            this.Controls.Add(this.lblMedicacion);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtRecomendaciones);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblRecomendaciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCama);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblUsuario);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarEstadoGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Estado General";
            this.Load += new System.EventHandler(this.frmRegistrarEstadoGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRecomendaciones;
        internal System.Windows.Forms.Button btnPacientes;
        internal System.Windows.Forms.ComboBox cmbTurno;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.TextBox txtPaciente;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label lblRecomendaciones;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label lblCama;
        internal System.Windows.Forms.Label lblHabitacion;
        internal System.Windows.Forms.Label lblPaciente;
        internal System.Windows.Forms.Label lblTurno;
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.TextBox txtObservaciones;
        internal System.Windows.Forms.Label lblObservaciones;
        internal System.Windows.Forms.TextBox txtMedicacion;
        internal System.Windows.Forms.Label lblMedicacion;
        internal System.Windows.Forms.Label lblPresion;
        internal System.Windows.Forms.Label lblTemperatura;
        internal System.Windows.Forms.Label lblAzucar;
        internal System.Windows.Forms.TextBox txtPresion;
        internal System.Windows.Forms.TextBox txtAzucar;
        internal System.Windows.Forms.TextBox txtTemperatura;
        internal System.Windows.Forms.TextBox txtHabitacion;
        internal System.Windows.Forms.TextBox txtCama;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
    }
}