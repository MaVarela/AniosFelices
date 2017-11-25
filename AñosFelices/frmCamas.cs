using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using AñosFelices.DTOs;
using System;

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

        private void btnSeleccionarCama_Click(object sender, System.EventArgs e)
        {
            if (this.dgvCamas.CurrentRow != null)
            {
                if (this.dgvCamas.CurrentRow.Cells[2].Value.ToString() == "Libre")
                {
                    var camaSeleccionada = CamaSeleccionada.Instance();
                    camaSeleccionada.Cama = new CamaDTO();

                    camaSeleccionada.Cama.IdCama = Convert.ToInt32(this.dgvCamas.SelectedRows[0].Cells[0].Value);
                    camaSeleccionada.Cama.IdHabitacion = Convert.ToInt32(this.dgvCamas.SelectedRows[0].Cells[1].Value);
                    camaSeleccionada.Cama.Estado = this.dgvCamas.CurrentRow.Cells[2].Value.ToString();
                    this.btnSeleccionarCama.Enabled = false;
                    
                    this.Close();
                }
                else
                    MessageBox.Show("La Cama seleccionada no se encuentra disponible. Seleccione otra.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
