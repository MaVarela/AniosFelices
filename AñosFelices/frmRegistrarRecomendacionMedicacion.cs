using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Linq;
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
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();

            txtPaciente.Text = pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
            txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
            txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("El campo 'Paciente' es Obligatorio");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }
    }
}
