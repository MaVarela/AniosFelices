namespace AñosFelices
{
    partial class frmAltaPaciente
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEstadoFisico = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblCama = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEstadoFisico = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtCama = new System.Windows.Forms.TextBox();
            this.btnSeleccionarHabitacion = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvParientes = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.cmsAltaPaciente = new System.Windows.Forms.ContextMenuStrip(this.components);
            //this.btnAgregar_pariente_existente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParientes)).BeginInit();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(32, 31);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 16);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(32, 119);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblEstadoFisico
            // 
            this.lblEstadoFisico.AutoSize = true;
            this.lblEstadoFisico.Location = new System.Drawing.Point(32, 166);
            this.lblEstadoFisico.Name = "lblEstadoFisico";
            this.lblEstadoFisico.Size = new System.Drawing.Size(96, 16);
            this.lblEstadoFisico.TabIndex = 3;
            this.lblEstadoFisico.Text = "Estado Físico: ";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(427, 170);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(79, 16);
            this.lblHabitacion.TabIndex = 4;
            this.lblHabitacion.Text = "Habitación: ";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Location = new System.Drawing.Point(427, 208);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(47, 16);
            this.lblCama.TabIndex = 5;
            this.lblCama.Text = "Cama:";
            // 
            // txtNombre
            // 
            this.txtNombre.ContextMenuStrip = this.cmsAltaPaciente;
            this.txtNombre.Location = new System.Drawing.Point(141, 72);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.ContextMenuStrip = this.cmsAltaPaciente;
            this.txtApellido.Location = new System.Drawing.Point(141, 119);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 22);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtEstadoFisico
            // 
            this.txtEstadoFisico.ContextMenuStrip = this.cmsAltaPaciente;
            this.txtEstadoFisico.Location = new System.Drawing.Point(141, 166);
            this.txtEstadoFisico.MaxLength = 255;
            this.txtEstadoFisico.Multiline = true;
            this.txtEstadoFisico.Name = "txtEstadoFisico";
            this.txtEstadoFisico.Size = new System.Drawing.Size(221, 61);
            this.txtEstadoFisico.TabIndex = 4;
            this.txtEstadoFisico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadoFisico_KeyPress);
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(522, 167);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.ReadOnly = true;
            this.txtHabitacion.Size = new System.Drawing.Size(100, 22);
            this.txtHabitacion.TabIndex = 95;
            // 
            // txtCama
            // 
            this.txtCama.Location = new System.Drawing.Point(522, 208);
            this.txtCama.Name = "txtCama";
            this.txtCama.ReadOnly = true;
            this.txtCama.Size = new System.Drawing.Size(100, 22);
            this.txtCama.TabIndex = 96;
            // 
            // btnSeleccionarHabitacion
            // 
            this.btnSeleccionarHabitacion.Location = new System.Drawing.Point(660, 165);
            this.btnSeleccionarHabitacion.Name = "btnSeleccionarHabitacion";
            this.btnSeleccionarHabitacion.Size = new System.Drawing.Size(166, 29);
            this.btnSeleccionarHabitacion.TabIndex = 7;
            this.btnSeleccionarHabitacion.Text = "Seleccionar Habitación";
            this.btnSeleccionarHabitacion.UseVisualStyleBackColor = true;
            this.btnSeleccionarHabitacion.Click += new System.EventHandler(this.btnSeleccionarHabitacion_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 361);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 29);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Pariente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(629, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 29);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(763, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvParientes
            // 
            this.dgvParientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParientes.Location = new System.Drawing.Point(35, 260);
            this.dgvParientes.MultiSelect = false;
            this.dgvParientes.Name = "dgvParientes";
            this.dgvParientes.RowHeadersVisible = false;
            this.dgvParientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParientes.Size = new System.Drawing.Size(839, 84);
            this.dgvParientes.TabIndex = 8;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(303, 361);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 29);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(167, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 29);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar Pariente";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDni
            // 
            this.txtDni.AcceptsTab = true;
            this.txtDni.ContextMenuStrip = this.cmsAltaPaciente;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(141, 31);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 1;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(557, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 22);
            this.dtpFecha.TabIndex = 94;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(425, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 16);
            this.lblFecha.TabIndex = 95;
            this.lblFecha.Text = "Fecha de Ingreso:";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFemenino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(428, 74);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(368, 61);
            this.grpSexo.TabIndex = 96;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(215, 23);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(86, 20);
            this.rdbFemenino.TabIndex = 6;
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
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // btnAgregar_pariente_existente
            // 
            //this.btnAgregar_pariente_existente.Location = new System.Drawing.Point(35, 408);
            //this.btnAgregar_pariente_existente.Name = "btnAgregar_pariente_existente";
            //this.btnAgregar_pariente_existente.Size = new System.Drawing.Size(229, 29);
            //this.btnAgregar_pariente_existente.TabIndex = 97;
            //this.btnAgregar_pariente_existente.Text = "Agregar Pariente Existente";
            //this.btnAgregar_pariente_existente.UseVisualStyleBackColor = true;
            //this.btnAgregar_pariente_existente.Click += new System.EventHandler(this.btnAgregar_nuevo_pariente_Click);
            // 
            // cmsAltaPaciente
            // 
            this.cmsAltaPaciente.Name = "cmsAltaPaciente";
            this.cmsAltaPaciente.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 458);
            this.ControlBox = false;
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
            //this.Controls.Add(this.btnAgregar_pariente_existente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(916, 497);
            this.MinimumSize = new System.Drawing.Size(916, 497);
            this.Name = "frmAltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Paciente";
            this.Load += new System.EventHandler(this.frmAltaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParientes)).EndInit();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEstadoFisico;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblCama;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEstadoFisico;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.TextBox txtCama;
        private System.Windows.Forms.Button btnSeleccionarHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvParientes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ContextMenuStrip cmsAltaPaciente;
        //private System.Windows.Forms.Button btnAgregar_pariente_existente;
    }
}