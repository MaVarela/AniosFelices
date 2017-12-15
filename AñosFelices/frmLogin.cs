using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmLogin : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> mensajes = new List<String>();
                int dni = 0;
                if (String.IsNullOrEmpty(this.txtPass.Text.Trim()))
                    mensajes.Add("El campo 'Password' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtDni.Text.Trim()))
                    mensajes.Add("El campo 'Dni' es Obligatorio");
                else if (!Int32.TryParse(this.txtDni.Text, out dni))
                {
                    mensajes.Add("El campo 'Dni' debe ser solo numérico");
                }
                if (mensajes.Count.Equals(0))
                {
                    var usuario = repositorioUsuario.ObtenerPorId(dni);
                    if (usuario != null && usuario.Password == txtPass.Text)
                    {
                        usuarioLogueado.Usuario = usuario;

                        this.Close();
                    }
                    else
                        MessageBox.Show("Usuario o Password inválidos");
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
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Enter = (char)13;
            if (e.KeyChar == Enter)
                btnAceptar_Click(sender, e);
        }
    }
}
