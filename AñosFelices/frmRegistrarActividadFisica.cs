﻿using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRegistrarActividadFisica : Form
    {
        PacienteSeleccionado pacienteSeleccionado = PacienteSeleccionado.Instance();
        UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();
        IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();

        public frmRegistrarActividadFisica()
        {
            InitializeComponent();
        }

        private void frmRegistrarActividadFisica_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            txtUsuario.Text = usuarioLogueado.Usuario.Apellido + " " + usuarioLogueado.Usuario.Nombre;
            cargarCmbTurno();
        }

        private void cargarCmbTurno()
        {
            cmbTurno.Items.Add("Diurno");
            cmbTurno.Items.Add("Vespertino");
            cmbTurno.SelectedIndex = 0;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmPacientes frmPacientes = new frmPacientes();
                frmPacientes.ShowDialog();

                if (pacienteSeleccionado.Paciente != null)
                {
                    txtPaciente.Text = pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
                    txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
                    txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> mensajes = new List<String>();

                if (String.IsNullOrEmpty(this.txtPaciente.Text.Trim()))
                    mensajes.Add("El campo 'Paciente' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtActividad.Text.Trim()))
                    mensajes.Add("El campo 'Actividad Física Realizada' es Obligatorio");

                if (mensajes.Count.Equals(0))
                {
                    var turno = this.cmbTurno.Text + ", Comida";
                    var existe = repositorioLibroDeGuardias.Existe(pacienteSeleccionado.Paciente, turno, "ActividadRealizada");

                    if (!existe)
                    {
                        var actividad = new LibroDeGuardias();
                        actividad.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                        actividad.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                        actividad.Turno = turno;
                        actividad.Fecha = dtpFecha.Value.Date;
                        actividad.ActividadRealizada = txtActividad.Text.Trim();
                        actividad = repositorioLibroDeGuardias.Agregar(actividad);
                        MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pacienteSeleccionado.Paciente = null;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Actividad Física registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var mensaje in mensajes)
                    {
                        sb.AppendLine(mensaje);
                    }

                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }

            #region codigo viejo
            /*
            if (!String.IsNullOrEmpty(this.txtPaciente.Text))
            {
                if (!String.IsNullOrEmpty(this.txtActividad.Text.Trim()) && txtActividad.Text != "")
                {
                    //LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();
                    //idLibroGuardias.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                    //idLibroGuardias.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                    //idLibroGuardias.Turno = this.cmbTurno.Text + ", Actividad Física";
                    var turno = this.cmbTurno.Text + ", Actividad Física";
                    var existe = repositorioLibroDeGuardias.Existe(pacienteSeleccionado.Paciente, turno, "ComidaRealizada");

                    if (!existe)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            var actividadFisica = new LibroDeGuardias();
                            actividadFisica.Fecha = dtpFecha.Value.Date;
                            actividadFisica.ActividadRealizada = txtActividad.Text.Trim();
                            actividadFisica = repositorioLibroDeGuardias.Agregar(actividadFisica);
                            MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Actividad Física registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("El campo 'Actividad Física Realizada' es Obligatorio");
            }
            else
                MessageBox.Show("El campo 'Paciente' es Obligatorio"); */
            #endregion
        }
    }
}
