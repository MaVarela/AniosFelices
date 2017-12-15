using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Windows.Forms;
using System.Linq;

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
            try
            {
                PacienteDTOMapper mapper = new PacienteDTOMapper();
                var listado = mapper.llenarListaPacienteDTO(repositorioPaciente.ObtenerTodos().Where(x => x.Estado == "A").ToList());

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
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPacientes.CurrentRow != null)
                {
                    if (dgvPacientes.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado")
                    {
                        var pacienteSeleccionado = PacienteSeleccionado.Instance();

                        pacienteSeleccionado.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value));

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
