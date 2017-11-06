using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
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
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            txtUsuario.Text = VariablesGlobales.apellidoUsuario + " " + VariablesGlobales.nombreUsuario;
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
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
            txtPaciente.Text = VariablesGlobales.Apellido + " " + VariablesGlobales.Nombre;
            txtHabitacion.Text = VariablesGlobales.IdHabitacion;
            txtCama.Text = VariablesGlobales.IdCama;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.DniPaciente = "";
            VariablesGlobales.Apellido = "";
            VariablesGlobales.Nombre = "";
            VariablesGlobales.EstadoFisico = "";
            VariablesGlobales.IdHabitacion = ""; 
            VariablesGlobales.IdCama = "";
            VariablesGlobales.Estado = "";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();
            LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();
            idLibroGuardias.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(VariablesGlobales.dniUsuario));
            idLibroGuardias.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(VariablesGlobales.DniPaciente));
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
