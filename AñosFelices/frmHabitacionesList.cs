﻿using AñosFelices.AccesoADatos.IRepositorios;
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
        public frmHabitacionesList(String sexo)
        {
            InitializeComponent();
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            //var listado = mapper.LlenarListado((List<Habitacion>)repositorioHabitacion.ObtenerTodos());
            var listado = mapper.LlenarListadoSexo((List<Habitacion>)repositorioHabitacion.ObtenerTodos(), sexo);

            this.dgvHabitaciones.DataSource = listado;
        }

        private void btnSeleccionarCama_Click(object sender, System.EventArgs e)
        {
            if (this.dgvHabitaciones.CurrentRow != null)
            {
                if (this.dgvHabitaciones.CurrentRow.Cells[2].Value.ToString() == "A")
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
                    MessageBox.Show("La Habitación seleccionada no se encuentra Disponible. Seleccione otra.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
