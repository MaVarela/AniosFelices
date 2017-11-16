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
    public partial class frmAltaHabitacion : Form
    {
        CamasSeleccionadas camasSeleccionadas = CamasSeleccionadas.Instance();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();

        public frmAltaHabitacion()
        {
            InitializeComponent();
            txtEstado.Text = "Disponible";
            cargarCmbCategorias();
            cargarGrid();
        }

        private void cargarGrid()
        {
            var cama = new CamaDTO();
            if (camasSeleccionadas.Camas == null)
                camasSeleccionadas.Camas = new List<CamaDTO>();
            if (camasSeleccionadas.Camas.Count() == 0)
            {
                cama.IdCama = 1;
                cama.Estado = "Libre";
            }
            camasSeleccionadas.Camas.Add(cama);
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

        private void cargarCmbCategorias()
        {
            cmbCategoria.Items.Add("Hombres - Independientes");
            cmbCategoria.Items.Add("Mujeres - Inependientes");
            cmbCategoria.Items.Add("Hombres - Medianamente Dependientes");
            cmbCategoria.Items.Add("Mujeres - Medianamente Dependientes");
            cmbCategoria.Items.Add("Hombres - Dependientes");
            cmbCategoria.Items.Add("Mujeres - Dependientes");
            cmbCategoria.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
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
            else if (camasSeleccionadas.Camas.Count() < 10)
            {
                cama.IdCama = camasSeleccionadas.Camas.Max(x => x.IdCama) + 1;
                cama.Estado = "Libre";
                camasSeleccionadas.Camas.Add(cama);
            }
            else
            {
                MessageBox.Show("Solo se pueden agregar 10 camas por habitación.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CamaDTOMapper mapper = new CamaDTOMapper();
            var listado = mapper.LlenarListado(camasSeleccionadas.Camas);

            this.dgvCamas.DataSource = listado;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            camasSeleccionadas.Camas = null;
            this.Close();
        }

        private void btnRemover_Click(object sender, System.EventArgs e)
        {
            if (dgvCamas.CurrentRow != null)
            {
                var cama = new CamaDTO();
                cama.IdCama = Convert.ToInt16(dgvCamas.SelectedRows[0].Cells[0].Value);
                if (camasSeleccionadas.Camas.Count() > 1)
                    camasSeleccionadas.Camas.Remove(camasSeleccionadas.Camas.Where(x => x.IdCama == cama.IdCama).First());
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                CamaDTOMapper mapper = new CamaDTOMapper();
                var listado = mapper.LlenarListadoBe(camasSeleccionadas.Camas);

                Habitacion habitacion = new Habitacion();
                habitacion.Categoria = cmbCategoria.Text;

                foreach (var cama in listado)
                {
                    cama.Habitacion = habitacion;
                }

                habitacion.Camas = listado;

                habitacion = repositorioHabitacion.Agregar(habitacion);
                txtNroHabitacion.Text = habitacion.IdHabitacion.ToString();
                MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                camasSeleccionadas.Camas = null;
                this.Close();
            }
        }

        private void dgvCamas_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
