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
    public partial class frmRegistrarRecomendacionMedicacion : Form
    {
        private IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        private IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        private IRepositorioHistoriaClinica repositorioHistoriaClinica = new RepositorioHistoriaClinica();
        private PacienteSeleccionado pacienteSeleccionado = PacienteSeleccionado.Instance();
        private UsuarioLogueado usuarioLogueado = UsuarioLogueado.Instance();

        public frmRegistrarRecomendacionMedicacion()
        {
            InitializeComponent();
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
                if (String.IsNullOrEmpty(this.txtMedicacion.Text.Trim()))
                    mensajes.Add("El campo 'Medicación' es Obligatorio");

                if (mensajes.Count.Equals(0))
                {
                    HistoriaClinicaId idHistoriaClinica = new HistoriaClinicaId();
                    idHistoriaClinica.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                    idHistoriaClinica.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                    idHistoriaClinica.FechaVisita = System.DateTime.Today;

                    var mediacionRecomendada = repositorioHistoriaClinica.ObtenerPorUsuarioPacienteFecha(idHistoriaClinica);

                    if (mediacionRecomendada == null || mediacionRecomendada.Count() == 0
                        || (mediacionRecomendada.Where(x => x.FechaVisita.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) && !String.IsNullOrEmpty(x.MedicacionRecomendada))).Count() == 0)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            idHistoriaClinica.FechaVisita = System.DateTime.Now;
                            var medicacion = new HistoriaClinica() { Id = idHistoriaClinica };
                            medicacion.MedicacionRecomendada = txtMedicacion.Text;
                            medicacion = repositorioHistoriaClinica.Agregar(medicacion);
                            MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medicación registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!String.IsNullOrEmpty(this.txtMedicacion.Text.Trim()) && txtMedicacion.Text != "")
                {
                    HistoriaClinicaId idHistoriaClinica = new HistoriaClinicaId();
                    idHistoriaClinica.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                    idHistoriaClinica.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                    idHistoriaClinica.FechaVisita = System.DateTime.Today;

                    var mediacionRecomendada = repositorioHistoriaClinica.ObtenerPorUsuarioPacienteFecha(idHistoriaClinica);

                    if (mediacionRecomendada == null || mediacionRecomendada.Count() == 0
                        || (mediacionRecomendada.Where(x => x.FechaVisita.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) && !String.IsNullOrEmpty(x.MedicacionRecomendada))).Count() == 0)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            idHistoriaClinica.FechaVisita = System.DateTime.Now;
                            var medicacion = new HistoriaClinica() { Id = idHistoriaClinica };
                            medicacion.MedicacionRecomendada = txtMedicacion.Text;
                            medicacion = repositorioHistoriaClinica.Agregar(medicacion);
                            MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medicación registrada con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("El campo 'Medicación' es Obligatorio");
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
