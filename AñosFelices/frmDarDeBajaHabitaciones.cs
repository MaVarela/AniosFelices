using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
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
    public partial class frmDarDeBajaHabitaciones : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();

        public frmDarDeBajaHabitaciones()
        {
            InitializeComponent();
            cargar();
        }

        private void cargar()
        {
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            var listado = mapper.LlenarListado(repositorioHabitacion.ObtenerTodos().Where(x => x.Estado == "A").ToList());

            this.dgvHabitaciones.DataSource = listado;
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (this.dgvHabitaciones.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea dar de Baja el Registro?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var habitacion = repositorioHabitacion.ObtenerPorId(Convert.ToInt32(dgvHabitaciones.SelectedRows[0].Cells[0].Value));

                    if (habitacion.Camas.Where(x => x.Estado == "O").Count() == 0)
                    {
                        repositorioHabitacion.Inhabilitar(habitacion);
                        MessageBox.Show("Registro Dado de Baja Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar();
                    }
                    else
                        MessageBox.Show("No se puede dar de baja una habitación con pacientes asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
