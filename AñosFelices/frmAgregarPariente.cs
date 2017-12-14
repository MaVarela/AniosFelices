using AñosFelices.DTOs;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;

namespace AñosFelices
{
    public partial class frmAgregarPariente : Form
    {
        ParienteSeleccionado pariente;
        IRepositorioUsuario repositorioUsuarios = new RepositorioUsuario();
        IRepositorioPaciente repositorioPacientes = new RepositorioPaciente();
        IRepositorioPariente repositorioParientes = new RepositorioPariente();

        public frmAgregarPariente()
        {
            InitializeComponent();
            pariente = ParienteSeleccionado.Instance();
            this.cmbParentezco.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pariente.Parientes == null)
                {
                    pariente.Parientes = new List<ParienteDTO>();
                }

                List<String> mensajes = new List<String>();
                var parienteDTO = new ParienteDTO();

                if (!String.IsNullOrEmpty(txtDni.Text))
                {
                    if (txtDni.Text.Length >= 7 || txtDni.Text.Length == 8)
                        parienteDTO.Dni = Convert.ToInt32(txtDni.Text);
                    else
                        mensajes.Add("El campo 'Dni' debe poseer al menos 7 dígitos");
                }
                else
                    mensajes.Add("El campo 'DNI' es obligatorio");
                if (!String.IsNullOrEmpty(txtNombre.Text.Trim()))
                    parienteDTO.Nombre = txtNombre.Text.Trim();
                else
                    mensajes.Add("El campo 'Nombre' es obligatorio");
                if (!String.IsNullOrEmpty(txtApellido.Text.Trim()))
                    parienteDTO.Apellido = txtApellido.Text.Trim();
                else
                    mensajes.Add("El campo 'Apellido' es obligatorio");
                if (!String.IsNullOrEmpty(txtDireccion.Text.Trim()))
                    parienteDTO.Direccion = txtDireccion.Text.Trim();
                else
                    mensajes.Add("El campo 'Dirección' es obligatorio");

                if (!String.IsNullOrEmpty(txtMail.Text.Trim()))
                {
                    if (validarEmail(txtMail.Text))
                        parienteDTO.Mail = txtMail.Text;
                    else
                        mensajes.Add("El formato del 'Mail' es incorrecto (ejemplo@dominio.com)");
                }
                if (!String.IsNullOrEmpty(txtTelefono_1.Text))
                {
                    if (validarTelefono(txtTelefono_1.Text))
                        parienteDTO.Telefono1 = txtTelefono_1.Text;
                    else
                        mensajes.Add("El formato del 'Teléfono' es incorrecto (4740-4658/11-1234-1234)");
                }
                else
                    mensajes.Add("El campo 'Teléfono' es obligatorio");
                if (!String.IsNullOrEmpty(txtTelefono_2.Text))
                {
                    if (validarTelefono(txtTelefono_2.Text))
                        parienteDTO.Telefono2 = txtTelefono_2.Text;
                    else
                        mensajes.Add("El formato del 'Teléfono Opcional' es incorrecto (4740-4658/11-1234-1234)");
                }
                if (pariente.Parientes != null)
                {
                    var dni = Convert.ToInt32(txtDni.Text);

                    if (repositorioPacientes.Existe(dni) || repositorioParientes.Existe(dni) || repositorioUsuarios.Existe(dni) || pariente.Parientes.Where(x => x.Dni == dni).Count() > 0)
                        mensajes.Add("El Dni ingresado ya se encuentra registrado");
                }

                if (mensajes.Count.Equals(0))
                {
                    parienteDTO.Parentezco = cmbParentezco.SelectedItem.ToString();

                    pariente.Parientes.Add(parienteDTO);

                    MessageBox.Show("El pariente se ha registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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


                    