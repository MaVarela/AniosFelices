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
    }
}
