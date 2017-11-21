using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;

namespace AñosFelices
{
    public partial class frmListaEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        EmpleadoSeleccionado empleadoSeleccionado;
        public frmListaEmpleados()
        {
            InitializeComponent();
            empleadoSeleccionado = EmpleadoSeleccionado.Instance();
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
            this.dgvEmpleados.Columns["Estado"].DisplayIndex = 8;
            this.dgvEmpleados.Columns["Password"].Visible = false;
            this.dgvEmpleados.Columns["IdRol"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             if (this.dgvEmpleados.CurrentRow != null)
            {
                if (dgvEmpleados.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado")
                {
                    var frmModificar = new frmModificarEmpleado();
                    var empleado = repositorioUsuario.ObtenerPorId(Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value));

                    empleadoSeleccionado.Usuario = empleado;
                    frmModificar.ShowDialog();
                    cargarGrilla();
                    configurarHabilitarModificar();
                }
                else
                {
                    MessageBox.Show("Empleado INHABILITADO. No se puede Modificar");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void configurarHabilitarModificar()
        {
            btnModificar.Enabled = dgvEmpleados.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado";
            btnHabilitar.Enabled = !(dgvEmpleados.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitado");
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmpleados.CurrentRow != null)
                {
                    var empleado = repositorioUsuario.ObtenerPorId(Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value));

                    empleadoSeleccionado.Usuario = empleado;

                    var usuario = repositorioUsuario.Habilitar(empleado);
                    MessageBox.Show("El empleado ha sido habilitado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                    configurarHabilitarModificar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                empleadoSeleccionado.Usuario = null;
            }
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            configurarHabilitarModificar();
        }

        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            configurarHabilitarModificar();
        }
    }
}
