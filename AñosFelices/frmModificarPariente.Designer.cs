namespace AñosFelices
{
    partial class frmModificarPariente
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
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNom_Pariente = new System.Windows.Forms.TextBox();
            this.txtApe_Pariente = new System.Windows.Forms.TextBox();
            this.txtParentezco = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mkdTel_2 = new System.Windows.Forms.MaskedTextBox();
            this.mkdTel_1 = new System.Windows.Forms.MaskedTextBox();
            this.lblParentezco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(166, 28);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 22);
            this.txtDni.TabIndex = 35;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(26, 28);
            this.lblDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 16);
            this.lblDni.TabIndex = 34;
            this.lblDni.Text = "DNI:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 448);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 29);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNom_Pariente
            // 
            this.txtNom_Pariente.Location = new System.Drawing.Point(166, 76);
            this.txtNom_Pariente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom_Pariente.Name = "txtNom_Pariente";
            this.txtNom_Pariente.Size = new System.Drawing.Size(194, 22);
            this.txtNom_Pariente.TabIndex = 31;
            // 
            // txtApe_Pariente
            // 
            this.txtApe_Pariente.Location = new System.Drawing.Point(166, 123);
            this.txtApe_Pariente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApe_Pariente.Name = "txtApe_Pariente";
            this.txtApe_Pariente.Size = new System.Drawing.Size(194, 22);
            this.txtApe_Pariente.TabIndex = 30;
            // 
            // txtParentezco
            // 
            this.txtParentezco.Location = new System.Drawing.Point(166, 181);
            this.txtParentezco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParentezco.Name = "txtParentezco";
            this.txtParentezco.Size = new System.Drawing.Size(132, 22);
            this.txtParentezco.TabIndex = 29;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 350);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(194, 22);
            this.txtDireccion.TabIndex = 28;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(166, 406);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 22);
            this.txtMail.TabIndex = 27;
            // 
            // mkdTel_2
            // 
            this.mkdTel_2.Location = new System.Drawing.Point(166, 297);
            this.mkdTel_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mkdTel_2.Mask = "99999";
            this.mkdTel_2.Name = "mkdTel_2";
            this.mkdTel_2.Size = new System.Drawing.Size(132, 22);
            this.mkdTel_2.TabIndex = 26;
            this.mkdTel_2.ValidatingType = typeof(int);
            // 
            // mkdTel_1
            // 
            this.mkdTel_1.Location = new System.Drawing.Point(166, 240);
            this.mkdTel_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mkdTel_1.Mask = "99999";
            this.mkdTel_1.Name = "mkdTel_1";
            this.mkdTel_1.Size = new System.Drawing.Size(132, 22);
            this.mkdTel_1.TabIndex = 25;
            this.mkdTel_1.ValidatingType = typeof(int);
            // 
            // lblParentezco
            // 
            this.lblParentezco.AutoSize = true;
            this.lblParentezco.Location = new System.Drawing.Point(26, 177);
            this.lblParentezco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentezco.Name = "lblParentezco";
            this.lblParentezco.Size = new System.Drawing.Size(82, 16);
            this.lblParentezco.TabIndex = 24;
            this.lblParentezco.Text = "Parentezco: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mail: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dirección: ";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(26, 297);
            this.lblTelefono2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(119, 16);
            this.lblTelefono2.TabIndex = 21;
            this.lblTelefono2.Text = "Teléfono Opcional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teléfono: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(26, 123);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 16);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 76);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmModificarPariente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 488);
            this.ControlBox = false;
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNom_Pariente);
            this.Controls.Add(this.txtApe_Pariente);
            this.Controls.Add(this.txtParentezco);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mkdTel_2);
            this.Controls.Add(this.mkdTel_1);
            this.Controls.Add(this.lblParentezco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(400, 527);
            this.MinimumSize = new System.Drawing.Size(400, 527);
            this.Name = "frmModificarPariente";
            this.Text = "Modificar Pariente";
            this.Load += new System.EventHandler(this.frmModificarPariente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNom_Pariente;
        private System.Windows.Forms.TextBox txtApe_Pariente;
        private System.Windows.Forms.TextBox txtParentezco;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mkdTel_2;
        private System.Windows.Forms.MaskedTextBox mkdTel_1;
        private System.Windows.Forms.Label lblParentezco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}