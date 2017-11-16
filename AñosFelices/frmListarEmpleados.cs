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
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmListarEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        public frmListarEmpleados()
        {
            InitializeComponent();
            UsuarioDTOMapper mapper = new UsuarioDTOMapper();
            RolDTOMapper mapperRol = new RolDTOMapper();
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

            this.dgvEmpleados.DataSource = listado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
