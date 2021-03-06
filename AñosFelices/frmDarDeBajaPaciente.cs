﻿using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
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
    public partial class frmDarDeBajaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente;
        IRepositorioPariente repositorioPariente;
        IRepositorioCama repositorioCama;
        public frmDarDeBajaPaciente()
        {
            InitializeComponent();
            repositorioPaciente = new RepositorioPaciente();
            repositorioPariente = new RepositorioPariente();
            repositorioCama = new RepositorioCama();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.RowCount > 0)
                {
                    String estado = dgvPacientes.SelectedRows[0].Cells["Estado"].Value.ToString();
                    if (MessageBox.Show("¿Está seguro de que desea dar de Baja el Registro?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Paciente paciente = new Paciente();

                        paciente.Dni = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["Dni"].Value);

                        paciente = repositorioPaciente.ObtenerPorId(paciente.Dni);

                        foreach (var pariente in paciente.Parientes)
                        {
                            repositorioPariente.Inhabilitar(pariente);
                        }
                        paciente.Cama.Estado = "L";
                        repositorioCama.Editar(paciente.Cama);
                        paciente.Cama = null;
                        repositorioPaciente.Inhabilitar(paciente);
                        MessageBox.Show("Registro Dado de Baja Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar();
                    }
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
            finally
            {
                
            }
        }

        private void frmDarDeBajaPaciente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();
            var listado = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.ObtenerTodos()).Where(x => x.Estado == "Habilitado").ToList();

            this.dgvPacientes.DataSource = listado;
            this.dgvPacientes.Columns["Dni"].DisplayIndex = 0;
            this.dgvPacientes.Columns["Apellido"].DisplayIndex = 1;
            this.dgvPacientes.Columns["Nombre"].DisplayIndex = 2;
            this.dgvPacientes.Columns["EstadoFisico"].DisplayIndex = 3;
            this.dgvPacientes.Columns["Habitacion"].DisplayIndex = 4;
            this.dgvPacientes.Columns["Cama"].DisplayIndex = 5;
            this.dgvPacientes.Columns["FechaIngreso"].DisplayIndex = 6;
            this.dgvPacientes.Columns["Estado"].DisplayIndex = 7;
            this.dgvPacientes.Columns["Sexo"].Visible = false;
            this.dgvPacientes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
        }
    }
}
