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
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lnlGrado = new System.Windows.Forms.Label();
            this.lblGazucar = new System.Windows.Forms.Label();
            this.lblGpresion = new System.Windows.Forms.Label();
            this.txtPresion2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTemperatura = new System.Windows.Forms.MaskedTextBox();
            this.txtAzucar = new System.Windows.Forms.MaskedTextBox();
            this.txtPresion1 = new System.Windows.Forms.MaskedTextBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecomendaciones
            // 
            this.txtRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecomendaciones.Location = new System.Drawing.Point(230, 484);
            this.txtRecomendaciones.MaxLength = 255;
            this.txtRecomendaciones.Multiline = true;
            this.txtRecomendaciones.Name = "txtRecomendaciones";
            this.txtRecomendaciones.Size = new System.Drawing.Size(389, 80);
            this.txtRecomendaciones.TabIndex = 107;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(178, 65);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(112, 24);
            this.cmbTurno.TabIndex = 103;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(508, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(385, 575);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 29);
            this.btnAceptar.TabIndex = 101;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(178, 108);
            this.txtPaciente.MaxLength = 10;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(301, 22);
            this.txtPaciente.TabIndex = 95;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(177, 24);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(301, 22);
            this.txtUsuario.TabIndex = 92;
            // 
            // lblRecomendaciones
            // 
            this.lblRecomendaciones.AutoSize = true;
            this.lblRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendaciones.Location = new System.Drawing.Point(30, 484);
            this.lblRecomendaciones.Name = "lblRecomendaciones";
            this.lblRecomendaciones.Size = new System.Drawing.Size(126, 16);
            this.lblRecomendaciones.TabIndex = 100;
            this.lblRecomendaciones.Text = "Recomendaciones:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(30, 236);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 98;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCama.Location = new System.Drawing.Point(30, 193);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(117, 16);
            this.lblCama.TabIndex = 97;
            this.lblCama.Text = "Número de Cama:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(30, 147);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(146, 16);
            this.lblHabitacion.TabIndex = 96;
            this.lblHabitacion.Text = "Número de Habitación:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(30, 106);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(64, 16);
            this.lblPaciente.TabIndex = 94;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(30, 65);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 16);
            this.lblTurno.TabIndex = 93;
            this.lblTurno.Text = "Turno:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(30, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 16);
            this.lblUsuario.TabIndex = 91;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(230, 386);
            this.txtObservaciones.MaxLength = 255;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(389, 80);
            this.txtObservaciones.TabIndex = 109;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(30, 383);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(103, 16);
            this.lblObservaciones.TabIndex = 108;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicacion.Location = new System.Drawing.Point(230, 289);
            this.txtMedicacion.MaxLength = 255;
            this.txtMedicacion.Multiline = true;
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Size = new System.Drawing.Size(389, 80);
            this.txtMedicacion.TabIndex = 111;
            // 
            // lblMedicacion
            // 
            this.lblMedicacion.AutoSize = true;
            this.lblMedicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicacion.Location = new System.Drawing.Point(30, 289);
            this.lblMedicacion.Name = "lblMedicacion";
            this.lblMedicacion.Size = new System.Drawing.Size(163, 16);
            this.lblMedicacion.TabIndex = 110;
            this.lblMedicacion.Text = "Medicación Administrada:";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresion.Location = new System.Drawing.Point(434, 148);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(57, 16);
            this.lblPresion.TabIndex = 112;
            this.lblPresion.Text = "Presión:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(434, 193);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(89, 16);
            this.lblTemperatura.TabIndex = 113;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblAzucar
            // 
            this.lblAzucar.AutoSize = true;
            this.lblAzucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzucar.Location = new System.Drawing.Point(434, 238);
            this.lblAzucar.Name = "lblAzucar";
            this.lblAzucar.Size = new System.Drawing.Size(52, 16);
            this.lblAzucar.TabIndex = 114;
            this.lblAzucar.Text = "Azúcar:";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(177, 149);
            this.txtHabitacion.MaxLength = 50;
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(60, 22);
            this.txtHabitacion.TabIndex = 121;
            // 
            // txtCama
            // 
            this.txtCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCama.Location = new System.Drawing.Point(177, 193);
            this.txtCama.MaxLength = 50;
            this.txtCama.Name = "txtCama";
            this.txtCama.ReadOnly = true;
            this.txtCama.Size = new System.Drawing.Size(60, 22);
            this.txtCama.TabIndex = 120;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(179, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 22);
            this.dtpFecha.TabIndex = 122;
            // 
            // lnlGrado
            // 
            this.lnlGrado.AutoSize = true;
            this.lnlGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlGrado.Location = new System.Drawing.Point(599, 190);
            this.lnlGrado.Name = "lnlGrado";
            this.lnlGrado.Size = new System.Drawing.Size(17, 22);
            this.lnlGrado.TabIndex = 123;
            this.lnlGrado.Text = "°";
            // 
            // lblGazucar
            // 
            this.lblGazucar.AutoSize = true;
            this.lblGazucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGazucar.Location = new System.Drawing.Point(599, 235);
            this.lblGazucar.Name = "lblGazucar";
            this.lblGazucar.Size = new System.Drawing.Size(42, 16);
            this.lblGazucar.TabIndex = 124;
            this.lblGazucar.Text = "mg/dl";
            // 
            // lblGpresion
            // 
            this.lblGpresion.AutoSize = true;
            this.lblGpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpresion.Location = new System.Drawing.Point(635, 152);
            this.lblGpresion.Name = "lblGpresion";
            this.lblGpresion.Size = new System.Drawing.Size(48, 16);
            this.lblGpresion.TabIndex = 125;
            this.lblGpresion.Text = "mmHg";
            // 
            // txtPresion2
            // 
            this.txtPresion2.AllowPromptAsInput = false;
            this.txtPresion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresion2.Location = new System.Drawing.Point(590, 148);
            this.txtPresion2.Mask = "99";
            this.txtPresion2.Name = "txtPresion2";
            this.txtPresion2.PromptChar = ' ';
            this.txtPresion2.Size = new System.Drawing.Size(45, 22);
            this.txtPresion2.TabIndex = 130;
            this.txtPresion2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPresion2_MouseClick);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(530, 193);
            this.txtTemperatura.Mask = "99";
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.PromptChar = ' ';
            this.txtTemperatura.Size = new System.Drawing.Size(65, 22);
            this.txtTemperatura.TabIndex = 131;
            this.txtTemperatura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTemperatura_MouseClick);
            // 
            // txtAzucar
            // 
            this.txtAzucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAzucar.Location = new System.Drawing.Point(530, 238);
            this.txtAzucar.Mask = "999";
            this.txtAzucar.Name = "txtAzucar";
            this.txtAzucar.PromptChar = ' ';
            this.txtAzucar.Size = new System.Drawing.Size(65, 22);
            this.txtAzucar.TabIndex = 132;
            this.txtAzucar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAzucar_MouseClick);
            // 
            // txtPresion1
            // 
            this.txtPresion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresion1.Location = new System.Drawing.Point(530, 147);
            this.txtPresion1.Mask = "999";
            this.txtPresion1.Name = "txtPresion1";
            this.txtPresion1.PromptChar = ' ';
            this.txtPresion1.Size = new System.Drawing.Size(45, 22);
            this.txtPresion1.TabIndex = 133;
            this.txtPresion1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPresion1_MouseClick);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(577, 152);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(12, 16);
            this.lblBarra.TabIndex = 134;
            this.lblBarra.Text = "/";
            // 
            // frmRegistrarEstadoGeneral
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(707, 615);
            this.ControlBox = false;
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.txtPresion1);
            this.Controls.Add(this.txtAzucar);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtPresion2);
            this.Controls.Add(this.lblGpresion);
            this.Controls.Add(this.lblGazucar);
            this.Controls.Add(this.lnlGrado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.txtCama);
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
            this.MaximumSize = new System.Drawing.Size(723, 654);
            this.MinimumSize = new System.Drawing.Size(667, 654);
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
        internal System.Windows.Forms.TextBox txtHabitacion;
        internal System.Windows.Forms.TextBox txtCama;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.Label lnlGrado;
        internal System.Windows.Forms.Label lblGazucar;
        internal System.Windows.Forms.Label lblGpresion;
        private System.Windows.Forms.MaskedTextBox txtPresion2;
        private System.Windows.Forms.MaskedTextBox txtTemperatura;
        private System.Windows.Forms.MaskedTextBox txtAzucar;
        private System.Windows.Forms.MaskedTextBox txtPresion1;
        internal System.Windows.Forms.Label lblBarra;
    }
}