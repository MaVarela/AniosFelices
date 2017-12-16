using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRegistrarRecomendacionAlimentaria : Form
    {
        private IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        private IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        private IRepositorioHistoriaClinica repositorioHistoriaClinica = new RepositorioHistoriaClinica();
        private PacienteSeleccionado pacienteSeleccionado = PacienteSeleccionado.Instance();
        private UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();

        public frmRegistrarRecomendacionAlimentaria()
        {
            InitializeComponent();
            var usuarioLogueado = UsuarioLogueado.Instance();
            txtUsuario.Text = usuarioLogueado.Usuario.Apellido + " " + usuarioLogueado.Usuario.Nombre;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmPacientes frmPacientes = new frmPacientes();
                frmPacientes.ShowDialog();

                txtPaciente.Text = pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
                txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
                txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
            }
            catch (Exception ex)
            {
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                List<String> mensajes = new List<String>();

                if (String.IsNullOrEmpty(this.txtPaciente.Text.Trim()))
                    mensajes.Add("El campo 'Paciente' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtRecAlimentaria.Text.Trim()))
                    mensajes.Add("El campo 'Recomendación Alimentaria' es Obligatorio");

                if (mensajes.Count.Equals(0))
                {
                    HistoriaClinicaId idHistoriaClinica = new HistoriaClinicaId();
                    idHistoriaClinica.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                    idHistoriaClinica.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                    idHistoriaClinica.FechaVisita = System.DateTime.Today;

                    var recomendacionAlimentaria = repositorioHistoriaClinica.ObtenerPorUsuarioPacienteFecha(idHistoriaClinica).ToList();

                    if (recomendacionAlimentaria == null || recomendacionAlimentaria.Count() == 0
                        || (recomendacionAlimentaria.Where(x => x.FechaVisita.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) && !String.IsNullOrEmpty(x.RecomendacionAlimentaria))).Count() == 0)
                    {

                        if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            idHistoriaClinica.FechaVisita = System.DateTime.Now;
                            var recAlimentaria = new HistoriaClinica() { Id = idHistoriaClinica };
                            recAlimentaria.RecomendacionAlimentaria = txtRecAlimentaria.Text;
                            recAlimentaria = repositorioHistoriaClinica.Agregar(recAlimentaria);
                            MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Recomendación Alimentaria registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LogueadorErrores.Loguear(ex);
                MessageBox.Show("Ha ocurrido un error inesperado, revisar el log para más detalles", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region codigo viejo
            /*
            if (!String.IsNullOrEmpty(this.txtPaciente.Text))
            {
                if (!String.IsNullOrEmpty(this.txtRecAlimentaria.Text.Trim()) && txtRecAlimentaria.Text != "")
                {
                    IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();
                    HistoriaClinicaId idHistoriaClinica = new HistoriaClinicaId();
                    idHistoriaClinica.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                    idHistoriaClinica.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                    idHistoriaClinica.FechaVisita = System.DateTime.Today;

                    var recomendacionAlimentaria = repositorioHistoriaClinica.ObtenerPorUsuarioPacienteFecha(idHistoriaClinica).ToList();

                    if (recomendacionAlimentaria == null || recomendacionAlimentaria.Count() == 0
                        || (recomendacionAlimentaria.Where(x => x.FechaVisita.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) && !String.IsNullOrEmpty(x.RecomendacionAlimentaria))).Count() == 0)
                    {
                        
                        if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            idHistoriaClinica.FechaVisita = System.DateTime.Now;
                            var recAlimentaria = new HistoriaClinica() { Id = idHistoriaClinica };
                            recAlimentaria.RecomendacionAlimentaria = txtRecAlimentaria.Text;
                            recAlimentaria = repositorioHistoriaClinica.Agregar(recAlimentaria);
                            MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Recomendación Alimentaria registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("El campo 'Recomendación Alimentaria' es Obligatorio");
            }
            else
                MessageBox.Show("El campo 'Paciente' es Obligatorio");*/
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }
    }
}
