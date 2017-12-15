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
    public partial class frmListaHabitaciones : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        HabitacionSeleccionada habitacionSeleccionada = HabitacionSeleccionada.Instance();
        public frmListaHabitaciones()
        {
            InitializeComponent();
            cargarGrid();
        }

        void cargarGrid()
        {
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            try
            {
                var listado = mapper.LlenarListado((List<Habitacion>)repositorioHabitacion.ObtenerTodos());

                this.dgvHabitaciones.DataSource = listado;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.dgvHabitaciones.CurrentRow != null)
                {
                    if (this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString() == "Habilitada")
                    {
                        habitacionSeleccionada.HabitacionRecuperada = repositorioHabitacion.ObtenerPorId(Convert.ToInt32(this.dgvHabitaciones.SelectedRows[0].Cells[0].Value));

                        this.btnModificar.Enabled = false;
                        frmModificarHabitacion frmModificarHabitacion = new frmModificarHabitacion();
                        frmModificarHabitacion.ShowDialog();
                        this.btnModificar.Enabled = true;
                        cargarGrid();
                        configurarHabilitarModificar();
                        habitacionSeleccionada.HabitacionRecuperada = null;
                    }
                    else
                        MessageBox.Show("La Habitación seleccionada se encuentra inhabilitada. Seleccione otra.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habitacionSeleccionada.HabitacionRecuperada = null;
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvHabitaciones.CurrentRow != null)
                {
                    var habitacion = repositorioHabitacion.ObtenerPorId(Convert.ToInt32(dgvHabitaciones.SelectedRows[0].Cells[0].Value));

                    habitacion = repositorioHabitacion.Habilitar(habitacion);
                    MessageBox.Show("La habitación ha sido habilitada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrid();
                    configurarHabilitarModificar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configurarHabilitarModificar()
        {
            try
            {
                btnModificar.Enabled = dgvHabitaciones.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitada";
                btnHabilitar.Enabled = !(dgvHabitaciones.CurrentRow.Cells["Estado"].Value.ToString() == "Habilitada");
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaHabitaciones_Load(object sender, EventArgs e)
        {
            configurarHabilitarModificar();
        }

        private void dgvHabitaciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            configurarHabilitarModificar();
        }
    }
}
