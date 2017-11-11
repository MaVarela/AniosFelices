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
    public partial class frmListadoPacientes : Form
    {
        IRepositorioPaciente repositorioPacientes = new RepositorioPaciente();
        public frmListadoPacientes()
        {
            InitializeComponent();

            this.dgvPacientes.DataSource = repositorioPacientes.ObtenerTodos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /*var modificarPaciente = new frmModificarPaciente();
            modificarPaciente.Show();*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
