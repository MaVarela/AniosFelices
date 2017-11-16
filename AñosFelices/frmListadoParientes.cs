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
    public partial class frmListadoParientes : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        public frmListadoParientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoParientes_Load(object sender, EventArgs e)
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
