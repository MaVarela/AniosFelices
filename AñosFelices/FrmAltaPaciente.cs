using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
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
    public partial class frmAltaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioCama repositorioCama = new RepositorioCama();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();

        public frmAltaPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ListadoHabitaciones = new frmHabitacionesList();
            ListadoHabitaciones.ShowDialog();
            var camaSeleccionada = CamaSeleccionada.Instance();
            if (camaSeleccionada.Cama != null)
            {
                this.txtCama.Text = camaSeleccionada.Cama.IdCama.ToString();
                this.txtCama.ReadOnly = true;
                this.txtHabitacion.Text = camaSeleccionada.Cama.IdHabitacion.ToString();
                this.txtHabitacion.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var agregarPariente = new frmAgregarPariente();
            agregarPariente.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var camaSeleccionada = CamaSeleccionada.Instance();

            if (camaSeleccionada.Cama != null)
            {
                var habitacion = repositorioHabitacion.ObtenerPorId(camaSeleccionada.Cama.IdHabitacion);
                habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault().Estado = "O";
                repositorioHabitacion.Editar(habitacion);
                var paciente = new Paciente()
                                    {
                                        Dni = Convert.ToInt32(this.mkdDni.Text),
                                        Cama = habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault(),
                                        Apellido = this.txtNombre.Text,
                                        Nombre = this.txtApellido.Text,
                                        EstadoFisico = this.txtEstadoFisico.Text,
                                        Parientes = new List<Pariente>()
                                    };

                repositorioPaciente.Agregar(paciente);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cama para dar de alta el paciente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mkdDni.Text = null;
            txtApellido.Text = null;
            txtCama.Text = null;
            txtEstadoFisico.Text = null;
            txtHabitacion.Text = null;
            txtNombre.Text = null;
            this.Close();
        }
    }
}
