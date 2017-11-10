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
    public partial class frmAgregarPariente : Form
    {
        public frmAgregarPariente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    var nombrePariente = NombrePariente.Instance();
        //    this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNom_Pariente.Text = null;
            txtApe_Pariente.Text = null;
            txtDireccion.Text = null;
            txtParentezco.Text = null;
            txtMail.Text = null;
            mkdTel_1.Text = null;
            mkdTel_2.Text = null;
            this.Close();
        }
    }
}



