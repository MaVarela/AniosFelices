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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public  void FiltrarMenuSegunUsuario(String rol){

            if(rol=="Medico")
            {
                libroDeGuardiasToolStripMenuItem.Visible = false;
                pacientesToolStripMenuItem.Visible = false;
                empleadosToolStripMenuItem.Visible = false;
                habitacionesToolStripMenuItem.Visible = false;
            }

            if (rol == "Asistente" || rol == "Enfermera" || rol == "Encargada")
            {
                pacientesToolStripMenuItem.Visible = false;
                empleadosToolStripMenuItem.Visible = false;
                habitacionesToolStripMenuItem.Visible = false;
                consultarHistoriaClinicaToolStripMenuItem.Visible = false;
                registrarHistoriaClinicaToolStripMenuItem2.Visible = false;
            }
            if (rol == "Encargada de cocina")
            {
                pacientesToolStripMenuItem.Visible = false;
                empleadosToolStripMenuItem.Visible = false;
                habitacionesToolStripMenuItem.Visible = false;
                registrarHistoriaClinicaToolStripMenuItem2.Visible = false;
            }
            return;
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
            var ListadoHabitaciones = new frmConsultarEstadoHabitaciones();
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


        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void modificarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoPacientes = new frmListadoPacientes();
            listadoPacientes.Show();
        }

        private void darDeBajaPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var darBaja = new frmDarDeBajaPaciente();
            darBaja.Show();
        }

        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var listarPacientes = new frmListarPacientes();
            listarPacientes.Show();*/
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var registrarEmpleado = new frmRegistrarEmpleado();
            registrarEmpleado.Show();*/

        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var listaEmpleados = new frmListaEmpleados();
            listaEmpleados.Show();*/
        }

        private void listarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var listarEmpleados = new frmListarEmpleados();
            listarEmpleados.Show();*/
        }

        private void darDeBajaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* var darBaja = new frmDarDeBajaEmpleados();
            darBaja.Show();*/
        }

        private void registrarRecomendaciónDeActividadFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarActFisica = new frmRegistrarRecomendacionActFisica();
            registrarActFisica.Show();
        }

        private void registrarRecomendaciónAlimentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarRecAlimentaria = new frmRegistrarRecomendacionAlimentaria();
            registrarRecAlimentaria.Show();
        }

        private void registrarEstadoDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarEstadoPaciente = new frmRegistrarEstadoPaciente();
            registrarEstadoPaciente.Show();
        }

        private void registrarMedicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarMedicacion = new frmRegistrarRecomendacionMedicacion();
            registrarMedicacion.Show();
        }

        private void altaDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaHabitacion = new frmAltaHabitacion();
            altaHabitacion.Show();
        }

       
    }
}
