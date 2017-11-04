using System;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            var login = new frmLogin();
            login.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sarasa = new frmRolesList();
            sarasa.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarRecAlim();
            consultarhc.Show();
        }

        private void consultarRecomendacionesDeActividadFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarRecActiv();
            consultarhc.Show();
        }

        private void consultarMedicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarMedicacion();
            consultarhc.Show();
        }

        private void consultarEstadoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarhc = new frmConsultarEstadoPaciente();
            consultarhc.Show();
        }
    }
}
