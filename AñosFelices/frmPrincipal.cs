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

        private void registrarActividadFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actividadFisica = new frmRegistrarActividadFisica();
            actividadFisica.Show();
        }

        private void registrarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var comida = new frmRegistrarComida();
            comida.Show();
        }

        private void registrarEstadoGeneralDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estado = new frmRegistrarEstadoGeneral();
            estado.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
