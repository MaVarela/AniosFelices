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
            this.consultarHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMedicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.consultarHistoriaClinicaToolStripMenuItem});
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
            // consultarHistoriaClinicaToolStripMenuItem
            // 
            this.consultarHistoriaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem,
            this.consultarMedicacionToolStripMenuItem,
            this.consultarEstadoDePacientesToolStripMenuItem});
            this.consultarHistoriaClinicaToolStripMenuItem.Name = "consultarHistoriaClinicaToolStripMenuItem";
            this.consultarHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.consultarHistoriaClinicaToolStripMenuItem.Text = "Consultar Historia Clinica";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(326, 22);
            this.listarToolStripMenuItem1.Text = "Consultar Recomendaciones Alimentarias";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // consultarRecomendacionesDeActividadFisicaToolStripMenuItem
            // 
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem.Name = "consultarRecomendacionesDeActividadFisicaToolStripMenuItem";
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem.Text = "Consultar Recomendaciones de Actividad Fisica";
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem.Click += new System.EventHandler(this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem_Click);
            // 
            // consultarMedicacionToolStripMenuItem
            // 
            this.consultarMedicacionToolStripMenuItem.Name = "consultarMedicacionToolStripMenuItem";
            this.consultarMedicacionToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.consultarMedicacionToolStripMenuItem.Text = "Consultar Medicacion";
            this.consultarMedicacionToolStripMenuItem.Click += new System.EventHandler(this.consultarMedicacionToolStripMenuItem_Click);
            // 
            // consultarEstadoDePacientesToolStripMenuItem
            // 
            this.consultarEstadoDePacientesToolStripMenuItem.Name = "consultarEstadoDePacientesToolStripMenuItem";
            this.consultarEstadoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.consultarEstadoDePacientesToolStripMenuItem.Text = "Consultar Estado de Pacientes";
            this.consultarEstadoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.consultarEstadoDePacientesToolStripMenuItem_Click);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarRecomendacionesDeActividadFisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMedicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadoDePacientesToolStripMenuItem;
    }
}

