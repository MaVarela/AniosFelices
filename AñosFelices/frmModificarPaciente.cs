using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTOs;

namespace AñosFelices
{
    public partial class frmModificarPaciente : Form
    {
        IRepositorioPariente repositorioPariente = new RepositorioPariente();
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioCama repositorioCama = new RepositorioCama();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        ParienteSeleccionado parienteSeleccionado;
        CamaSeleccionada camaSeleccionada;
        PacienteSeleccionado pacienteSeleccionado;
        HabitacionSeleccionada habitacionSeleccionada;

        public frmModificarPaciente()
        {
            InitializeComponent();
            camaSeleccionada = CamaSeleccionada.Instance();
            parienteSeleccionado = ParienteSeleccionado.Instance();
            pacienteSeleccionado = PacienteSeleccionado.Instance();
            habitacionSeleccionada = HabitacionSeleccionada.Instance();
        }

        private void btnSeleccionarHabitacion_Click(object sender, EventArgs e)
        {
            var ListadoHabitaciones = new frmHabitacionesList();
            ListadoHabitaciones.ShowDialog();

            if (camaSeleccionada.Cama != null)
            {
                this.txtCama.Text = camaSeleccionada.Cama.IdCama.ToString();
                this.txtHabitacion.Text = camaSeleccionada.Cama.IdHabitacion.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount < 2)
            {
                var agregarPariente = new frmAgregarPariente();
                agregarPariente.ShowDialog();

                if (parienteSeleccionado.Parientes != null)
                {
                    //MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDGVParientes();
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden agregar 2 parientes por Paciente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount > 0)
            {
                var nombreForm = new frmModificarPaciente().Name;
                int index;
                var parienteDTO = new ParienteDTO();
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

                cargarDGVParientes();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvParientes.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el Pariente?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var parienteDTO = new ParienteDTO();
                    parienteDTO.Dni = Convert.ToInt32(dgvParientes.SelectedRows[0].Cells[0].Value);
                    if (parienteSeleccionado.Parientes.Count() > 0)
                    {
                        parienteSeleccionado.Parientes.Remove(parienteSeleccionado.Parientes.Where(x => x.Dni == parienteDTO.Dni).First());
                        cargarDGVParientes();
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDni.Text.Trim()) && txtDni.Text != "")
            {
                if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) && txtNombre.Text != "")
                {
                    if (!String.IsNullOrEmpty(this.txtApellido.Text.Trim()) && txtApellido.Text != "")
                    {
                        if (!String.IsNullOrEmpty(this.txtEstadoFisico.Text.Trim()) && txtEstadoFisico.Text != "")
                        {
                            if (MessageBox.Show("¿Está seguro de que desea Modificar el Registro?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                pacienteSeleccionado.Paciente.Nombre = this.txtNombre.Text.Trim();
                                pacienteSeleccionado.Paciente.Apellido = this.txtApellido.Text.Trim();
                                pacienteSeleccionado.Paciente.EstadoFisico = this.txtEstadoFisico.Text.Trim();
                                ParienteDTOMapper mapper = new ParienteDTOMapper();
                                pacienteSeleccionado.Paciente.Parientes.Clear();

                                var listado = mapper.LlenarListadoPersist(parienteSeleccionado.Parientes, pacienteSeleccionado.Paciente);
                                foreach (var newPariente in listado)
                                {
                                    pacienteSeleccionado.Paciente.Parientes.Add(newPariente);
                                }

                                if (parienteSeleccionado.Parientes == null)
                                {
                                    parienteSeleccionado.Parientes = new List<ParienteDTO>();
                                }

                                if (pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion != Convert.ToInt32(txtHabitacion.Text) || pacienteSeleccionado.Paciente.Cama.IdCama != Convert.ToInt32(txtCama.Text))
                                {
                                    var idCama = pacienteSeleccionado.Paciente.Cama.IdCama;
                                    var idHabitacion = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion;
                                    var habitacion = repositorioHabitacion.ObtenerPorId(idHabitacion);
                                    var habitacionElegida = repositorioHabitacion.ObtenerPorId(camaSeleccionada.Cama.IdHabitacion);

                                    habitacion.Camas.Where(x => x.IdCama == idCama).FirstOrDefault().Estado = "L";
                                    repositorioHabitacion.Editar(habitacion);
                                    habitacionElegida.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault().Estado = "O";
                                    pacienteSeleccionado.Paciente.Cama = habitacionElegida.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault();

                                }

                                repositorioPaciente.Editar(pacienteSeleccionado.Paciente);
                                MessageBox.Show("El paciente se ha modificado con exito");
                                pacienteSeleccionado.Paciente = null;
                                parienteSeleccionado.Parientes = null;
                                parienteSeleccionado.Pariente = null;
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("El campo 'Estado Fisico' es Obligatorio");
                    }
                    else
                        MessageBox.Show("El campo 'Apellido' es Obligatorio");
                }
                else
                    MessageBox.Show("El campo 'Nombre' es Obligatorio");
            }

            else
                MessageBox.Show("El campo 'Dni' es Obligatorio");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            parienteSeleccionado.Parientes = null;
            this.Close();
        }

        private void cargarDGVParientes()
        {
            ParienteDTOMapper mapper = new ParienteDTOMapper();
            var listado = mapper.LlenarListado(parienteSeleccionado.Parientes);


            dgvParientes.DataSource = listado;
        }

        private void frmModificarPaciente_Load(object sender, EventArgs e)
        {
            //HabitacionDTOMapper mapper = new HabitacionDTOMapper();

            txtDni.Text = pacienteSeleccionado.Paciente.Dni.ToString();
            txtDni.ReadOnly = true;
            txtNombre.Text = pacienteSeleccionado.Paciente.Nombre.ToString();
            txtApellido.Text = pacienteSeleccionado.Paciente.Apellido.ToString();
            txtEstadoFisico.Text = pacienteSeleccionado.Paciente.EstadoFisico.ToString();
            txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
            txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
            
            ParienteDTOMapper mapper = new ParienteDTOMapper();
            var listado = mapper.LlenarListado((List<Pariente>)repositorioPariente.ObtenerTodos());
            dgvParientes.DataSource = listado;

            if (parienteSeleccionado.Parientes == null)
            {
                parienteSeleccionado.Parientes = new List<ParienteDTO>();
            }
            parienteSeleccionado.Parientes = listado;
        }
    }
}
