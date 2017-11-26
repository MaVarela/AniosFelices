using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTO;

namespace AñosFelices
{
    public partial class frmListarPacientes : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        public frmListarPacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarPacientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();
            var listado = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.ObtenerTodos());

            this.dgvPacientes.DataSource = listado;
            this.dgvPacientes.Columns["Dni"].DisplayIndex = 0;
            this.dgvPacientes.Columns["Apellido"].DisplayIndex = 1;
            this.dgvPacientes.Columns["Nombre"].DisplayIndex = 2;
            this.dgvPacientes.Columns["EstadoFisico"].DisplayIndex = 3;
            this.dgvPacientes.Columns["Habitacion"].DisplayIndex = 4;
            this.dgvPacientes.Columns["Cama"].DisplayIndex = 5;
            this.dgvPacientes.Columns["FechaIngreso"].DisplayIndex = 6;
            this.dgvPacientes.Columns["Estado"].DisplayIndex = 7;
            this.dgvPacientes.Columns["Sexo"].Visible = false;
            this.dgvPacientes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
        }

        private void btnParientes_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = PacienteSeleccionado.Instance();
                var paciente = new Paciente() { Cama = new Cama() { Habitacion = new Habitacion() } };

                pacienteSeleccionado.Paciente = paciente;
                pacienteSeleccionado.Paciente.Dni = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value);
                pacienteSeleccionado.Paciente.Apellido = dgvPacientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                pacienteSeleccionado.Paciente.Nombre = dgvPacientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                pacienteSeleccionado.Paciente.Sexo = dgvPacientes.SelectedRows[0].Cells[3].Value.ToString();
                pacienteSeleccionado.Paciente.FechaIngreso = Convert.ToDateTime(dgvPacientes.SelectedRows[0].Cells[4].Value.ToString());
                pacienteSeleccionado.Paciente.EstadoFisico = dgvPacientes.SelectedRows[0].Cells["EstadoFisico"].Value.ToString();
                pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[5].Value);
                pacienteSeleccionado.Paciente.Cama.Id.IdCama = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[6].Value);
                pacienteSeleccionado.Paciente.Estado = dgvPacientes.SelectedRows[0].Cells[8].Value.ToString();
                
                var listarParientes = new frmParientes();
                listarParientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
