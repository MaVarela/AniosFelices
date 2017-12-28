namespace AñosFelices
{
    partial class frmModificarPaciente
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
            this.components = new System.ComponentModel.Container();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvParientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSeleccionarHabitacion = new System.Windows.Forms.Button();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtEstadoFisico = new System.Windows.Forms.TextBox();
            this.cmsModPaciente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCama = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblEstadoFisico = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParientes)).BeginInit();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(166, 359);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar Pariente";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(299, 359);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(113, 29);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvParientes
            // 
            this.dgvParientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParientes.Location = new System.Drawing.Point(32, 256);
            this.dgvParientes.MultiSelect = false;
            this.dgvParientes.Name = "dgvParientes";
            this.dgvParientes.RowHeadersVisible = false;
            this.dgvParientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParientes.Size = new System.Drawing.Size(839, 84);
            this.dgvParientes.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(758, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 29);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(619, 404);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 29);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(32, 359);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Pariente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSeleccionarHabitacion
            // 
            this.btnSeleccionarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarHabitacion.Location = new System.Drawing.Point(668, 163);
            this.btnSeleccionarHabitacion.Name = "btnSeleccionarHabitacion";
            this.btnSeleccionarHabitacion.Size = new System.Drawing.Size(157, 29);
            this.btnSeleccionarHabitacion.TabIndex = 5;
            this.btnSeleccionarHabitacion.Text = "Seleccionar Habitación";
            this.btnSeleccionarHabitacion.UseVisualStyleBackColor = true;
            this.btnSeleccionarHabitacion.Click += new System.EventHandler(this.btnSeleccionarHabitacion_Click);
            // 
            // txtCama
            // 
            this.txtCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCama.Location = new System.Drawing.Point(525, 205);
            this.txtCama.Name = "txtCama";
            this.txtCama.ReadOnly = true;
            this.txtCama.Size = new System.Drawing.Size(100, 22);
            this.txtCama.TabIndex = 90;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(525, 165);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(100, 22);
            this.txtHabitacion.TabIndex = 89;
            // 
            // txtEstadoFisico
            // 
            this.txtEstadoFisico.ContextMenuStrip = this.cmsModPaciente;
            this.txtEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoFisico.Location = new System.Drawing.Point(150, 162);
            this.txtEstadoFisico.MaxLength = 255;
            this.txtEstadoFisico.Multiline = true;
            this.txtEstadoFisico.Name = "txtEstadoFisico";
            this.txtEstadoFisico.Size = new System.Drawing.Size(221, 61);
            this.txtEstadoFisico.TabIndex = 4;
            // 
            // cmsModPaciente
            // 
            this.cmsModPaciente.Name = "cmsModPaciente";
            this.cmsModPaciente.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApellido
            // 
            this.txtApellido.ContextMenuStrip = this.cmsModPaciente;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(150, 115);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.ContextMenuStrip = this.cmsModPaciente;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(150, 68);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCama.Location = new System.Drawing.Point(424, 205);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(47, 16);
            this.lblCama.TabIndex = 140;
            this.lblCama.Text = "Cama:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(424, 165);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(79, 16);
            this.lblHabitacion.TabIndex = 139;
            this.lblHabitacion.Text = "Habitación: ";
            // 
            // lblEstadoFisico
            // 
            this.lblEstadoFisico.AutoSize = true;
            this.lblEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFisico.Location = new System.Drawing.Point(29, 162);
            this.lblEstadoFisico.Name = "lblEstadoFisico";
            this.lblEstadoFisico.Size = new System.Drawing.Size(96, 16);
            this.lblEstadoFisico.TabIndex = 138;
            this.lblEstadoFisico.Text = "Estado Físico: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(29, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 137;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 136;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(29, 27);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 16);
            this.lblDni.TabIndex = 135;
            this.lblDni.Text = "DNI: ";
            // 
            // txtDni
            // 
            this.txtDni.AcceptsTab = true;
            this.txtDni.ContextMenuStrip = this.cmsModPaciente;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(150, 28);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 1;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFemenino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Enabled = false;
            this.grpSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexo.Location = new System.Drawing.Point(427, 70);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(368, 61);
            this.grpSexo.TabIndex = 143;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(215, 23);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(86, 20);
            this.rdbFemenino.TabIndex = 92;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(61, 23);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rdbMasculino.TabIndex = 91;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(424, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 16);
            this.lblFecha.TabIndex = 142;
            this.lblFecha.Text = "Fecha de Ingreso:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(556, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 22);
            this.dtpFecha.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(256, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 144;
            this.label10.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(314, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(314, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 146;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(377, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(631, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 148;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(631, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 149;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(801, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 150;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(801, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 151;
            this.label7.Text = "*";
            // 
            // frmModificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgvParientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSeleccionarHabitacion);
            this.Controls.Add(this.txtCama);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.txtEstadoFisico);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCama);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblEstadoFisico);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.MaximumSize = new System.Drawing.Size(922, 488);
            this.MinimumSize = new System.Drawing.Size(922, 488);
            this.Name = "frmModificarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Paciente";
            this.Load += new System.EventHandler(this.frmModificarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParientes)).EndInit();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvParientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSeleccionarHabitacion;
        private System.Windows.Forms.TextBox txtCama;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.TextBox txtEstadoFisico;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCama;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblEstadoFisico;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ContextMenuStrip cmsModPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}