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
    public partial class frmConsultarActividadFisica : Form
    {
        IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();

        public frmConsultarActividadFisica()
        {
            InitializeComponent();
        }

        private void frmConsultarActividadFisica_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            var consultaActiva = ConsultaActiva.Instance();
            consultaActiva.Consulta = "ConsultarActividad";
            cargarCmbFiltrar();

            LibroDeGuardiasDTOMapper mapper = new LibroDeGuardiasDTOMapper();

            this.dgvActividad.DataSource = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.ObtenerTodos());
            
            this.dgvActividad.Columns[7].Visible = false;
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
            if(cmbFiltrar.Text == "Paciente - Fecha")
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
                if(cmbFiltrar.Text == "Turno - Fecha")
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
