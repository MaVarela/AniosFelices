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
            
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "IdRol";
            cmbRol.DataSource = listado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            IRepositorioUsuario repositorioUsuarios = new RepositorioUsuario();
            IRepositorioRol repositorioRol = new RepositorioRol();
            Usuario usuario = new Usuario();

            List<String> mensajes = new List<String>();

            if (!String.IsNullOrEmpty(txtDni.Text))
            {
                if (txtDni.Text.Length == 8)
                    usuario.Dni = Convert.ToInt32(txtDni.Text);
                else
                    mensajes.Add("El campo 'Dni' debe poseer 8 dígitos");
            }
            else
                mensajes.Add("El campo 'DNI' es obligatorio");
            if (!String.IsNullOrEmpty(txtNombre.Text))
                usuario.Nombre = txtNombre.Text;
            else
                mensajes.Add("El campo 'Nombre' es obligatorio");
            if (!String.IsNullOrEmpty(txtApellido.Text))
                usuario.Apellido = txtApellido.Text;
            else
                mensajes.Add("El campo 'Apellido' es obligatorio");
            if (!String.IsNullOrEmpty(txtDireccion.Text))
                usuario.Direccion = txtDireccion.Text;
            else
                mensajes.Add("El campo 'Dirección' es obligatorio");

            if (!String.IsNullOrEmpty(txtMail.Text))
            {
                if (validarEmail(txtMail.Text))
                    usuario.Mail = txtMail.Text;
                else
                    mensajes.Add("El formato del 'Mail' es incorrecto (ejemplo@dominio.com)");
            }
            if (!String.IsNullOrEmpty(txtTelefono_1.Text))
            {
                if(validarTelefono(txtTelefono_1.Text))
                    usuario.Telefono1 = txtTelefono_1.Text;
                else
                    mensajes.Add("El formato del 'Teléfono' es incorrecto (4740-4658/11-1234-1234)");
            }
            else
                mensajes.Add("El campo 'Teléfono' es obligatorio");
            if (!String.IsNullOrEmpty(txtTelefono_2.Text))
            {
                if (validarTelefono(txtTelefono_2.Text))
                    usuario.Telefono2 = txtTelefono_2.Text;
                else
                    mensajes.Add("El formato del 'Teléfono Opcional' es incorrecto (4740-4658/11-1234-1234)");
            }
            if (!String.IsNullOrEmpty(txtPassword.Text))
                usuario.Password = txtPassword.Text;
            else
                mensajes.Add("El campo 'Password' es obligatorio");
            usuario.Rol = repositorioRol.ObtenerPorId(Convert.ToInt32(cmbRol.SelectedValue));

            if (mensajes.Count.Equals(0))
            {
                usuario = repositorioUsuarios.Agregar(usuario);
                MessageBox.Show("El empleado se ha registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = null;
                this.Close();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (var mensaje in mensajes)
                {
                    sb.AppendLine(mensaje);
                }

                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtTelefono_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Guion = (char)45;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Guion;
        }

        private void txtTelefono_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Guion = (char)45;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Guion;
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

        public static bool validarEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMail.Text))
            {
                if (!validarEmail(txtMail.Text))
                {
                    txtMail.Clear();
                    MessageBox.Show("Ha ingresado una dirección de correo no válida");
                }
            }
        }

        public static bool validarTelefono(string telefono)
        {
            String formato = "^[0-9]{4}-[0-9]{4}$";
            String formatoCelular = "^[0-9]{2}-[0-9]{4}-[0-9]{4}$";

            if (Regex.IsMatch(telefono, formato))
            {
                if (Regex.Replace(telefono, formato, String.Empty).Length == 0)
                    return true;                
                else
                    return false;
            }
            else if(Regex.IsMatch(telefono, formatoCelular))
            {
                if(Regex.Replace(telefono, formatoCelular, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        private void txtTelefono_1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTelefono_1.Text))
            {
                if (!validarTelefono(txtTelefono_1.Text))
                {
                    txtTelefono_1.Clear();
                    MessageBox.Show("Se ha ingresado un teléfono con formato no válido");
                }
            }
        }

        private void txtTelefono_2_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTelefono_2.Text))
            {
                if (!validarTelefono(txtTelefono_2.Text))
                {
                    txtTelefono_2.Clear();
                    MessageBox.Show("Se ha ingresado un teléfono con formato no válido");
                }
            }
        }
    }
}
