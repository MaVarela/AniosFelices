using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace AñosFelices
{
    public partial class frmCamas : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        public frmCamas()
        {
            InitializeComponent();
            var habitacionSeleccionada = HabitacionSeleccionada.Instance();
            var habitacion = repositorioHabitacion.ObtenerPorId(habitacionSeleccionada.Habitacion.Id);

            CamaDTOMapper mapper = new CamaDTOMapper();
            
            var listado = mapper.LlenarListado((List<Cama>)habitacion.Camas.ToList());
            this.dgvCamas.DataSource = listado;
        }
    }
}
