using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;
using AniosFelicesSystem.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmConsultarEstadoPaciente : Form
    {
        IRepositorioHistoriaClinica repositoriohisoriaclinica = new RepositorioHistoriaClinica();
        public frmConsultarEstadoPaciente()
        {
            InitializeComponent();
        }

        private void frmConsultarEstadoPaciente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            var listado = mapper.ListarEstadoGeneral((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));

            configurarGrilla(listado);

        }

        private void configurarGrilla(List<HistoriaClinicaDTO> listado)
        {
            this.dgvEstadoPaciente.DataSource = listado;
            this.dgvEstadoPaciente.Columns[0].Visible = true;
            this.dgvEstadoPaciente.Columns[1].Visible = true;
            this.dgvEstadoPaciente.Columns[2].Visible = true;
            this.dgvEstadoPaciente.Columns[3].Visible = true;
            this.dgvEstadoPaciente.Columns[4].Visible = true;
            this.dgvEstadoPaciente.Columns[5].Visible = false;
            this.dgvEstadoPaciente.Columns[6].Visible = false;
            this.dgvEstadoPaciente.Columns[7].Visible = false;
            this.dgvEstadoPaciente.Columns[8].Visible = true;

            this.dgvEstadoPaciente.Columns[0].HeaderText = "DNI del Paciente";
            this.dgvEstadoPaciente.Columns[4].HeaderText = "Fecha de Visita";
            this.dgvEstadoPaciente.Columns[8].HeaderText = "Estado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            List<HistoriaClinicaDTO> listado = new List<HistoriaClinicaDTO>();
            if (cmbDato.Text == "")
            {
                 listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(null, null, null));
            }

            if (cmbDato.Text == "DNI Paciente")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.BuscarRegistros(int.Parse(txtDato.Text),null,null));
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
    }
}
