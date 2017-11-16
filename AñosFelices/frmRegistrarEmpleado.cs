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
using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTOs.DTOMappers;
using System.Text.RegularExpressions;

namespace AñosFelices
{
    public partial class frmRegistrarEmpleado : Form
    {
        public frmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {
            IRepositorioRol repositorioRol = new RepositorioRol();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            var rol = repositorioRol.ObtenerTodos();
            RolDTOMapper mapper = new RolDTOMapper();
            var listado = mapper.LlenarListado((List<Rol>)rol.ToList());
            //this.dgvCamas.DataSource = listado;
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "IdRol";
            cmbRol.DataSource = listado;
           

        }

       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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
            int id = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            usuario.Rol = repositorioRol.ObtenerPorId(Convert.ToInt32(cmbRol.SelectedValue));
            usuario = repositorioUsuarios.Agregar(usuario);
            MessageBox.Show("El empleado se ha registrado correctamente");
            usuario = null;
            
            
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtTelefono_2_KeyPress(object sender, KeyPressEventArgs e)
        {

            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
               
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite texto");
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite texto");
            }
        }

        public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if(validarEmail(txtMail.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo no valida");
                txtMail.SelectAll();
                txtMail.Focus();
            }
        }

       

        

      

       
    }
}
