using System;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;

namespace AñosFelices
{
    public partial class FrmAltaPaciente : Form
    {
        public FrmAltaPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ListadoHabitaciones = new frmHabitacionesList();
            ListadoHabitaciones.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var habitacionSeleccionada = HabitacionSeleccionada.Instance();
            //var camaSeleccionada = CamaSeleccionada.Instance();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            IRepositorioCama repositorioCama = new RepositorioCama();
            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
            //CamaId idCama = new CamaId();
            //idCama.Habitacion = repositorioHabitacion.ObtenerPorId(Convert.ToInt32(habitacionSeleccionada.Habitacion.Id));
            //idCama.IdCama = camaSeleccionada.Cama.IdCama;
   
           
            //var dni = repositorioPaciente.ObtenerPorId(Convert.ToInt32(this.mkdDni.Text));
            //if (dni == null)
            //{
            //    dni = new Paciente();
            //    dni.Dni = Convert.ToInt32(mkdDni.Text);
            //    dni.Nombre = txtNombre.Text;
            //    dni.Apellido = txtApellido.Text;
            //    dni.EstadoFisico = txtEstadoFisico.Text;
            //    dni = repositorioPaciente.Agregar(dni);
            //    dni = txtHabitacion = idCama.Habitacion.Camas;
                
            //}
           
        }    
    }
}
