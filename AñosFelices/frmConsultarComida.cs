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
            try
            {
                var consultaActiva = ConsultaActiva.Instance();
                consultaActiva.Consulta = "ConsultarComida";
                cargarCmbFiltrar();

                LibroDeGuardiasDTOMapper mapper = new LibroDeGuardiasDTOMapper();
                var listado = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.ObtenerTodos());

                this.dgvComida.DataSource = listado;
                this.dgvComida.Columns[6].Visible = false;
                this.dgvComida.Columns[8].Visible = false;
                this.dgvComida.Columns[9].Visible = false;
                this.dgvComida.Columns[10].Visible = false;
                this.dgvComida.Columns[11].Visible = false;
                this.dgvComida.Columns[12].Visible = false;
                this.dgvComida.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
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
                txtApellido.Text = null;
                txtNombre.Text = null;
                lblTurno.Visible = false;
                cmbTurno.Visible = false;
                cmbTurno.Items.Clear();
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblFecha.Visible = true;
                dtpFecha.Visible = true;
                dtpFecha.MaxDate = System.DateTime.Today;
            }
            else
            {
                if (cmbFiltrar.Text == "Turno - Fecha")
                {
                    txtApellido.Text = null;
                    txtNombre.Text = null;
                    cmbTurno.Items.Clear();
                    lblTurno.Visible = true;
                    cmbTurno.Visible = true;
                    cargarCmbTurno();
                    lblFecha.Visible = true;
                    dtpFecha.Visible = true;
                    dtpFecha.MaxDate = System.DateTime.Today;
                    lblApellido.Visible = false;
                    txtApellido.Visible = false;
                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                }
                else
                {
                    txtApellido.Text = null;
                    txtNombre.Text = null;
                    lblApellido.Visible = true;
                    txtApellido.Visible = true;
                    lblNombre.Visible = true;
                    txtNombre.Visible = true;
                    lblTurno.Visible = false;
                    cmbTurno.Visible = false;
                    cmbTurno.Items.Clear();
                    lblFecha.Visible = false;
                    dtpFecha.Visible = false;

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LibroDeGuardiasDTOMapper mapper = new LibroDeGuardiasDTOMapper();
                if (cmbFiltrar.SelectedItem.ToString() == "Paciente")
                {
                    if (!String.IsNullOrEmpty(this.txtApellido.Text.Trim()) && txtApellido.Text.Trim() != "")
                    {
                        if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) && txtNombre.Text.Trim() != "")
                            this.dgvComida.DataSource = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.BuscarRegistros(null, txtNombre.Text, txtApellido.Text, null));
                        else
                            MessageBox.Show("El campo 'Nombre' es Obligatorio");
                    }
                    else
                        MessageBox.Show("El campo 'Apellido' es Obligatorio");
                }
                else
                {
                    if (cmbFiltrar.SelectedItem.ToString() == "Paciente - Fecha")
                    {
                        if (!String.IsNullOrEmpty(this.txtApellido.Text.Trim()) && txtApellido.Text.Trim() != "")
                        {
                            if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) && txtNombre.Text.Trim() != "")
                                this.dgvComida.DataSource = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.BuscarRegistros(dtpFecha.Value.Date, txtNombre.Text, txtApellido.Text, null));
                            else
                                MessageBox.Show("El campo 'Nombre' es Obligatorio");
                        }
                        else
                            MessageBox.Show("El campo 'Apellido' es Obligatorio");
                    }
                    else
                        this.dgvComida.DataSource = mapper.llenarListaLibroDeGuardiasDTO((List<LibroDeGuardias>)repositorioLibroDeGuardias.BuscarRegistros(dtpFecha.Value.Date, null, null, cmbTurno.Text + ", Comida"));
                }
                this.dgvComida.Columns[6].Visible = false;
                this.dgvComida.Columns[8].Visible = false;
                this.dgvComida.Columns[9].Visible = false;
                this.dgvComida.Columns[10].Visible = false;
                this.dgvComida.Columns[11].Visible = false;
                this.dgvComida.Columns[12].Visible = false;
                this.dgvComida.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            cmbTurno.Items.Clear();
            cmbFiltrar.Items.Clear();
            txtApellido.Text = null;
            txtNombre.Text = null;
            cargar();
        }
    }
}
