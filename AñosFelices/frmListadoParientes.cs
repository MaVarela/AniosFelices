using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
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
    public partial class frmListadoParientes : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        ParienteSeleccionado ParienteSeleccionado = ParienteSeleccionado.Instance();
        PacienteSeleccionado pacienteSeleccionado = PacienteSeleccionado.Instance();

        public frmListadoParientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            ParienteSeleccionado = null;
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount > 0)
            {
                var nombreForm = new frmListadoParientes().Name;
                int index;
                var parienteDTO = new ParienteDTO();
                index = Convert.ToInt32(dgvParientes.CurrentRow.Index.ToString());
                parienteDTO.Dni = Convert.ToInt32(dgvParientes.SelectedRows[0].Cells[0].Value);
                parienteDTO.Nombre = dgvParientes.SelectedRows[0].Cells[1].Value.ToString();
                parienteDTO.Apellido = dgvParientes.SelectedRows[0].Cells[2].Value.ToString();
                parienteDTO.Direccion = dgvParientes.SelectedRows[0].Cells[3].Value.ToString();
                parienteDTO.Telefono1 = dgvParientes.SelectedRows[0].Cells[4].Value.ToString();
                parienteDTO.Telefono2 = dgvParientes.SelectedRows[0].Cells[5].Value.ToString();
                parienteDTO.Mail = dgvParientes.SelectedRows[0].Cells[6].Value.ToString();
                parienteDTO.Parentezco = dgvParientes.SelectedRows[0].Cells[7].Value.ToString();

                var modificarPariente = new frmModificarPariente(index, parienteDTO, nombreForm);
                modificarPariente.ShowDialog();

                //cargarDGV();
                cargar();
            }
        }

        /*private void cargarDGV()
        {
            ParienteDTOMapper mapper = new ParienteDTOMapper();
            var listado = mapper.LlenarListado(ParienteSeleccionado.Parientes);


            dgvParientes.DataSource = listado;
        }*/

        private void frmListadoParientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            lblPaciente.Text = "Pariente/s del Paciente: ";
            var parienteDTO = new ParienteDTO();
            lblPaciente.Text = lblPaciente.Text + pacienteSeleccionado.Paciente.Dni + " - " + pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
            ParienteDTOMapper mapper = new ParienteDTOMapper();

            var listado = mapper.LlenarListado((List<Pariente>)repositorioPariente.ObtenerTodos());


            if (ParienteSeleccionado.Parientes == null)
            {
                ParienteSeleccionado.Parientes = new List<ParienteDTO>();
            }
            ParienteSeleccionado.Parientes = listado;

            this.dgvParientes.DataSource = listado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount < 2)
            {
                ParienteSeleccionado.Parientes = null;
                var agregarPariente = new frmAgregarPariente();
                agregarPariente.ShowDialog();

                //ParienteSeleccionado pariente = ParienteSeleccionado.Instance();
                //if (pariente.Parientes != null)
                //{
                    //cargarDGV();
                //}

                var Pariente = new Pariente();
                var parienteSeleccionado = ParienteSeleccionado.Instance();

                ParienteDTOMapper mapper = new ParienteDTOMapper();
                var listado = mapper.LlenarListadoPersist(parienteSeleccionado.Parientes, pacienteSeleccionado.Paciente);

                foreach (var registro in listado)
                {
                    Pariente.Id = registro.Id;
                    Pariente.DniPariente = registro.DniPariente;
                    Pariente.Apellido = registro.Apellido;
                    Pariente.Nombre = registro.Nombre;
                    Pariente.Direccion = registro.Direccion;
                    Pariente.Telefono1 = registro.Telefono1;
                    Pariente.Telefono2 = registro.Telefono2;
                    Pariente.Mail = registro.Mail;
                    Pariente.Parentezco = registro.Parentezco;
                    Pariente.Paciente = registro.Paciente;
                    Pariente.Estado = registro.Estado;

                    repositorioPariente.Agregar(Pariente);
                }

                MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargar();
                //parienteSeleccionado.Parientes = null;
            }
            else
            {
                MessageBox.Show("Solo se pueden agregar 2 parientes por Paciente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
