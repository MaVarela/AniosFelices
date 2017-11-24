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
        IRepositorioPaciente repositorioPaciente;
        IRepositorioPariente repositorioPariente;
        public frmDarDeBajaPaciente()
        {
            InitializeComponent();
            repositorioPaciente = new RepositorioPaciente();
            repositorioPariente = new RepositorioPariente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.RowCount > 0)
            {
                String estado = dgvPacientes.SelectedRows[0].Cells["Estado"].Value.ToString();
                if (estado == "A")
                {
                    if (MessageBox.Show("¿Está seguro de que desea dar de Baja el Registro?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Paciente paciente = new Paciente();

                        paciente.Dni = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["Dni"].Value);

                        paciente = repositorioPaciente.ObtenerPorId(paciente.Dni);

                        foreach (var pariente in paciente.Parientes)
                        {
                            repositorioPariente.Inhabilitar(pariente);
                        }
                        repositorioPaciente.Inhabilitar(paciente);
                        MessageBox.Show("Registro Dado de Baja Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar();
                    }
                }
                else
                    MessageBox.Show("El Paciente ya se encuentra deshabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
