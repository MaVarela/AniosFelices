using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;
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
    public partial class frmAgregarPariente : Form
    {
        public frmAgregarPariente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pariente = ParienteSeleccionado.Instance();
            pariente.Pariente = new ParienteDTO();

            if (pariente.Pariente == null)
            {
                pariente.Pariente.Dni = Convert.ToInt32(txtDni.Text.Trim());
                pariente.Pariente.Nombre = txtNom_Pariente.Text.Trim();
                pariente.Pariente.Apellido = txtApe_Pariente.Text.Trim();
                pariente.Pariente.Direccion = txtDireccion.Text.Trim();
                pariente.Pariente.Mail = txtMail.Text.Trim();
                pariente.Pariente.Telefono1 = mkdTel_1.Text.Trim();
                pariente.Pariente.Telefono2 = mkdTel_2.Text.Trim();
                pariente.Pariente.Parentezco = txtParentezco.Text.Trim();

                //pariente.Pariente = new List<ParienteDTO>;

            }

            

            this.Close();

            /*var Paciente = PacienteSeleccionado.Instance();

            ParienteId parienteId = new ParienteId();
            parienteId.Paciente.Dni = Paciente.Paciente.Dni;
            parienteId.DniPariente = Convert.ToInt32(txtDni.Text);

            Pariente pariente = new Pariente() { Id = parienteId };

            pariente.Nombre = txtNom_Pariente.Text;
            pariente.Apellido = txtApe_Pariente.Text;
            pariente.Direccion = txtDireccion.Text;
            pariente.Mail = txtMail.Text;
            pariente.Telefono1 = mkdTel_1.Text;
            pariente.Telefono2 = mkdTel_2.Text;
            pariente.Parentezco = txtParentezco.Text;
            this.Close();*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



