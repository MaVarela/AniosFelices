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
            this.listarRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRecomendacionesAlimentariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMedicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.consultarHistoriaClinicaToolStripMenuItem,
            this.habitacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarRolesToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // listarRolesToolStripMenuItem
            // 
            this.listarRolesToolStripMenuItem.Name = "listarRolesToolStripMenuItem";
            this.listarRolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarRolesToolStripMenuItem.Text = "Listar";
            this.listarRolesToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // consultarHistoriaClinicaToolStripMenuItem
            // 
            this.consultarHistoriaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarRecomendacionesAlimentariasToolStripMenuItem,
            this.consultarRecomendacionesDeActividadFisicaToolStripMenuItem,
            this.consultarMedicacionToolStripMenuItem,
            this.consultarEstadoDePacientesToolStripMenuItem});
            this.consultarHistoriaClinicaToolStripMenuItem.Name = "consultarHistoriaClinicaToolStripMenuItem";
            this.consultarHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.consultarHistoriaClinicaToolStripMenuItem.Text = "Consultar Historia Clinica";
            // 
            // consultarRecomendacionesAlimentariasToolStripMenuItem
            // 
            this.consultarRecomendacionesAlimentariasToolStripMenuItem.Name = "consultarRecomendacionesAlimentariasToolStripMenuItem";
            this.consultarRecomendacionesAlimentariasToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.consultarRecomendacionesAlimentariasToolStripMenuItem.Text = "Consultar Recomendaciones Alimentarias";
            this.consultarRecomendacionesAlimentariasToolStripMenuItem.Click += new System.EventHandler(this.consultarRecomendacionesAlimentariasToolStripMenuItem_Click);
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
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarHabitacionesToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // listarHabitacionesToolStripMenuItem
            // 
            this.listarHabitacionesToolStripMenuItem.Name = "listarHabitacionesToolStripMenuItem";
            this.listarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarHabitacionesToolStripMenuItem.Text = "Listar";
            this.listarHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.listarHabitacionesToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem listarRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRecomendacionesAlimentariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRecomendacionesDeActividadFisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMedicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
    }
}

