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
    public partial class frmConsultarComida : Form
    {
        IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();

        public frmConsultarComida()
        {
            InitializeComponent();
        }

        private void frmConsultarComida_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            var consultaActiva = ConsultaActiva.Instance();
            consultaActiva.Consulta = "ConsultarComida";
            cargarCmbFiltrar();

            LibroDeGuardiasDTOMapper mapper = new LibroDeGuardiasDTOMapper();
            var listado = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.ObtenerTodos());

            this.dgvActividad.DataSource = listado;
            this.dgvActividad.Columns[6].Visible = false;
            this.dgvActividad.Columns[8].Visible = false;
            this.dgvActividad.Columns[9].Visible = false;
            this.dgvActividad.Columns[10].Visible = false;
            this.dgvActividad.Columns[11].Visible = false;
            this.dgvActividad.Columns[12].Visible = false;
            this.dgvActividad.Columns[13].Visible = false;
        }

        private void cargarCmbFiltrar()
        {
            cmbFiltrar.Items.Add("Paciente - Fecha");
            cmbFiltrar.Items.Add("Turno - Fecha");
            cmbFiltrar.Items.Add("Paciente");
            cmbFiltrar.SelectedIndex = 0;
        }

        private void cargarCmbTurno()
        {
            cmbTurno.Items.Add("Diurno");
            cmbTurno.Items.Add("Vespertino");
            cmbTurno.Items.Add("Nocturno");
            cmbTurno.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var consultaActiva = ConsultaActiva.Instance();
            consultaActiva.Consulta = null;
            this.Close();
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrar.Text == "Paciente - Fecha")
            {
                lblTurno.Visible = false;
                cmbTurno.Visible = false;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblFecha.Visible = true;
                dtpFecha.Visible = true;
            }
            else
            {
                if (cmbFiltrar.Text == "Turno - Fecha")
                {
                    lblTurno.Visible = true;
                    cmbTurno.Visible = true;
                    cargarCmbTurno();
                    lblFecha.Visible = true;
                    dtpFecha.Visible = true;
                    lblApellido.Visible = false;
                    txtApellido.Visible = false;
                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                }
                else
                {
                    lblApellido.Visible = true;
                    txtApellido.Visible = true;
                    lblNombre.Visible = true;
                    txtNombre.Visible = true;
                    lblTurno.Visible = false;
                    cmbTurno.Visible = false;
                    lblFecha.Visible = false;
                    dtpFecha.Visible = false;

                }
            }
        }
    }
}
