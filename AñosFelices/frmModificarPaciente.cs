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
    public partial class frmModificarPaciente : Form
    {
        public frmModificarPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = null;
            txtCama.Text = null;
            txtNombre.Text = null;
            txtEstadoFisico.Text = null;
            txtHabitacion.Text = null;
            this.Close();
        }
    }
}
