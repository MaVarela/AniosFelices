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
    public partial class frmListarPacientes : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        public frmListarPacientes()
        {
            InitializeComponent();
            this.dgvPacientes.DataSource = repositorioPaciente.ObtenerTodos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
