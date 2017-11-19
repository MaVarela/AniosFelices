using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
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
    public partial class frmModificarPariente : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        int index;
        ParienteDTO parienteM = new ParienteDTO();
        String nombreFormM;
        public frmModificarPariente(int index, ParienteDTO parienteDTO, String nombreForm)
        {
            InitializeComponent();
            this.index = index;
            this.parienteM = parienteDTO;
            this.nombreFormM = nombreForm;
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
                                    if (MessageBox.Show("¿Está seguro de que desea Modificar el Registro?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

                                        if (nombreFormM == "frmListadoParientes")
                                        {
                                            var Pariente = new Pariente();
                                            var pacienteSeleccionado = PacienteSeleccionado.Instance();

                                            ParienteDTOMapper mapper = new ParienteDTOMapper();
                                            var listado = mapper.LlenarListadoPersist(pariente.Parientes, pacienteSeleccionado.Paciente);

                                            foreach (var registro in listado)
                                            {
                                                Pariente.Id = registro.Id;
                                                Pariente.DniPariente = registro.DniPariente;
                                                Pariente.Apellido = registro.Apellido;
                                                Pariente.Nombre = registro.Nombre;
                                                Pariente.Direccion = registro.Direccion;
                                                Pariente.Telefono1 = registro.Telefono1;
                                                Pariente.Telefono2 = registro.Telefono2;
                                                Pariente.Mail = registro.Mail;
                                                Pariente.Parentezco = registro.Parentezco;
                                                Pariente.Paciente = registro.Paciente;
                                                Pariente.Estado = registro.Estado;

                                                repositorioPariente.Editar(Pariente);
                                            }
                                        }
                                        MessageBox.Show("Registro Modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (nombreFormM == "frmListadoParientes")
            {
                txtDni.ReadOnly = true;
            }
        }
    }
}
