using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
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
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

            cargarGrilla();
        }

        private void cargarGrilla()
        {
            UsuarioDTOMapper mapper = new UsuarioDTOMapper();
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

            this.dgvEmpleados.DataSource = listado;
            this.dgvEmpleados.Columns["Dni"].DisplayIndex = 0;
            this.dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
            this.dgvEmpleados.Columns["Apellido"].DisplayIndex = 2;
            this.dgvEmpleados.Columns["Direccion"].DisplayIndex = 3;
            this.dgvEmpleados.Columns["Direccion"].HeaderText = "Dirección";
            this.dgvEmpleados.Columns["Telefono1"].DisplayIndex = 4;
            this.dgvEmpleados.Columns["Telefono1"].HeaderText = "Teléfono";
            this.dgvEmpleados.Columns["Telefono2"].DisplayIndex = 5;
            this.dgvEmpleados.Columns["Telefono2"].HeaderText = "Teléfono Opcional";
            this.dgvEmpleados.Columns["Mail"].DisplayIndex = 6;
            this.dgvEmpleados.Columns["Rol"].DisplayIndex = 7;
            this.dgvEmpleados.Columns["FechaIngreso"].DisplayIndex = 8;
            this.dgvEmpleados.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
            this.dgvEmpleados.Columns["Estado"].DisplayIndex = 9;
            this.dgvEmpleados.Columns["Password"].Visible = false;
            this.dgvEmpleados.Columns["IdRol"].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvEmpleados.CurrentRow != null)
            {
                var frmConsultar = new frmConsultarEmpleado();
                var empleadoSeleccionado = EmpleadoSeleccionado.Instance();
                var empleado = repositorioUsuario.ObtenerPorId(Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value));

                empleadoSeleccionado.Usuario = empleado;

                frmConsultar.Show();
            }
        }      
    }
}
