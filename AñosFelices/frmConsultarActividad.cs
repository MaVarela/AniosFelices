using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmConsultarActividad : Form
    {
        RegistroSeleccionado registroSeleccionado;
        public frmConsultarActividad()
        {
            InitializeComponent();
           registroSeleccionado = RegistroSeleccionado.Instance();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            registroSeleccionado = null;
            this.Close();
        }

        private void frmConsultarActividad_Load(object sender, EventArgs e)
        {
            //IRepositorioRol repositorioRol = new RepositorioRol();

            //RolDTOMapper mapper = new RolDTOMapper();

            registroSeleccionado.Registro = new LibroDeGuardias();

            txtUsuario.Text = registroSeleccionado.Registro.Usuario.Apellido.ToString() + " " + registroSeleccionado.Registro.Usuario.Nombre.ToString();
            cmbTurno.Text = registroSeleccionado.Registro.Turno.ToString();
            txtPaciente.Text = registroSeleccionado.Registro.Paciente.Apellido.ToString() + " " + registroSeleccionado.Registro.Paciente.Nombre.ToString();
            txtHabitacion.Text = registroSeleccionado.Registro.Paciente.Cama.Habitacion.IdHabitacion.ToString();
            txtCama.Text = registroSeleccionado.Registro.Paciente.Cama.IdCama.ToString();
            dtpFecha.Value = registroSeleccionado.Registro.Fecha;
            txtActividad.Text = registroSeleccionado.Registro.ActividadRealizada.ToString();

            /*this.cmbRol.DataSource = repositorioRol.ObtenerTodos();
            this.cmbRol.DisplayMember = "Descripcion";
            this.cmbRol.ValueMember = "IdRol";
            this.cmbRol.SelectedValue = empleadoSeleccionado.Usuario.Rol.IdRol;*/
        }
    }
}
