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
using System.Text;

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
            String sexo = "";
            if (rdbFemenino.Checked == true)
                sexo = "Mujeres";
            else
                sexo = "Hombres";

            var ListadoHabitaciones = new frmHabitacionesList(sexo);
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
            try
            {
                if (dgvParientes.RowCount > 0)
                {
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

                    var modificarPariente = new frmModificarPariente(index, parienteDTO);
                    modificarPariente.ShowDialog();

                    cargarDGVParientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
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
                            pacienteSeleccionado.Paciente.Parientes.Where(x => x.Dni == parienteDTO.Dni).First().Pacientes.Remove(pacienteSeleccionado.Paciente);
                            pacienteSeleccionado.Paciente.Parientes.Remove(pacienteSeleccionado.Paciente.Parientes.Where(x => x.Dni == parienteDTO.Dni).First());
                            cargarDGVParientes();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> mensajes = new List<String>();

                if (String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                    mensajes.Add("El campo 'Nombre' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtApellido.Text.Trim()))
                    mensajes.Add("El campo 'Apellido' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtEstadoFisico.Text.Trim()))
                    mensajes.Add("El campo 'Estado Físico' es Obligatorio");
                if (parienteSeleccionado.Parientes == null || parienteSeleccionado.Parientes.Count() < 1)
                    mensajes.Add("Debe seleccionar al menos un pariente");
                if (camaSeleccionada.Cama == null)
                    mensajes.Add("Debe seleccionar una habitación y una cama para dar de alta el paciente");

                if (mensajes.Count.Equals(0))
                {
                    if (MessageBox.Show("¿Está seguro de que desea Modificar el Registro?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        pacienteSeleccionado.Paciente.Nombre = this.txtNombre.Text.Trim();
                        pacienteSeleccionado.Paciente.Apellido = this.txtApellido.Text.Trim();
                        pacienteSeleccionado.Paciente.EstadoFisico = this.txtEstadoFisico.Text.Trim();
                        pacienteSeleccionado.Paciente.FechaIngreso = dtpFecha.Value.Date;
                        ParienteDTOMapper mapper = new ParienteDTOMapper();
                        pacienteSeleccionado.Paciente.Parientes.Clear();

                        var listado = mapper.LlenarListadoPersist(parienteSeleccionado.Parientes, pacienteSeleccionado.Paciente);
                        foreach (var newPariente in listado)
                        {
                            pacienteSeleccionado.Paciente.Parientes.Add(newPariente);
                        }

                        if ((pacienteSeleccionado.Paciente.Cama != null && pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion != Convert.ToInt32(txtHabitacion.Text))
                            || (pacienteSeleccionado.Paciente.Cama != null && pacienteSeleccionado.Paciente.Cama.IdCama != Convert.ToInt32(txtCama.Text)))
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
                        if(pacienteSeleccionado.Paciente.Cama == null)
                        {
                            var habitacionElegida = repositorioHabitacion.ObtenerPorId(camaSeleccionada.Cama.IdHabitacion);

                            habitacionElegida.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault().Estado = "O";
                            pacienteSeleccionado.Paciente.Cama = habitacionElegida.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault();
                        }

                        repositorioPaciente.Editar(pacienteSeleccionado.Paciente);
                        MessageBox.Show("El paciente se ha modificado con exito");
                        pacienteSeleccionado.Paciente = null;
                        parienteSeleccionado.Parientes = null;
                        parienteSeleccionado.Pariente = null;
                        camaSeleccionada.Cama = null;
                        this.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pacienteSeleccionado.Paciente = null;
            parienteSeleccionado.Parientes = null;
            camaSeleccionada.Cama = null;
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
            try
            {
                txtDni.Text = pacienteSeleccionado.Paciente.Dni.ToString();
                txtDni.ReadOnly = true;
                txtNombre.Text = pacienteSeleccionado.Paciente.Nombre.ToString();
                txtApellido.Text = pacienteSeleccionado.Paciente.Apellido.ToString();
                txtEstadoFisico.Text = pacienteSeleccionado.Paciente.EstadoFisico.ToString();
                if (pacienteSeleccionado.Paciente.Cama != null)
                {
                    CamaDTOMapper mapperCama = new CamaDTOMapper();
                    txtHabitacion.Text = pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion.ToString();
                    txtCama.Text = pacienteSeleccionado.Paciente.Cama.IdCama.ToString();
                    camaSeleccionada.Cama = mapperCama.LlenarListado(new List<Cama>() { pacienteSeleccionado.Paciente.Cama }).FirstOrDefault();
                }

                dtpFecha.Value = pacienteSeleccionado.Paciente.FechaIngreso;

                if (pacienteSeleccionado.Paciente.Sexo.ToString() == "Femenino")
                    rdbFemenino.Checked = true;
                else
                    rdbMasculino.Checked = true;

                ParienteDTOMapper mapper = new ParienteDTOMapper();
                var listado = mapper.LlenarListado(pacienteSeleccionado.Paciente.Parientes.ToList());
                dgvParientes.DataSource = listado;

                if (parienteSeleccionado.Parientes == null)
                {
                    parienteSeleccionado.Parientes = new List<ParienteDTO>();
                }
                parienteSeleccionado.Parientes = listado;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
        }
    }
}
