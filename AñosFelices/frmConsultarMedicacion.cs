using System;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmConsultarMedicacion : Form
    {
        IRepositorioHistoriaClinica consultarhc = new RepositorioHistoriaClinica();
        public frmConsultarMedicacion()
        {
            InitializeComponent();
            this.Grilla1.DataSource = consultarhc.ObtenerTodos();
        }

        private void frmConsultarMedicacion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cmbDato.Text == "DNI Paciente")
            {
                this.Grilla1.DataSource = consultarhc.ObtenerPorId(txtDato.Text);
            }
        }
    }
}
