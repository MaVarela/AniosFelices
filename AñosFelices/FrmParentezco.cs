using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTOs;
namespace AñosFelices
{
    
    public partial class FrmParentezco : Form
    {
       
        ParienteSeleccionado parienteSeleccionado;
       
        public FrmParentezco()
        {
            InitializeComponent();
            parienteSeleccionado = ParienteSeleccionado.Instance();
            txtDni.Text = parienteSeleccionado.Pariente.Dni.ToString();
            txtNombre.Text = parienteSeleccionado.Pariente.Nombre;
            txtApellido.Text = parienteSeleccionado.Pariente.Apellido;
            txtDireccion.Text = parienteSeleccionado.Pariente.Direccion;
            txtTelefono_1.Text = parienteSeleccionado.Pariente.Telefono1;
            txtTelefono_2.Text = parienteSeleccionado.Pariente.Telefono2;
            txtMail.Text = parienteSeleccionado.Pariente.Mail;
            txtDireccion.Text = parienteSeleccionado.Pariente.Direccion;

            cmbParentezco.Items.Add("Esposo");
            cmbParentezco.Items.Add("Esposa");
            cmbParentezco.Items.Add("Hijo");
            cmbParentezco.Items.Add("Hija");
            cmbParentezco.Items.Add("Hermano");
            cmbParentezco.Items.Add("Primo");
            cmbParentezco.Items.Add("Prima");
            cmbParentezco.Items.Add("Tío");
            cmbParentezco.Items.Add("Tía");
            cmbParentezco.Items.Add("Sobrino");
            cmbParentezco.Items.Add("Sobrina");
            cmbParentezco.Items.Add("Nieto");
            cmbParentezco.Items.Add("Nieta");

            cmbParentezco.SelectedItem = parienteSeleccionado.Pariente.Parentezco;
        }

        private void FrmParentezco_Load(object sender, EventArgs e)
        {
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            parienteSeleccionado.Pariente = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
