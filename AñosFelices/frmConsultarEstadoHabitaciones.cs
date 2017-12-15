using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmConsultarEstadoHabitaciones : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();

        public frmConsultarEstadoHabitaciones()
        {
            InitializeComponent();
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            try
            {
                var listado = mapper.LlenarListadoConsultaEstado((List<Habitacion>)repositorioHabitacion.ObtenerTodos());

                this.dgvHabitaciones.DataSource = listado;
                this.dgvHabitaciones.Columns["Id"].Width = 80;
                this.dgvHabitaciones.Columns["Id"].HeaderText = "Nro. Habitación";
                this.dgvHabitaciones.Columns["Categoria"].Width = 200;
                this.dgvHabitaciones.Columns["Estado"].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
