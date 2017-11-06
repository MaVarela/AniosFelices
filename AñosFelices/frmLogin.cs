using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmLogin : Form
    {
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public frmLogin()
        {
            InitializeComponent();
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
                        VariablesGlobales.dniUsuario = txtDni.Text;
                        VariablesGlobales.apellidoUsuario = usuario.Apellido;
                        VariablesGlobales.nombreUsuario = usuario.Nombre;
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
    }
}
