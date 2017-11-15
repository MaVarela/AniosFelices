using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.Utilidades;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AñosFelices
{
    public partial class frmLogin : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();

        public frmLogin()
        {
            InitializeComponent();
           var usuarioLogueado = UsuarioLogueado.Instance();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.txtDni.Text))
            {
                if (!String.IsNullOrEmpty(this.txtPass.Text))
                {
                    var usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(this.txtDni.Text));
                    if (usuario != null && usuario.Password == txtPass.Text)
                    {
                        
                        usuarioLogueado.Usuario = usuario;

                        this.Close();
                    }
                    else
                        MessageBox.Show("Usuario o Password inválidos");
                }
                else
                    MessageBox.Show("El campo 'Password' es Obligatorio");
            }
            else
                MessageBox.Show("El campo 'Dni' es Obligatorio");
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
    }
}
