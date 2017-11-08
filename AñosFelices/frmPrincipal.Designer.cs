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
            this.libroDeGuardiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarActividadFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstadoGeneralDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.consultarHistoriaClinicaToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.libroDeGuardiasToolStripMenuItem,
            this.pacientesToolStripMenuItem});
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
            this.listarRolesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
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
            this.listarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.listarHabitacionesToolStripMenuItem.Text = "Listar";
            this.listarHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.listarHabitacionesToolStripMenuItem_Click);
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
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.darDeBajaToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de Baja";
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
        private System.Windows.Forms.ToolStripMenuItem libroDeGuardiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarActividadFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstadoGeneralDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
    }
}

