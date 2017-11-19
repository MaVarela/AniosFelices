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
            if(!String.IsNullOrEmpty(this.txtDni.Text.Trim()) && txtDni.Text != "")
            {
                if (!String.IsNullOrEmpty(this.txtApe_Pariente.Text.Trim()) && txtApe_Pariente.Text != "")
                {
                    if (!String.IsNullOrEmpty(this.txtNom_Pariente.Text.Trim()) && txtNom_Pariente.Text != "")
                    {
                        if (!String.IsNullOrEmpty(this.txtParentezco.Text.Trim()) && txtParentezco.Text != "")
                        { 
                            if (!String.IsNullOrEmpty(this.mkdTel_1.Text) && mkdTel_1.Text != "")
                            {
                                if (!String.IsNullOrEmpty(this.txtDireccion.Text.Trim()) && txtDireccion.Text != "")
                                {
                                    if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        var pariente = ParienteSeleccionado.Instance();
                                        var parienteDTO = new ParienteDTO();

                                        if (pariente.Parientes == null)
                                        {
                                            pariente.Parientes = new List<ParienteDTO>();
                                        }
                                        parienteDTO.Dni = Convert.ToInt32(txtDni.Text.Trim());
                                        parienteDTO.Nombre = txtNom_Pariente.Text.Trim();
                                        parienteDTO.Apellido = txtApe_Pariente.Text.Trim();
                                        parienteDTO.Direccion = txtDireccion.Text.Trim();
                                        parienteDTO.Mail = txtMail.Text.Trim();
                                        parienteDTO.Telefono1 = mkdTel_1.Text.Trim();
                                        parienteDTO.Telefono2 = mkdTel_2.Text.Trim();
                                        parienteDTO.Parentezco = txtParentezco.Text.Trim();

                                        pariente.Parientes.Add(parienteDTO);

                                        this.Close();
                                    }
                                }
                                else
                                    MessageBox.Show("El campo 'Dirección' es Obligatorio");
                            }
                            else
                                MessageBox.Show("El campo 'Teléfono 1' es Obligatorio");
                        }
                        else
                            MessageBox.Show("El campo 'Parentezco' es Obligatorio");
                    }
                    else
                        MessageBox.Show("El campo 'Nombre' es Obligatorio");
                }
                else
                    MessageBox.Show("El campo 'Apellido' es Obligatorio");
            }
            else
                MessageBox.Show("El campo 'Dni' es Obligatorio");
            

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


