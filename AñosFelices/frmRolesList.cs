using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRolesList : Form
    {
        IRepositorioRol repositorioRol = new RepositorioRol();

        //HOLA JORGE HOLA MICHO
        public frmRolesList()
        {
            InitializeComponent();
            
            this.dgvRoles.DataSource = repositorioRol.ObtenerTodos();
        }

        private void frmRolesList_Load(object sender, System.EventArgs e)
        {

        }
    }
}
