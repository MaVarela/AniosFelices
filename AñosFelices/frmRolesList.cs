using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRolesList : Form
    {
        IRepositorioRol repositorioRol = new RepositorioRol();

        public frmRolesList()
        {
            InitializeComponent();
            
            this.dgvRoles.DataSource = repositorioRol.ObtenerTodos();
        }
    }
}
