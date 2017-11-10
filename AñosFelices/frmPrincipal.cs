using System;
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

    
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrar = new frmAltaPaciente();
            registrar.Show();
        }

        private void consultarActividadFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actividadFisicaC = new frmConsultarActividadFisica();
            actividadFisicaC.Show();
        }

        private void consultarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var comidaC = new frmConsultarComida();
            comidaC.Show();
        }

        private void consultarEstadoGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estadoC = new frmConsultarEstadoGeneral();
            estadoC.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoPacientes = new frmListadoPacientes();
            listadoPacientes.Show();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var darBaja = new frmDarDeBajaPaciente();
            darBaja.Show();
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var listarPacientes = new frmListarPacientes();
            listarPacientes.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var registrarEmpleado = new frmRegistrarEmpleado();
            registrarEmpleado.Show();

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listaEmpleados = new frmListaEmpleados();
            listaEmpleados.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listarEmpleados = new frmListarEmpleados();
            listarEmpleados.Show();
        }

        private void darDeBajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var darBaja = new frmDarDeBajaEmpleados();
            darBaja.Show();
        }
    }
}
