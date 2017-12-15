using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.Utilidades;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using AñosFelices.DTOs.DTOMappers;
using System;
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmModificarHabitacion : Form
    {
        CamasSeleccionadas camasSeleccionadas = CamasSeleccionadas.Instance();
        HabitacionSeleccionada habitacionSeleccionada = HabitacionSeleccionada.Instance();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();

        public frmModificarHabitacion()
        {
            InitializeComponent();
            try
            {
                this.txtNroHabitacion.Text = habitacionSeleccionada.HabitacionRecuperada.IdHabitacion.ToString();
                txtEstado.Text = habitacionSeleccionada.HabitacionRecuperada.Estado == "A" ? "Habilitada" : "Inhabilitada";
                cargarCmbCategorias();
                CamaDTOMapper mapper = new CamaDTOMapper();
                camasSeleccionadas.Camas = mapper.LlenarListado(habitacionSeleccionada.HabitacionRecuperada.Camas.ToList());
                cargarGrid();
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarGrid()
        {
            try
            {
                if (camasSeleccionadas.Camas == null)
                    camasSeleccionadas.Camas = new List<CamaDTO>();

                CamaDTOMapper mapper = new CamaDTOMapper();
                var listado = mapper.LlenarListado(camasSeleccionadas.Camas);

                this.dgvCamas.DataSource = listado;

                this.dgvCamas.Columns["IdCama"].DisplayIndex = 0;
                this.dgvCamas.Columns["IdCama"].HeaderText = "Nro. Cama";
                this.dgvCamas.Columns["IdCama"].ReadOnly = false;
                this.dgvCamas.Columns["Estado"].DisplayIndex = 1;
                this.dgvCamas.Columns["Estado"].ReadOnly = true; ;
                this.dgvCamas.Columns["IdHabitacion"].Visible = false;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarCmbCategorias()
        {
            try
            {
                cmbCategoria.Items.Add("Hombres - Independientes");
                cmbCategoria.Items.Add("Mujeres - Inependientes");
                cmbCategoria.Items.Add("Hombres - Medianamente Dependientes");
                cmbCategoria.Items.Add("Mujeres - Medianamente Dependientes");
                cmbCategoria.Items.Add("Hombres - Dependientes");
                cmbCategoria.Items.Add("Mujeres - Dependientes");
                cmbCategoria.SelectedItem = habitacionSeleccionada.HabitacionRecuperada.Categoria;
                cmbCategoria.Enabled = false;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var cama = new CamaDTO();
                if (camasSeleccionadas.Camas == null)
                    camasSeleccionadas.Camas = new List<CamaDTO>();
                if (camasSeleccionadas.Camas.Count() == 0)
                {
                    cama.IdCama = 1;
                    cama.Estado = "Libre";
                    camasSeleccionadas.Camas.Add(cama);
                }
                else if (camasSeleccionadas.Camas.Count() < 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (camasSeleccionadas.Camas.Where(x => x.IdCama == i + 1).Count() == 0)
                        {
                            cama.IdCama = i + 1;
                            break;
                        }
                    }
                    cama.Estado = "Libre";
                    camasSeleccionadas.Camas.Add(cama);
                }
                else
                {
                    MessageBox.Show("Solo se pueden agregar 5 camas por habitación.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CamaDTOMapper mapper = new CamaDTOMapper();
                var listado = mapper.LlenarListado(camasSeleccionadas.Camas);

                this.dgvCamas.DataSource = listado;
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            camasSeleccionadas.Camas = null;
            habitacionSeleccionada.HabitacionRecuperada = null;
            this.Close();
        }

        private void btnRemover_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dgvCamas.CurrentRow != null)
                {
                    var cama = new CamaDTO();
                    cama.IdCama = Convert.ToInt16(dgvCamas.SelectedRows[0].Cells[0].Value);
                    if (camasSeleccionadas.Camas.Count() > 1)
                    {
                        if (dgvCamas.SelectedRows[0].Cells[2].Value.ToString() == "Libre")
                            camasSeleccionadas.Camas.Remove(camasSeleccionadas.Camas.Where(x => x.IdCama == cama.IdCama).First());
                        else
                            MessageBox.Show("No se puede remover una cama ocupada.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La habitación debe poseer al menos una cama.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CamaDTOMapper mapper = new CamaDTOMapper();
                    var listado = mapper.LlenarListado(camasSeleccionadas.Camas);

                    this.dgvCamas.DataSource = listado;
                }
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    CamaDTOMapper mapper = new CamaDTOMapper();
                    var listado = mapper.LlenarListadoBe(camasSeleccionadas.Camas);

                    habitacionSeleccionada.HabitacionRecuperada.Categoria = cmbCategoria.SelectedItem.ToString();


                    foreach (var cama in listado)
                    {
                        cama.Habitacion = habitacionSeleccionada.HabitacionRecuperada;
                    }

                    habitacionSeleccionada.HabitacionRecuperada.Camas.Clear();
                    foreach (var cama in listado)
                    {
                        habitacionSeleccionada.HabitacionRecuperada.Camas.Add(cama);
                    }

                    habitacionSeleccionada.HabitacionRecuperada = repositorioHabitacion.Editar(habitacionSeleccionada.HabitacionRecuperada);
                    txtNroHabitacion.Text = habitacionSeleccionada.HabitacionRecuperada.IdHabitacion.ToString();
                    MessageBox.Show("Registro Modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    camasSeleccionadas.Camas = null;
                    habitacionSeleccionada.HabitacionRecuperada = null;
                    this.Close();
                }
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
