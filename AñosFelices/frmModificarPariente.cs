using AñosFelices.DTOs;
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
    public partial class frmModificarPariente : Form
    {
        int index;
        ParienteDTO parienteM = new ParienteDTO();
        public frmModificarPariente(int index, ParienteDTO parienteDTO)
        {
            InitializeComponent();
            this.index = index;
            this.parienteM = parienteDTO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pariente = ParienteSeleccionado.Instance();
            var parienteDTO = new ParienteDTO();

            parienteDTO.Dni = Convert.ToInt32(txtDni.Text.Trim());
            parienteDTO.Nombre = txtNom_Pariente.Text.Trim();
            parienteDTO.Apellido = txtApe_Pariente.Text.Trim();
            parienteDTO.Direccion = txtDireccion.Text.Trim();
            parienteDTO.Mail = txtMail.Text.Trim();
            parienteDTO.Telefono1 = mkdTel_1.Text.Trim();
            parienteDTO.Telefono2 = mkdTel_2.Text.Trim();
            parienteDTO.Parentezco = txtParentezco.Text.Trim();

            pariente.Parientes.Remove(pariente.Parientes.Where(x => x.Dni == parienteM.Dni).First());
            pariente.Parientes.Insert(index, parienteDTO);

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

        private void frmModificarPariente_Load(object sender, EventArgs e)
        {
            txtDni.Text = parienteM.Dni.ToString();
            txtNom_Pariente.Text = parienteM.Nombre;
            txtApe_Pariente.Text = parienteM.Apellido;
            txtDireccion.Text = parienteM.Direccion;
            txtMail.Text = parienteM.Mail;
            mkdTel_1.Text = parienteM.Telefono1;
            mkdTel_2.Text = parienteM.Telefono2;
            txtParentezco.Text = parienteM.Parentezco;
        }
    }
}
