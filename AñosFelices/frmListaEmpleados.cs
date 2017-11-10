using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;

namespace AñosFelices
{
    public partial class frmListaEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        public frmListaEmpleados()
        {
            InitializeComponent();
            this.dgvEmpleados.DataSource = repositorioUsuario.ObtenerTodos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var modificar = new frmModificarEmpleado();
            modificar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
