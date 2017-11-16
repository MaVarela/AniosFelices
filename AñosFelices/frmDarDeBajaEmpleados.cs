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

namespace AñosFelices
{
    public partial class frmDarDeBajaEmpleados : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public frmDarDeBajaEmpleados()
        {
            InitializeComponent();
            UsuarioDTOMapper mapper = new UsuarioDTOMapper();
            RolDTOMapper mapperRol = new RolDTOMapper();
            var listado = mapper.LlenarListado((List<Usuario>)repositorioUsuario.ObtenerTodos());

            this.dgvEmpleados.DataSource = listado;
        }

        private void frmDarDeBajaEmpleados_Load(object sender, EventArgs e)
        {
           

             
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    
                    usuario.Dni = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Dni"].Value);
                    usuario.Nombre = dgvEmpleados.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    usuario.Apellido = dgvEmpleados.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    usuario.Direccion = dgvEmpleados.SelectedRows[0].Cells["Direccion"].Value.ToString();
                    usuario.Telefono1 = dgvEmpleados.SelectedRows[0].Cells["Telefono1"].Value.ToString();
                    usuario.Telefono2 = dgvEmpleados.SelectedRows[0].Cells["Telefono2"].Value.ToString();
                    usuario.Mail = dgvEmpleados.SelectedRows[0].Cells["Mail"].Value.ToString();
                    usuario.Rol.Descripcion = dgvEmpleados.SelectedRows[0].Cells["Rol"].Value.ToString();
                    usuario.Rol.IdRol = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdRol"].Value.ToString());
                    usuario.Password = dgvEmpleados.SelectedRows[0].Cells["Password"].Value.ToString();
                    usuario.Estado = dgvEmpleados.SelectedRows[0].Cells["Estado"].Value.ToString();
                    usuario = empleado.Inhabilitar(usuario);
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
