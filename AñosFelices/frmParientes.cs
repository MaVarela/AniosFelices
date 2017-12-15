using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.Utilidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmParientes : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        public frmParientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                var pacienteSeleccionado = PacienteSeleccionado.Instance();
                lblPaciente.Text = lblPaciente.Text + pacienteSeleccionado.Paciente.Dni + " - " + pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
                ParienteDTOMapper mapper = new ParienteDTOMapper();

                var listado = mapper.LlenarListado(pacienteSeleccionado.Paciente.Parientes.ToList());

                this.dgvParientes.DataSource = listado;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
