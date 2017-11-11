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
    public partial class frmListarEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        public frmListarEmpleados()
        {
            InitializeComponent();
            this.dgvEmpleados.DataSource = repositorioUsuario.ObtenerTodos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
