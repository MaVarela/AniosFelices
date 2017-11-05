namespace AñosFelices
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeGuardiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarActividadFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.libroDeGuardiasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // libroDeGuardiasToolStripMenuItem
            // 
            this.libroDeGuardiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarActividadFísicaToolStripMenuItem,
            this.registrarComidaToolStripMenuItem,
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem});
            this.libroDeGuardiasToolStripMenuItem.Name = "libroDeGuardiasToolStripMenuItem";
            this.libroDeGuardiasToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.libroDeGuardiasToolStripMenuItem.Text = "Libro de Guardias";
            // 
            // registrarActividadFísicaToolStripMenuItem
            // 
            this.registrarActividadFísicaToolStripMenuItem.Name = "registrarActividadFísicaToolStripMenuItem";
            this.registrarActividadFísicaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.registrarActividadFísicaToolStripMenuItem.Text = "Registrar Actividad Física";
            this.registrarActividadFísicaToolStripMenuItem.Click += new System.EventHandler(this.registrarActividadFísicaToolStripMenuItem_Click);
            // 
            // registrarComidaToolStripMenuItem
            // 
            this.registrarComidaToolStripMenuItem.Name = "registrarComidaToolStripMenuItem";
            this.registrarComidaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.registrarComidaToolStripMenuItem.Text = "Registrar Comida";
            this.registrarComidaToolStripMenuItem.Click += new System.EventHandler(this.registrarComidaToolStripMenuItem_Click);
            // 
            // registrarEstadoGeneralDelPacienteToolStripMenuItem
            // 
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem.Name = "registrarEstadoGeneralDelPacienteToolStripMenuItem";
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem.Text = "Registrar Estado General del Paciente";
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstadoGeneralDelPacienteToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "Años Felices";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroDeGuardiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarActividadFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstadoGeneralDelPacienteToolStripMenuItem;
    }
}

