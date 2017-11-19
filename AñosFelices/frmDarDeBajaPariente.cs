using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
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
    public partial class frmEliminarParientes : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        public frmEliminarParientes()
        {
            InitializeComponent();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea Eliminar el Registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var pacienteSeleccionado = PacienteSeleccionado.Instance();
                    ParienteId idPariente = new ParienteId();
                    idPariente.DniPariente = Convert.ToInt32(dgvParientes.SelectedRows[0].Cells["Dni"].Value);
                    idPariente.Paciente = pacienteSeleccionado.Paciente;
                    var pariente = new Pariente();

                    pariente.Id = idPariente;
                    pariente.DniPariente = idPariente.DniPariente;
                    pariente.Paciente = idPariente.Paciente;

                    pariente.Apellido = dgvParientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    pariente.Nombre = dgvParientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    pariente.Direccion = dgvParientes.SelectedRows[0].Cells["Direccion"].Value.ToString();
                    pariente.Telefono1 = dgvParientes.SelectedRows[0].Cells["Telefono1"].Value.ToString();
                    pariente.Telefono2 = dgvParientes.SelectedRows[0].Cells["Telefono2"].Value.ToString();
                    pariente.Mail = dgvParientes.SelectedRows[0].Cells["Mail"].Value.ToString();
                    pariente.Parentezco = dgvParientes.SelectedRows[0].Cells["Parentezco"].Value.ToString();
                    pariente.Estado = "B";
                    //repositorioPariente.Inhabilitar(pariente);
                    repositorioPariente.Borrar(pariente);
                    MessageBox.Show("Registro Eliminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }      
            }    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDarDeBajaPariente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            lblPaciente.Text = lblPaciente.Text + pacienteSeleccionado.Paciente.Dni + " - " + pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
            ParienteDTOMapper mapper = new ParienteDTOMapper();

            var listado = mapper.LlenarListado((List<Pariente>)repositorioPariente.ObtenerTodos());

            this.dgvParientes.DataSource = listado;
        }
    }
}
