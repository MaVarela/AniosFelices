using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;

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
            cargarCmbFiltrar();
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

        private void cargarCmbFiltrar()
        {
            cmbFiltrar.Items.Add("Rol");
            cmbFiltrar.Items.Add("Usuario");
            cmbFiltrar.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void cargarCmbRol()
        {
            try
            {
                IRepositorioRol repositorioRol = new RepositorioRol();
                var listado = repositorioRol.ObtenerTodos();

                cmbRol.DataSource = listado;
                cmbRol.DisplayMember = "Descripcion";
                cmbRol.ValueMember = "IdRol";

                cmbRol.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrar.Text == "Rol")
            {
                txtApellido.Text = null;
                txtNombre.Text = null;
                lblRol.Visible = true;
                cmbRol.Visible = true;
                cargarCmbRol();
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
            }
            else
            {
                txtApellido.Text = null;
                txtNombre.Text = null;
                lblRol.Visible = false;
                cmbRol.Visible = false;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTOMapper mapper = new UsuarioDTOMapper();

                if (cmbFiltrar.SelectedItem.ToString() == "Usuario")
                {
                    if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) && txtNombre.Text.Trim() != "")
                    {
                        if (!String.IsNullOrEmpty(this.txtApellido.Text.Trim()) && txtApellido.Text.Trim() != "")
                            this.dgvEmpleados.DataSource = mapper.LlenarListado((List<Usuario>)repositorioUsuario.BuscarRegistros(null, txtNombre.Text, txtApellido.Text));
                        else
                            MessageBox.Show("El campo 'Apellido' es Obligatorio");
                    }
                    else
                        MessageBox.Show("El campo 'Nombre' es Obligatorio");
                }
                else
                {
                    this.dgvEmpleados.DataSource = mapper.LlenarListado((List<Usuario>)repositorioUsuario.BuscarRegistros(Convert.ToInt32(cmbRol.SelectedValue), null, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            cmbFiltrar.Items.Clear();
            txtApellido.Text = null;
            txtNombre.Text = null;
            cargar();
        }

        private void cargar()
        {
            try
            {
                UsuarioDTOMapper mapper = new UsuarioDTOMapper();
                var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

                cargarGrilla();
                cargarCmbFiltrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
