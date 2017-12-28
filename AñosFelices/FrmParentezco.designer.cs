namespace AñosFelices
{
    partial class FrmParentezco
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
            this.txtTelefono_2 = new System.Windows.Forms.TextBox();
            this.txtTelefono_1 = new System.Windows.Forms.TextBox();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblParentezco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefono_2
            // 
            this.txtTelefono_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_2.Location = new System.Drawing.Point(163, 233);
            this.txtTelefono_2.MaxLength = 12;
            this.txtTelefono_2.Name = "txtTelefono_2";
            this.txtTelefono_2.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono_2.TabIndex = 40;
            // 
            // txtTelefono_1
            // 
            this.txtTelefono_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_1.Location = new System.Drawing.Point(163, 190);
            this.txtTelefono_1.MaxLength = 12;
            this.txtTelefono_1.Name = "txtTelefono_1";
            this.txtTelefono_1.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono_1.TabIndex = 39;
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Items.AddRange(new object[] {
            "Esposo",
            "Esposa",
            "Hijo",
            "Hija",
            "Hermano",
            "Hermana",
            "Primo",
            "Prima",
            "Tío",
            "Tía",
            "Sobrino",
            "Sobrina",
            "Nieto",
            "Nieta"});
            this.cmbParentezco.Location = new System.Drawing.Point(163, 144);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(121, 21);
            this.cmbParentezco.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 65);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 36;
            // 
            // txtDni
            // 
            this.txtDni.AcceptsTab = true;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(163, 24);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 35;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(36, 24);
            this.lblDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 52;
            this.lblDni.Text = "DNI:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(246, 381);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(115, 381);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 29);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 106);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(194, 20);
            this.txtApellido.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(163, 277);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(194, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(163, 320);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 20);
            this.txtMail.TabIndex = 42;
            // 
            // lblParentezco
            // 
            this.lblParentezco.AutoSize = true;
            this.lblParentezco.Location = new System.Drawing.Point(36, 144);
            this.lblParentezco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentezco.Name = "lblParentezco";
            this.lblParentezco.Size = new System.Drawing.Size(67, 13);
            this.lblParentezco.TabIndex = 51;
            this.lblParentezco.Text = "Parentezco: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Mail: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Dirección: ";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(36, 233);
            this.lblTelefono2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(97, 13);
            this.lblTelefono2.TabIndex = 48;
            this.lblTelefono2.Text = "Teléfono Opcional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Teléfono: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(36, 106);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 46;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 65);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmParentezco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 434);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefono_2);
            this.Controls.Add(this.txtTelefono_1);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblParentezco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmParentezco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Paciente";
            this.Load += new System.EventHandler(this.FrmParentezco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono_2;
        private System.Windows.Forms.TextBox txtTelefono_1;
        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblParentezco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}