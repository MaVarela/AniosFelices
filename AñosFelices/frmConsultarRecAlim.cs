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
    public partial class frmConsultarRecAlim : Form
    {
        IRepositorioHistoriaClinica repositoriohisoriaclinica = new RepositorioHistoriaClinica();
        public frmConsultarRecAlim()
        {
            InitializeComponent();
        }

        private void frmConsultarRecAlim_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            var listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.ObtenerTodos());

            configurarGrilla(listado);
        }

        private void configurarGrilla(List<HistoriaClinicaDTO> listado)
        {
            this.dgvRecAliment.DataSource = listado;
            this.dgvRecAliment.Columns[0].Visible = true;
            this.dgvRecAliment.Columns[1].Visible = true;
            this.dgvRecAliment.Columns[2].Visible = true;
            this.dgvRecAliment.Columns[3].Visible = true;
            this.dgvRecAliment.Columns[4].Visible = true;
            this.dgvRecAliment.Columns[5].Visible = false;
            this.dgvRecAliment.Columns[6].Visible = true;
            this.dgvRecAliment.Columns[7].Visible = false;
            this.dgvRecAliment.Columns[8].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            List<HistoriaClinicaDTO> listado = new List<HistoriaClinicaDTO>();
            if (cmbDato.Text == "")
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
