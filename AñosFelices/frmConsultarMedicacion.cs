using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;

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
            var listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohisoriaclinica.ObtenerTodos());

            this.Grilla1.DataSource = listado;
            this.Grilla1.Columns[0].Visible = true;
            this.Grilla1.Columns[1].Visible = true;
            this.Grilla1.Columns[2].Visible = true;
            this.Grilla1.Columns[3].Visible = true;
            this.Grilla1.Columns[4].Visible = true;
            this.Grilla1.Columns[5].Visible = false;
            this.Grilla1.Columns[6].Visible = false;
            this.Grilla1.Columns[7].Visible = true;
            this.Grilla1.Columns[8].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbDato.Text == "")
            {
                this.Grilla1.DataSource = repositoriohisoriaclinica.ObtenerTodos();
            }

            if (cmbDato.Text == "DNI Paciente")
            {
                /*if (txtDato.Text != "")
                {
                    this.Grilla1.DataSource = consultarhc.ObtenerPorId();
                }
                else
                {*/
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
