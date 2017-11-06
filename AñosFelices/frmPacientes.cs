using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.DTO;
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
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmPacientes : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                if (dgvPacientes.CurrentRow.Cells["Estado"].Value.ToString() == "A")
                {
                    VariablesGlobales.DniPaciente = dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();
                    VariablesGlobales.Apellido = dgvPacientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    VariablesGlobales.Nombre = dgvPacientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    VariablesGlobales.EstadoFisico = dgvPacientes.SelectedRows[0].Cells[5].Value.ToString();
                    VariablesGlobales.IdHabitacion = dgvPacientes.SelectedRows[0].Cells[3].Value.ToString();
                    VariablesGlobales.IdCama = dgvPacientes.SelectedRows[0].Cells[4].Value.ToString();
                    VariablesGlobales.Estado = dgvPacientes.SelectedRows[0].Cells[6].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Paciente INACTIVO. No se puede Registrar Actividad Física", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún Paciente", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
