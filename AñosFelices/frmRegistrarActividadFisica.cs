using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRegistrarActividadFisica : Form
    {
        public frmRegistrarActividadFisica()
        {
            InitializeComponent();
        }

        private void frmRegistrarActividadFisica_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            var usuarioLogueado = UsuarioLogueado.Instance();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            txtUsuario.Text = usuarioLogueado.Usuario.Apellido + " " + usuarioLogueado.Usuario.Nombre;
            cargarCmbTurno();   
        }

        private void cargarCmbTurno()
        {
            cmbTurno.Items.Add("Diurno");
            cmbTurno.Items.Add("Vespertino");
            cmbTurno.SelectedIndex = 0;
        }
       
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
            
            txtPaciente.Text = pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
            txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
            txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            var usuarioLogueado = UsuarioLogueado.Instance();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();
            LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();
            idLibroGuardias.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
            idLibroGuardias.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
            idLibroGuardias.Turno = this.cmbTurno.Text;
            var actividadFisica = repositorioLibroDeGuardias.ObtenerPorId(idLibroGuardias);
            var fecha = dtpFecha.Value.Date;

            if(actividadFisica == null)
            {
                actividadFisica = new LibroDeGuardias() { Id = idLibroGuardias };
                actividadFisica.Fecha = dtpFecha.Value;
                actividadFisica.ActividadRealizada = txtActividad.Text;
                actividadFisica = repositorioLibroDeGuardias.Agregar(actividadFisica);
                MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
