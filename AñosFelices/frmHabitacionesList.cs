using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmHabitacionesList : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        public frmHabitacionesList()
        {
            InitializeComponent();
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            var listado = mapper.LlenarListado((List<Habitacion>)repositorioHabitacion.ObtenerTodos());

            this.dgvHabitaciones.DataSource = listado;
        }

        private void btnSeleccionarCama_Click(object sender, System.EventArgs e)
        {
            if (this.dgvHabitaciones.CurrentRow != null)
            {
                if (this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString() == "A")
                {
                    var habitacionSeleccionada = HabitacionSeleccionada.Instance();
                    habitacionSeleccionada.Habitacion = new HabitacionDTO();

                    habitacionSeleccionada.Habitacion.Id = Convert.ToInt32(this.dgvHabitaciones.SelectedRows[0].Cells[0].Value);
                    habitacionSeleccionada.Habitacion.Categoria = this.dgvHabitaciones.SelectedRows[0].Cells[1].Value.ToString();
                    habitacionSeleccionada.Habitacion.Estado = this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString();

                    frmCamas frmCamas = new frmCamas();
                    frmCamas.ShowDialog();
                }
            }
        }
    }
}
