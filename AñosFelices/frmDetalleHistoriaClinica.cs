using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTOs.DTOMappers;
using System.Text.RegularExpressions;
using System.Text;
namespace AñosFelices
{
    public partial class frmDetalleHistoriaClinica : Form
    {
        HistoriaClinicaSeleccionada historiaclinicaSeleccionada;
        public frmDetalleHistoriaClinica()
        {
            InitializeComponent();
            historiaclinicaSeleccionada = HistoriaClinicaSeleccionada.Instance();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            historiaclinicaSeleccionada.HistoriaClinica = null;
            this.Close();
        }

        private void frmDetalleHistoriaClinica_Load(object sender, System.EventArgs e)
        {
            try
            {
                txtDni.Text = historiaclinicaSeleccionada.HistoriaClinica.Paciente.Dni.ToString();
                txtNombre.Text = historiaclinicaSeleccionada.HistoriaClinica.Paciente.Nombre;
                txtApellido.Text = historiaclinicaSeleccionada.HistoriaClinica.Paciente.Apellido;
                txtUsuario.Text = historiaclinicaSeleccionada.HistoriaClinica.Usuario.Dni.ToString();
                txtFechavisita.Text = historiaclinicaSeleccionada.HistoriaClinica.FechaVisita.ToString();
                rtxtEstado.Text = historiaclinicaSeleccionada.HistoriaClinica.EstadoGeneral;
                rtxtMedicacion.Text = historiaclinicaSeleccionada.HistoriaClinica.MedicacionRecomendada;
                rtxtActivFisica.Text = historiaclinicaSeleccionada.HistoriaClinica.RecomendacionActividadFisica;
                rtxtAlimentacion.Text = historiaclinicaSeleccionada.HistoriaClinica.RecomendacionAlimentaria;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
