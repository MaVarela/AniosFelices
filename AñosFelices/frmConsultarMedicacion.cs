using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;
using AniosFelicesSystem.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmConsultarMedicacion : Form
    {
        IRepositorioHistoriaClinica repositoriohisoriaclinica = new RepositorioHistoriaClinica();
        public frmConsultarMedicacion()
        {
            InitializeComponent();
        }

        private void frmConsultarMedicacion_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            var listado = mapper.ListarRecMedicacion((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));

            configurarGrilla(listado);
        }
        private void configurarGrilla(List<HistoriaClinicaDTO> listado)
        {
            
            this.dgvMedicacion.DataSource = listado;
            this.dgvMedicacion.Columns[0].Visible = true;
            this.dgvMedicacion.Columns[1].Visible = true;
            this.dgvMedicacion.Columns[2].Visible = true;
            this.dgvMedicacion.Columns[3].Visible = true;
            this.dgvMedicacion.Columns[4].Visible = true;
            this.dgvMedicacion.Columns[5].Visible = false;
            this.dgvMedicacion.Columns[6].Visible = false;
            this.dgvMedicacion.Columns[7].Visible = true;
            this.dgvMedicacion.Columns[8].Visible = false;

            this.dgvMedicacion.Columns[0].HeaderText = "DNI del Paciente";
            this.dgvMedicacion.Columns[4].HeaderText = "Fecha de Visita";
            this.dgvMedicacion.Columns[7].HeaderText = "Medicacion Recomendada";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            List<HistoriaClinicaDTO> listado = new List<HistoriaClinicaDTO>();

            if (cmbDato.Text == "Todos")
            {
                listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.ObtenerTodos());
            }

            if (cmbDato.Text == "DNI Paciente")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(int.Parse(txtDato.Text), null, null));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            if (cmbDato.Text == "Nombre")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, txtDato.Text, null));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            if (cmbDato.Text == "Apellido")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, txtDato.Text));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            configurarGrilla(listado);
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmbDato_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDato.Text = "";
            lblMensaje.Visible = false;
        }
    }
}
