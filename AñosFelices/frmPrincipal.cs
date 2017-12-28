using AñosFelices.Utilidades;
using System;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmPrincipal : Form
    {
        UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();

        public frmPrincipal()
        {
            InitializeComponent();
            var login = new frmLogin();
            login.ShowDialog();
            if(usuarioLogueado.Usuario != null)
                ConfigurarVista();
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

        private void registrarActividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void consultarActividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
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
            var listarPacientes = new frmListarPacientes();
            listarPacientes.Show();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarEmpleado = new frmRegistrarEmpleado();
            registrarEmpleado.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listaEmpleados = new frmListaEmpleados();
            listaEmpleados.Show();
        }

        private void listarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarEmpleados = new frmListarEmpleados();
            listarEmpleados.Show();
        }

        private void darDeBajaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var darBaja = new frmDarDeBajaEmpleados();
             darBaja.Show();
        }

        private void registrarRecomendacionDeActividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarActFisica = new frmRegistrarRecomendacionActFisica();
            registrarActFisica.Show();
        }

        private void registrarRecomendacionAlimentariaToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void ConfigurarVista()
        {
            var rol = usuarioLogueado.Usuario.Rol.Descripcion;

            if (rol == "Responsable Legal")
            {
                //pooner nuevamente en false
                this.libroDeGuardiasToolStripMenuItem.Visible = false;
                this.pacientesToolStripMenuItem.Visible = true;
                this.empleadosToolStripMenuItem.Visible = true;
                this.habitacionesToolStripMenuItem.Visible = true;
                this.consultarHistoriaClinicaToolStripMenuItem.Visible = true;
                this.registrarHistoriaClinicaToolStripMenuItem.Visible = true;
                this.consultarLibroDeGuardiasToolStripMenuItem.Visible = true;
            }
            if (rol == "Médico")
            {
                this.libroDeGuardiasToolStripMenuItem.Visible = false;
                this.pacientesToolStripMenuItem.Visible = false;
                this.empleadosToolStripMenuItem.Visible = false;
                this.habitacionesToolStripMenuItem.Visible = false;

                this.consultarHistoriaClinicaToolStripMenuItem.Visible = true;
                this.registrarHistoriaClinicaToolStripMenuItem.Visible = true;
                this.consultarLibroDeGuardiasToolStripMenuItem.Visible = true;

            }
            if (rol.ToString() == "Asistente" || rol.ToString() == "Enfermera" || rol.ToString() == "Encargada")
            {
                this.pacientesToolStripMenuItem.Visible = false;
                this.empleadosToolStripMenuItem.Visible = false;
                this.habitacionesToolStripMenuItem.Visible = false;
                this.consultarHistoriaClinicaToolStripMenuItem.Visible = false;
                this.registrarHistoriaClinicaToolStripMenuItem.Visible = false;

                this.consultarLibroDeGuardiasToolStripMenuItem.Visible = true;
                this.libroDeGuardiasToolStripMenuItem.Visible = true;
            }
            if (rol.ToString() == "Encargada de Cocina")
            {
                this.pacientesToolStripMenuItem.Visible = false;
                this.empleadosToolStripMenuItem.Visible = false;
                this.habitacionesToolStripMenuItem.Visible = false;
                this.registrarHistoriaClinicaToolStripMenuItem.Visible = false;

                this.consultarLibroDeGuardiasToolStripMenuItem.Visible = true;
                this.libroDeGuardiasToolStripMenuItem.Visible = true;
                this.consultarHistoriaClinicaToolStripMenuItem.Visible = true;
            }

            return;
        }

        private void modificacionDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarHabitacion = new frmListaHabitaciones();
            modificarHabitacion.Show();
        }

        private void darDeBajaHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var darDeBajaHabitacion = new frmDarDeBajaHabitaciones();
            darDeBajaHabitacion.Show();
        }
    }
}
