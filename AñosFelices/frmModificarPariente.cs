using AñosFelices.DTOs;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmModificarPariente : Form
    {
        int index;
        ParienteDTO parienteDTO = new ParienteDTO();
        ParienteSeleccionado pariente;
        String nombreFormM;
        int DniPariente;

        public frmModificarPariente(int index, ParienteDTO parienteDTO, String nombreForm)
        {
            InitializeComponent();
            this.index = index;
            this.parienteDTO = parienteDTO;
            pariente = ParienteSeleccionado.Instance();
            this.nombreFormM = nombreForm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> mensajes = new List<String>();
                var parienteDTO = new ParienteDTO();

                if (!String.IsNullOrEmpty(txtDni.Text))
                {
                    if (txtDni.Text.Length >= 7 || txtDni.Text.Length == 8)
                        parienteDTO.Dni = Convert.ToInt32(txtDni.Text);
                    else
                        mensajes.Add("El campo 'Dni' debe poseer entre 7 y 8 dígitos");
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


                if (mensajes.Count.Equals(0))
                {
                    if (pariente.Parientes == null)
                    {
                        pariente.Parientes = new List<ParienteDTO>();
                    }
                    parienteDTO.Parentezco = cmbParentezco.SelectedItem.ToString();


                    //pariente.Parientes.Remove(pariente.Parientes.Where(x => x.Dni == parienteDTO.Dni).First());
                    pariente.Parientes.Remove(pariente.Parientes.Where(x => x.Dni == DniPariente).First());
                    pariente.Parientes.Insert(index, parienteDTO);

                    MessageBox.Show("El pariente se ha modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarPariente_Load(object sender, EventArgs e)
        {
            try
            {
                txtDni.Text = parienteDTO.Dni.ToString();
                txtNombre.Text = parienteDTO.Nombre;
                txtApellido.Text = parienteDTO.Apellido;
                txtDireccion.Text = parienteDTO.Direccion;
                txtMail.Text = parienteDTO.Mail;
                txtTelefono_1.Text = parienteDTO.Telefono1;
                txtTelefono_2.Text = parienteDTO.Telefono2;
                this.cmbParentezco.SelectedItem = parienteDTO.Parentezco;
                DniPariente = parienteDTO.Dni;

                if (nombreFormM == "frmModificarPaciente")
                {
                    txtDni.ReadOnly = true;
                }
            }
            catch (Exception ex)
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
