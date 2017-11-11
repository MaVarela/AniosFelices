using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmRegistrarEstadoGeneral : Form
    {
        public frmRegistrarEstadoGeneral()
        {
            InitializeComponent();
        }

        private void frmRegistrarEstadoGeneral_Load(object sender, System.EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            var usuarioLogueado = UsuarioLogueado.Instance();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            txtUsuario.Text = usuarioLogueado.Usuario.Apellido + " " + usuarioLogueado.Usuario.Nombre;
            cargarCmbTurno();
        }

        private void cargarCmbTurno()
        {
            cmbTurno.Items.Add("Diurno");
            cmbTurno.Items.Add("Vespertino");
            cmbTurno.Items.Add("Nocturno");
            cmbTurno.SelectedIndex = 0;
        }

        private void btnPacientes_Click(object sender, System.EventArgs e)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();

            txtPaciente.Text = pacienteSeleccionado.Paciente.Apellido + " " + pacienteSeleccionado.Paciente.Nombre;
            txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
            txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtPaciente.Text))
            {
                if (!String.IsNullOrEmpty(this.txtPresion1.Text))
                {
                    if (!String.IsNullOrEmpty(this.txtPresion2.Text))
                    {
                        if (!String.IsNullOrEmpty(this.txtTemperatura.Text))
                        {
                            if (!String.IsNullOrEmpty(this.txtAzucar.Text))
                            {
                                if (!String.IsNullOrEmpty(this.txtMedicacion.Text.Trim()) && txtMedicacion.Text != "")
                                {
                                    if (!String.IsNullOrEmpty(this.txtObservaciones.Text.Trim()) && txtObservaciones.Text != "")
                                    {
                                        if (!String.IsNullOrEmpty(this.txtRecomendaciones.Text.Trim()) && txtRecomendaciones.Text != "")
                                        {
                                            var pacienteSeleccionado = PacienteSeleccionado.Instance();
                                            var usuarioLogueado = UsuarioLogueado.Instance();
                                            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
                                            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
                                            IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();
                                            LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();
                                            idLibroGuardias.Usuario = repositorioUsuario.ObtenerPorId(Convert.ToInt32(usuarioLogueado.Usuario.Dni));
                                            idLibroGuardias.Paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(pacienteSeleccionado.Paciente.Dni));
                                            idLibroGuardias.Turno = this.cmbTurno.Text + ", Estado General";
                                            var estado = repositorioLibroDeGuardias.ObtenerPorId(idLibroGuardias);

                                            if (estado == null)
                                            {
                                                if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                                {
                                                    estado = new LibroDeGuardias() { Id = idLibroGuardias };
                                                    estado.Fecha = dtpFecha.Value.Date;
                                                    estado.Presion = txtPresion1.Text + "/" + txtPresion2.Text;
                                                    estado.Temperatura = Convert.ToDecimal(txtTemperatura.Text);
                                                    estado.Azucar = Convert.ToDecimal(txtAzucar.Text);
                                                    estado.MedicacionAdministrada = txtMedicacion.Text.Trim();
                                                    estado.Observaciones = txtObservaciones.Text.Trim();
                                                    estado.Recomendaciones = txtRecomendaciones.Text.Trim();
                                                    estado = repositorioLibroDeGuardias.Agregar(estado);
                                                    MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Estado General registrado con anterioridad. No se puede guardar un Registro Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                            MessageBox.Show("El campo 'Recomendaciones' es Obligatorio");
                                    }
                                    else
                                        MessageBox.Show("El campo 'Observaciones' es Obligatorio");
                                }
                                else
                                    MessageBox.Show("El campo 'Medicación Administrada' es Obligatorio");
                            }
                            else
                                MessageBox.Show("El campo 'Azúcar' es Obligatorio");
                        }
                        else
                            MessageBox.Show("El campo 'Temperatura' es Obligatorio");
                    }
                    else
                        MessageBox.Show("El campo 'Presión' es Obligatorio");
                }
                else
                    MessageBox.Show("El campo 'Presión' es Obligatorio");
            }
            else
                MessageBox.Show("El campo 'Paciente' es Obligatorio"); 
        }

        private void txtPresion1_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPresion1.SelectionStart = 0;
        }

        private void txtPresion2_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPresion2.SelectionStart = 0;
        }

        private void txtTemperatura_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtTemperatura.SelectionStart = 0;
        }

        private void txtAzucar_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtAzucar.SelectionStart = 0;
        }
    }
}
