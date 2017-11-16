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
    public partial class frmListaEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        public frmListaEmpleados()
        {
            InitializeComponent();
            UsuarioDTOMapper mapper = new UsuarioDTOMapper();
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

            this.dgvEmpleados.DataSource = listado;
            this.dgvEmpleados.Columns["Dni"].DisplayIndex = 0;
            this.dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
            this.dgvEmpleados.Columns["Apellido"].DisplayIndex = 2;
            this.dgvEmpleados.Columns["Direccion"].DisplayIndex = 3;
            this.dgvEmpleados.Columns["Telefono1"].DisplayIndex = 4;
            this.dgvEmpleados.Columns["Telefono2"].DisplayIndex = 5;
            this.dgvEmpleados.Columns["Mail"].DisplayIndex = 6;
            this.dgvEmpleados.Columns["Rol"].DisplayIndex = 7;
            this.dgvEmpleados.Columns["Password"].DisplayIndex = 8;
            this.dgvEmpleados.Columns["Estado"].DisplayIndex = 9;
            this.dgvEmpleados.Columns["IdRol"].Visible = false; 

        
        
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             if (this.dgvEmpleados.CurrentRow != null)
            {
                if (dgvEmpleados.CurrentRow.Cells["Estado"].Value.ToString() == "A")
                {
                    var frmModificar = new frmModificarEmpleado();
                    
                    var empleadoSeleccionado = EmpleadoSeleccionado.Instance();
                    var usuario = new Usuario() { Rol = new Rol() };
                    var empleado = new RepositorioUsuario();
                    var rol = new RepositorioRol();
                    empleadoSeleccionado.Usuario = usuario;
                    empleadoSeleccionado.Usuario.Dni = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value);
                    empleadoSeleccionado.Usuario.Nombre = dgvEmpleados.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    empleadoSeleccionado.Usuario.Apellido = dgvEmpleados.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    empleadoSeleccionado.Usuario.Direccion = dgvEmpleados.SelectedRows[0].Cells["Direccion"].Value.ToString();
                    empleadoSeleccionado.Usuario.Telefono1 = dgvEmpleados.SelectedRows[0].Cells["Telefono1"].Value.ToString();
                    empleadoSeleccionado.Usuario.Telefono2 = dgvEmpleados.SelectedRows[0].Cells["Telefono2"].Value.ToString();
                    empleadoSeleccionado.Usuario.Mail = dgvEmpleados.SelectedRows[0].Cells["Mail"].Value.ToString();
                    empleadoSeleccionado.Usuario.Rol.Descripcion = dgvEmpleados.SelectedRows[0].Cells["Rol"].Value.ToString();
                    empleadoSeleccionado.Usuario.Rol.IdRol = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdRol"].Value.ToString());
                    empleadoSeleccionado.Usuario.Password = dgvEmpleados.SelectedRows[0].Cells["Password"].Value.ToString();
                    empleadoSeleccionado.Usuario.Estado = dgvEmpleados.SelectedRows[0].Cells["Estado"].Value.ToString();
                    frmModificar.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Empleado INACTIVO. No se puede Modificar");
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
        }

      
    }

