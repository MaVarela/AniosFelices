using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmAltaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioCama repositorioCama = new RepositorioCama();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        ParienteSeleccionado parienteSeleccionado;
        PacienteSeleccionado pacienteSeleccionado;

        public frmAltaPaciente()
        {
            InitializeComponent();
            parienteSeleccionado = ParienteSeleccionado.Instance();
            pacienteSeleccionado = PacienteSeleccionado.Instance();
        }

        private void btnSeleccionarHabitacion_Click(object sender, EventArgs e)
        {
            if(rdbFemenino.Checked != true && rdbMasculino.Checked != true)
                MessageBox.Show("Debe seleccionar el Sexo para poder asignar Habitación y Cama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String sexo;
                if (rdbFemenino.Checked == true)
                    sexo = "Mujeres";
                else
                    sexo = "Hombres";

                var camaSeleccionada = CamaSeleccionada.Instance();
                var ListadoHabitaciones = new frmHabitacionesList(sexo);
                ListadoHabitaciones.ShowDialog();


                if (camaSeleccionada.Cama != null)
                {
                    this.txtCama.Text = camaSeleccionada.Cama.IdCama.ToString();
                    this.txtHabitacion.Text = camaSeleccionada.Cama.IdHabitacion.ToString();
                }
            }  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(dgvParientes.RowCount < 2)
            {
                var agregarPariente = new frmAgregarPariente();
                agregarPariente.ShowDialog();

                ParienteSeleccionado pariente = ParienteSeleccionado.Instance();
                if(pariente.Parientes != null)
                {
                    cargarDGV();
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden agregar 2 parientes por Paciente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarDGV()
        {
            ParienteDTOMapper mapper = new ParienteDTOMapper();
            var listado = mapper.LlenarListado(parienteSeleccionado.Parientes);


            dgvParientes.DataSource = listado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var camaSeleccionada = CamaSeleccionada.Instance();
            if (!String.IsNullOrEmpty(txtDni.Text))
            {
                if (txtDni.Text.Length >= 7 || txtDni.Text.Length == 8)
                {
                    if (!String.IsNullOrEmpty(txtNombre.Text.Trim()))
                    {
                        if (!String.IsNullOrEmpty(txtApellido.Text.Trim()))
                        {
                            if (!String.IsNullOrEmpty(txtEstadoFisico.Text.Trim()))
                            {
                                if (rdbFemenino.Checked != false || rdbMasculino.Checked != false)
                                {   
                                    if (camaSeleccionada.Cama != null)
                                    {
                                        if (this.dgvParientes.RowCount > 0)
                                        {
                                            if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                            {
                                                var habitacion = repositorioHabitacion.ObtenerPorId(camaSeleccionada.Cama.IdHabitacion);
                                                habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault().Estado = "O";
                                                repositorioHabitacion.Editar(habitacion);

                                                var Paciente = new Paciente();
                                                var PacienteDTO = new PacienteDTO();

                                                if (pacienteSeleccionado.Paciente == null)
                                                {
                                                    pacienteSeleccionado.Paciente = new Paciente();
                                                }

                                                Paciente.Dni = Convert.ToInt32(this.txtDni.Text);
                                                Paciente.Cama = habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault();
                                                Paciente.Nombre = this.txtNombre.Text.Trim();
                                                Paciente.Apellido = this.txtApellido.Text.Trim();
                                                Paciente.EstadoFisico = this.txtEstadoFisico.Text.Trim();
                                                Paciente.FechaIngreso = dtpFecha.Value.Date;
                                            
                                                if (rdbFemenino.Checked == true)
                                                    Paciente.Sexo = rdbFemenino.Text;
                                                else
                                                    Paciente.Sexo = rdbMasculino.Text;

                                                ParienteDTOMapper mapper = new ParienteDTOMapper();
                                                var listado = mapper.LlenarListadoPersist(parienteSeleccionado.Parientes, Paciente);

                                                Paciente.Parientes = listado;
                                                repositorioPaciente.Agregar(Paciente);
                                                MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                pacienteSeleccionado.Paciente = null;
                                                parienteSeleccionado.Pariente = null;
                                                parienteSeleccionado.Parientes = null;
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe agregar al menos un pariente para dar de alta el paciente", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar una habitación y una cama para dar de alta el paciente", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                    MessageBox.Show("Debe seleccionar el Sexo para dar de alta el paciente", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("El campo 'Estado Físico' es Obligatorio", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("El campo 'Apellido' es Obligatorio", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("El campo 'Nombre' es Obligatorio", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El campo 'Dni' debe poseer entre 7 y 8 dígitos", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El campo 'Dni' es Obligatorio", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDni.Text = null;
            txtApellido.Text = null;
            txtCama.Text = null;
            txtEstadoFisico.Text = null;
            txtHabitacion.Text = null;
            txtNombre.Text = null;
            pacienteSeleccionado.Paciente = null;
            this.Close();
        }

        private void frmAltaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount > 0)
            {
                int index;
                var parienteDTO = new ParienteDTO();
                var nombreForm = new frmAltaPaciente().Name;
                index = Convert.ToInt32(dgvParientes.CurrentRow.Index.ToString());
                parienteDTO.Dni = Convert.ToInt32(dgvParientes.SelectedRows[0].Cells[0].Value);
                parienteDTO.Nombre = dgvParientes.SelectedRows[0].Cells[1].Value != null ? dgvParientes.SelectedRows[0].Cells[1].Value.ToString() : null;
                parienteDTO.Apellido = dgvParientes.SelectedRows[0].Cells[2].Value != null ? dgvParientes.SelectedRows[0].Cells[2].Value.ToString() : null;
                parienteDTO.Direccion = dgvParientes.SelectedRows[0].Cells[3].Value != null ? dgvParientes.SelectedRows[0].Cells[3].Value.ToString() : null;
                parienteDTO.Telefono1 = dgvParientes.SelectedRows[0].Cells[4].Value != null ? dgvParientes.SelectedRows[0].Cells[4].Value.ToString() : null;
                parienteDTO.Telefono2 = dgvParientes.SelectedRows[0].Cells[5].Value != null ? dgvParientes.SelectedRows[0].Cells[5].Value.ToString() : null;
                parienteDTO.Mail = dgvParientes.SelectedRows[0].Cells[6].Value != null ? dgvParientes.SelectedRows[0].Cells[6].Value.ToString() : null;
                parienteDTO.Parentezco = dgvParientes.SelectedRows[0].Cells[7].Value != null ? dgvParientes.SelectedRows[0].Cells[7].Value.ToString() : null;

                var modificarPariente = new frmModificarPariente(index, parienteDTO, nombreForm);
                modificarPariente.ShowDialog();

                cargarDGV();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvParientes.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el Pariente?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var parienteDTO = new ParienteDTO();
                    parienteDTO.Dni = Convert.ToInt32(dgvParientes.SelectedRows[0].Cells[0].Value);
                    if (parienteSeleccionado.Parientes.Count() > 0)
                    {
                        parienteSeleccionado.Parientes.Remove(parienteSeleccionado.Parientes.Where(x => x.Dni == parienteDTO.Dni).First());
                        cargarDGV();
                    }
                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtEstadoFisico_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;

            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}