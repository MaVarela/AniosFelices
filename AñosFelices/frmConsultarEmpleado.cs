using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.DTOs.DTOMappers;
using System.Text.RegularExpressions;
using System.Text;

namespace AñosFelices
{
    public partial class frmConsultarEmpleado : Form
    {
        EmpleadoSeleccionado empleadoSeleccionado;

        public frmConsultarEmpleado()
        {
            InitializeComponent();
            empleadoSeleccionado  = EmpleadoSeleccionado.Instance();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            empleadoSeleccionado.Usuario = null;
            this.Close();
        }

        private void frmConsultarEmpleado_Load(object sender, EventArgs e)
        {
            IRepositorioRol repositorioRol = new RepositorioRol();

            RolDTOMapper mapper = new RolDTOMapper();

            txtDni.Text = empleadoSeleccionado.Usuario.Dni.ToString();
            txtNombre.Text = empleadoSeleccionado.Usuario.Nombre;
            txtApellido.Text = empleadoSeleccionado.Usuario.Apellido;
            txtDireccion.Text = empleadoSeleccionado.Usuario.Direccion;
            txtTelefono_1.Text = empleadoSeleccionado.Usuario.Telefono1;
            txtTelefono_2.Text = empleadoSeleccionado.Usuario.Telefono2;
            txtMail.Text = empleadoSeleccionado.Usuario.Mail;
            txtPassword.Text = empleadoSeleccionado.Usuario.Password;
            dtpFecha.Value = empleadoSeleccionado.Usuario.FechaIngreso;
            this.txtEstado.Text = empleadoSeleccionado.Usuario.Estado;
            this.cmbRol.DataSource = repositorioRol.ObtenerTodos();
            this.cmbRol.DisplayMember = "Descripcion";
            this.cmbRol.ValueMember = "IdRol";
            this.cmbRol.SelectedValue = empleadoSeleccionado.Usuario.Rol.IdRol;
        }

    }
}
