using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmModificarEmpleado : Form
    {
        
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            IRepositorioRol repositorioRol = new RepositorioRol();

            var empleadoSeleccionado = EmpleadoSeleccionado.Instance();
            RolDTOMapper mapper = new RolDTOMapper();
           
            txtDni.Text = empleadoSeleccionado.Usuario.Dni.ToString();
            txtNombre.Text = empleadoSeleccionado.Usuario.Nombre.ToString();
            txtApellido.Text = empleadoSeleccionado.Usuario.Apellido.ToString();
            txtDireccion.Text = empleadoSeleccionado.Usuario.Direccion.ToString();
            txtTelefono_1.Text = empleadoSeleccionado.Usuario.Telefono1.ToString();
            txtTelefono_2.Text = empleadoSeleccionado.Usuario.Telefono2.ToString();
            txtMail.Text = empleadoSeleccionado.Usuario.Mail.ToString();
            txtPassword.Text = empleadoSeleccionado.Usuario.Password.ToString();
            this.cmbRol.DataSource = repositorioRol.ObtenerTodos();
            this.cmbRol.DisplayMember = "Descripcion";
            this.cmbRol.ValueMember = "IdRol";
            this.cmbRol.SelectedValue = empleadoSeleccionado.Usuario.Rol.IdRol;
             
  }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = EmpleadoSeleccionado.Instance();
            IRepositorioUsuario repositorioUsuarios = new RepositorioUsuario();
            IRepositorioRol repositorioRol = new RepositorioRol();
            Usuario usuario = new Usuario();
            usuario.Dni = Convert.ToInt32(txtDni.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Mail = txtMail.Text;
            usuario.Telefono1 = txtTelefono_1.Text;
            usuario.Telefono2 = txtTelefono_2.Text;
            usuario.Password = txtPassword.Text;
            usuario.Rol = repositorioRol.ObtenerPorId(Convert.ToInt32(cmbRol.SelectedValue));
            usuario.Estado = empleadoSeleccionado.Usuario.Estado.ToString();
            usuario = repositorioUsuarios.Editar(usuario);
            MessageBox.Show("El empleado se ha modificado correctamente");
            usuario = null;
           
            
        }
    }
}
