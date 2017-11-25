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
using AñosFelices.DTO;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;

namespace AñosFelices
{
    public partial class frmListadoPacientes : Form
    {
        IRepositorioPaciente repositorioPacientes = new RepositorioPaciente();
        PacienteSeleccionado pacienteSeleccionado;
        public frmListadoPacientes()
        {
            InitializeComponent();
            pacienteSeleccionado = PacienteSeleccionado.Instance();

            this.dgvPacientes.DataSource = repositorioPacientes.ObtenerTodos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                if (this.dgvPacientes.CurrentRow != null)
                {
                    var pacienteElegido = repositorioPacientes.ObtenerPorId(Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value));

                    pacienteSeleccionado.Paciente = pacienteElegido;

                    frmModificarPaciente modificarPaciente = new frmModificarPaciente();
                    modificarPaciente.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void frmListadoPacientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();
            var listado = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPacientes.ObtenerTodos());

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

            configurarHabilitarModificar();
        }

        private void configurarHabilitarModificar()
        {
            btnModificar.Enabled = dgvPacientes.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado";
            btnHabilitar.Enabled = !(dgvPacientes.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado");
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            String estado = dgvPacientes.SelectedRows[0].Cells["Estado"].Value.ToString();
            try
            {
                if (this.dgvPacientes.CurrentRow != null)
                {
                    var paciente = repositorioPacientes.ObtenerPorId(Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["Dni"].Value));

                    paciente.Estado = "A";

                    foreach (var pariente in paciente.Parientes)
                    {
                        pariente.Estado = "A";
                    }
                    repositorioPacientes.Editar(paciente);
                    MessageBox.Show("El Paciente ha sido habilitado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pacienteSeleccionado.Paciente = null;
            }
        }

        private void dgvPacientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            configurarHabilitarModificar();
        }
    }
}
