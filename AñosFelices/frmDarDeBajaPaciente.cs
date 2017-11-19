using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;
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
    public partial class frmDarDeBajaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        public frmDarDeBajaPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea dar de Baja el Registro?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var nombreForm = frmListadoPacientes.ActiveForm.Name.ToString();
                    int index;

                    Paciente paciente = new Paciente();

                    index = Convert.ToInt32(dgvPacientes.CurrentRow.Index.ToString());
                    paciente.Dni = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["Dni"].Value);

                    paciente = repositorioPaciente.ObtenerPorId(paciente.Dni);

                    /*foreach (var pariente in paciente.Parientes)
                    {
                        repositorioPariente.Inhabilitar(pariente);
                    }*/
                    repositorioPaciente.Inhabilitar(paciente);
                    MessageBox.Show("Registro Dado de Baja Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            }
        }

        private void frmDarDeBajaPaciente_Load(object sender, EventArgs e)
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
            this.dgvPacientes.Columns["Estado"].DisplayIndex = 6;
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
                pacienteSeleccionado.Paciente.EstadoFisico = dgvPacientes.SelectedRows[0].Cells[5].Value.ToString();
                pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[3].Value);
                pacienteSeleccionado.Paciente.Cama.Id.IdCama = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[4].Value);
                pacienteSeleccionado.Paciente.Estado = dgvPacientes.SelectedRows[0].Cells[6].Value.ToString();

                var Parientes = new frmEliminarParientes();
                Parientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
