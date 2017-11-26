using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices
{
    public partial class frmPacientes : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        PacienteSeleccionado pacienteSeleccionado = PacienteSeleccionado.Instance();

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();
            var listado = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.ObtenerTodos()).Where(x => x.Estado == "Habilitado").ToList();

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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                //if (dgvPacientes.CurrentRow.Cells["Estado"].Value.ToString() == "A")
                //{
                    //var pacienteSeleccionado = PacienteSeleccionado.Instance();
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
                    pacienteSeleccionado.Paciente.Estado = "A";

                    this.Close();
                //}
                //else
                //{
                    //MessageBox.Show("Paciente INACTIVO. No se puede Registrar Actividad Física", "Error",
                    //MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
