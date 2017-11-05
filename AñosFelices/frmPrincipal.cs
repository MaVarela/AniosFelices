﻿using System;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            var login = new frmLogin();
            login.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListadoRoles = new frmRolesList();
            ListadoRoles.Show();
        }

        private void consultarRecomendacionesAlimentariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarRecAlim();
            consultarhc.Show();
        }

        private void consultarRecomendacionesDeActividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarRecActiv();
            consultarhc.Show();
        }

        private void consultarMedicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarMedicacion();
            consultarhc.Show();
        }

        private void consultarEstadoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarEstadoPaciente();
            consultarhc.Show();
        }

        private void listarHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListadoHabitaciones = new frmHabitacionesList();
            ListadoHabitaciones.Show();
        }

        private void registrarActividadFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actividadFisica = new frmRegistrarActividadFisica();
            actividadFisica.Show();
        }

        private void registrarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var comida = new frmRegistrarComida();
            comida.Show();
        }

        private void registrarEstadoGeneralDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estado = new frmRegistrarEstadoGeneral();
            estado.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
