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
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.Utilidades;

namespace AñosFelices
{
    public partial class frmDarDeBajaEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        EmpleadoSeleccionado empleadoSeleccionado;
        public frmDarDeBajaEmpleados()
        {
            InitializeComponent();
            empleadoSeleccionado = EmpleadoSeleccionado.Instance();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            UsuarioDTOMapper mapper = new UsuarioDTOMapper();
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos()).Where(x => x.Estado == "Habilitado").ToList();

            this.dgvEmpleados.DataSource = listado;
            this.dgvEmpleados.Columns["Dni"].DisplayIndex = 0;
            this.dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
            this.dgvEmpleados.Columns["Apellido"].DisplayIndex = 2;
            this.dgvEmpleados.Columns["Direccion"].DisplayIndex = 3;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmpleados.CurrentRow != null)
                {
                    var empleado = repositorioUsuario.ObtenerPorId(Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value));

                    empleadoSeleccionado.Usuario = empleado;

                    var usuario = repositorioUsuario.Inhabilitar(empleado);
                    MessageBox.Show("El empleado ha sido dado de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
