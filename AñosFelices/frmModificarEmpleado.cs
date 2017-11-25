using System;
using System.Windows.Forms;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;
using System.Text;
using AñosFelices.Utilidades;
using System.Text.RegularExpressions;

namespace AñosFelices
{
    public partial class frmModificarEmpleado : Form
    {
        EmpleadoSeleccionado empleadoSeleccionado;
        public frmModificarEmpleado()
        {
            InitializeComponent();
            empleadoSeleccionado = EmpleadoSeleccionado.Instance();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            empleadoSeleccionado.Usuario = null;
            this.Close();
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
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
            if (empleadoSeleccionado.Usuario.Rol.Descripcion == "Responsable Legal")
                this.cmbRol.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                IRepositorioUsuario repositorioUsuarios = new RepositorioUsuario();
                IRepositorioRol repositorioRol = new RepositorioRol();
                
                List<String> mensajes = new List<String>();
                
                if (!String.IsNullOrEmpty(txtNombre.Text))
                    empleadoSeleccionado.Usuario.Nombre = txtNombre.Text;
                else
                    mensajes.Add("El campo 'Nombre' es obligatorio");
                if (!String.IsNullOrEmpty(txtApellido.Text))
                    empleadoSeleccionado.Usuario.Apellido = txtApellido.Text;
                else
                    mensajes.Add("El campo 'Apellido' es obligatorio");
                if (!String.IsNullOrEmpty(txtDireccion.Text))
                    empleadoSeleccionado.Usuario.Direccion = txtDireccion.Text;
                else
                    mensajes.Add("El campo 'Dirección' es obligatorio");

                if (!String.IsNullOrEmpty(txtMail.Text))
                {
                    if (validarEmail(txtMail.Text))
                        empleadoSeleccionado.Usuario.Mail = txtMail.Text;
                    else
                        mensajes.Add("El formato del 'Mail' es incorrecto (ejemplo@dominio.com)");
                }

                if (!String.IsNullOrEmpty(txtTelefono_1.Text))
                {
                    if (validarTelefono(txtTelefono_1.Text))
                        empleadoSeleccionado.Usuario.Telefono1 = txtTelefono_1.Text;
                    else
                        mensajes.Add("El formato del 'Teléfono' es incorrecto (4740-4658/11-1234-1234)");
                }
                else
                    mensajes.Add("El campo 'Teléfono' es obligatorio");
                if (!String.IsNullOrEmpty(txtTelefono_2.Text))
                {
                    if (validarTelefono(txtTelefono_2.Text))
                        empleadoSeleccionado.Usuario.Telefono2 = txtTelefono_2.Text;
                    else
                        mensajes.Add("El formato del 'Teléfono Opcional' es incorrecto (4740-4658/11-1234-1234)");
                }
                if (!String.IsNullOrEmpty(txtPassword.Text))
                    empleadoSeleccionado.Usuario.Password = txtPassword.Text;
                else
                    mensajes.Add("El campo 'Password' es obligatorio");
                empleadoSeleccionado.Usuario.Rol = repositorioRol.ObtenerPorId(Convert.ToInt32(cmbRol.SelectedValue));

                empleadoSeleccionado.Usuario.FechaIngreso = dtpFecha.Value.Date;
                
                if (mensajes.Count.Equals(0))
                {
                    empleadoSeleccionado.Usuario = repositorioUsuarios.Editar(empleadoSeleccionado.Usuario);
                    MessageBox.Show("El empleado se ha modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empleadoSeleccionado.Usuario = null;
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
            catch(Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    MessageBox.Show("Ha ingresado una dirección de correo no válida (ejemplo@dominio.com)");
                    txtMail.Focus();
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
            else if (Regex.IsMatch(telefono, formatoCelular))
            {
                if (Regex.Replace(telefono, formatoCelular, String.Empty).Length == 0)
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
                    MessageBox.Show("Se ha ingresado un teléfono con formato no válido (4740-4658/11-1234-1234)");
                    txtTelefono_1.Focus();
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
                    MessageBox.Show("Se ha ingresado un teléfono con formato no válido (4740-4658/11-1234-1234)");
                    txtTelefono_2.Focus();
                }
            }
        }
    }
}
