using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AniosFelicesSystem.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmConsultarRecActiv : Form
    {
        IRepositorioHistoriaClinica repositoriohistoriaclinica = new RepositorioHistoriaClinica();
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        UsuarioLogueado usuario = UsuarioLogueado.Instance();
        public frmConsultarRecActiv()
        {
            InitializeComponent();
        }

        private void frmConsultarRecActiv_Load(object sender, EventArgs e)
        {
            cargar();
            cmbDato.SelectedIndex = 0;
        }

        private void cargar()
        {
            try
            {
                HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
                var listado = mapper.ListarRecActividadFisica((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));

                configurarGrilla(listado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void configurarGrilla(List<HistoriaClinicaDTO> listado)
        {
            this.dgvRecActividades.DataSource = listado;
            this.dgvRecActividades.Columns[0].Visible = true;
            this.dgvRecActividades.Columns[1].Visible = true;
            this.dgvRecActividades.Columns[2].Visible = true;
            this.dgvRecActividades.Columns[3].Visible = true;
            this.dgvRecActividades.Columns[4].Visible = true;
            this.dgvRecActividades.Columns[5].Visible = true;
            this.dgvRecActividades.Columns[6].Visible = false;
            this.dgvRecActividades.Columns[7].Visible = false;
            this.dgvRecActividades.Columns[8].Visible = false;

            this.dgvRecActividades.Columns[0].HeaderText = "DNI del Paciente";
            this.dgvRecActividades.Columns[4].HeaderText = "Fecha de Visita";
            this.dgvRecActividades.Columns[5].HeaderText = "Recomendacion de Actividad Fisica";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            List<HistoriaClinicaDTO> listado = new List<HistoriaClinicaDTO>();

            try
            {
                if (cmbDato.Text == "Todos")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                }

                if (cmbDato.Text == "DNI Paciente")
                {

                    if (txtDato.Text != "")
                    {
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(int.Parse(txtDato.Text), null, null));
                    }
                    else
                    {
                        MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                    }
                }

                if (cmbDato.Text == "Nombre")
                {

                    if (txtDato.Text != "")
                    {
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, txtDato.Text, null));
                    }
                    else
                    {
                        MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                    }
                }

                if (cmbDato.Text == "Apellido")
                {

                    if (txtDato.Text != "")
                    {
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, txtDato.Text));
                    }
                    else
                    {
                        MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }

            configurarGrilla(listado);
        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbDato.Text == "DNI Paciente")
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    txtDato.Text = "";
                    lblMensaje.Text = "*Solo se permiten numeros";
                    lblMensaje.Visible = true;
                    lblMensaje.ForeColor = Color.Red;
                    e.Handled = true;
                }

                else { lblMensaje.Visible = false; }
            }
            else
            {
                if (cmbDato.Text == "Nombre" || cmbDato.Text == "Apellido")
                {
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        txtDato.Text = "";
                        lblMensaje.Text = "*Solo se permiten letras";
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = Color.Red;
                        e.Handled = true;
                    }

                    else { lblMensaje.Visible = false; }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDato_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDato.Text = "";
            lblMensaje.Visible = false;
        }
    }
}
