﻿using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace AñosFelices
{
    public partial class frmHabitacionesList : Form
    {
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        public frmHabitacionesList(String sexo)
        {
            InitializeComponent();
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            var listado = mapper.LlenarListadoSexo(repositorioHabitacion.ObtenerTodos().Where(x => x.Estado == "A" && x.Camas.Where(y => y.Estado == "L").Count() > 0).ToList(), sexo);

            this.dgvHabitaciones.DataSource = listado;
        }

        private void btnSeleccionarCama_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.dgvHabitaciones.CurrentRow != null)
                {
                    if (this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString() == "Habilitada")
                    {
                        var habitacionSeleccionada = HabitacionSeleccionada.Instance();
                        var camaSeleccionada = CamaSeleccionada.Instance();
                        habitacionSeleccionada.Habitacion = new HabitacionDTO();

                        habitacionSeleccionada.Habitacion.Id = Convert.ToInt32(this.dgvHabitaciones.SelectedRows[0].Cells[0].Value);
                        habitacionSeleccionada.Habitacion.Categoria = this.dgvHabitaciones.SelectedRows[0].Cells[1].Value.ToString();
                        habitacionSeleccionada.Habitacion.Estado = this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString();
                        this.btnSeleccionarCama.Enabled = false;
                        frmCamas frmCamas = new frmCamas();
                        frmCamas.ShowDialog();
                        this.btnSeleccionarCama.Enabled = true;
                        if (camaSeleccionada.Cama != null)
                            this.Close();
                    }
                    else
                        MessageBox.Show("La Habitación seleccionada no se encuentra disponible. Seleccione otra.", "Error",
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
            this.Close();
        }
    }
}
