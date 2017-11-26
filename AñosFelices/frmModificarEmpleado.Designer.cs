namespace AñosFelices
{
    partial class frmModificarEmpleado
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmsModEmpleado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelefono_1 = new System.Windows.Forms.TextBox();
            this.txtTelefono_2 = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(27, 21);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 16);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI: ";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(27, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(27, 150);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(27, 195);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 16);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail: ";
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono1.Location = new System.Drawing.Point(27, 235);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(68, 16);
            this.lblTelefono1.TabIndex = 5;
            this.lblTelefono1.Text = "Teléfono: ";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono2.Location = new System.Drawing.Point(27, 275);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(123, 16);
            this.lblTelefono2.TabIndex = 6;
            this.lblTelefono2.Text = "Teléfono opcional: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(27, 359);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 16);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol:";
            // 
            // txtNombre
            // 
            this.txtNombre.ContextMenuStrip = this.cmsModEmpleado;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(158, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmsModEmpleado
            // 
            this.cmsModEmpleado.Name = "cmsModEmpleado";
            this.cmsModEmpleado.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApellido
            // 
            this.txtApellido.ContextMenuStrip = this.cmsModEmpleado;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(158, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(214, 22);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.ContextMenuStrip = this.cmsModEmpleado;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(158, 150);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(214, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.ContextMenuStrip = this.cmsModEmpleado;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(158, 195);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(214, 22);
            this.txtMail.TabIndex = 5;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ContextMenuStrip = this.cmsModEmpleado;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(158, 317);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // cmbRol
            // 
            this.cmbRol.ContextMenuStrip = this.cmsModEmpleado;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Médico",
            "Enfermera",
            "Fantasma"});
            this.cmbRol.Location = new System.Drawing.Point(159, 359);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(214, 24);
            this.cmbRol.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(130, 499);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 29);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(259, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDni
            // 
            this.txtDni.ContextMenuStrip = this.cmsModEmpleado;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(159, 21);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 1;
            // 
            // txtTelefono_1
            // 
            this.txtTelefono_1.ContextMenuStrip = this.cmsModEmpleado;
            this.txtTelefono_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_1.Location = new System.Drawing.Point(159, 235);
            this.txtTelefono_1.Name = "txtTelefono_1";
            this.txtTelefono_1.Size = new System.Drawing.Size(142, 22);
            this.txtTelefono_1.TabIndex = 6;
            this.txtTelefono_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_1_KeyPress);
            this.txtTelefono_1.Leave += new System.EventHandler(this.txtTelefono_1_Leave);
            // 
            // txtTelefono_2
            // 
            this.txtTelefono_2.ContextMenuStrip = this.cmsModEmpleado;
            this.txtTelefono_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_2.Location = new System.Drawing.Point(158, 275);
            this.txtTelefono_2.Name = "txtTelefono_2";
            this.txtTelefono_2.Size = new System.Drawing.Size(143, 22);
            this.txtTelefono_2.TabIndex = 7;
            this.txtTelefono_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_2_KeyPress);
            this.txtTelefono_2.Leave += new System.EventHandler(this.txtTelefono_2_Leave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(27, 451);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 16);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado: ";
            // 
            // txtEstado
            // 
            this.txtEstado.ContextMenuStrip = this.cmsModEmpleado;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(159, 451);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 405);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 16);
            this.lblFecha.TabIndex = 99;
            this.lblFecha.Text = "Fecha de Ingreso:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.ContextMenuStrip = this.cmsModEmpleado;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(158, 407);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(241, 22);
            this.dtpFecha.TabIndex = 10;
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 541);
            this.ControlBox = false;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtTelefono_2);
            this.Controls.Add(this.txtTelefono_1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.lblTelefono1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(448, 580);
            this.MinimumSize = new System.Drawing.Size(448, 580);
            this.Name = "frmModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.frmModificarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelefono_1;
        private System.Windows.Forms.TextBox txtTelefono_2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ContextMenuStrip cmsModEmpleado;
    }
}