using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
using AñosFelices.DTOs.DTOMappers;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmAltaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioCama repositorioCama = new RepositorioCama();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        IRepositorioUsuario repositorioUsuarios = new RepositorioUsuario();
        IRepositorioPariente repositorioParientes = new RepositorioPariente();
        ParienteSeleccionado parienteSeleccionado;
        PacienteSeleccionado pacienteSeleccionado;
        CamaSeleccionada camaSeleccionada;

        public frmAltaPaciente()
        {
            InitializeComponent();
            parienteSeleccionado = ParienteSeleccionado.Instance();
            parienteSeleccionado.Parientes = new List<ParienteDTO>();
            pacienteSeleccionado = PacienteSeleccionado.Instance();
            camaSeleccionada = CamaSeleccionada.Instance();
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

                //ParienteSeleccionado pariente = ParienteSeleccionado.Instance();
                if(parienteSeleccionado.Parientes != null)
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
            try
            {
                List<String> mensajes = new List<String>();
                int dni = 0;

                if (!String.IsNullOrEmpty(txtDni.Text))
                {
                    if (txtDni.Text.Length >= 7 || txtDni.Text.Length == 8)
                    {
                        if (!Int32.TryParse(this.txtDni.Text, out dni))
                            mensajes.Add("El campo 'Dni' debe ser solo numérico");
                    }
                    else
                    {
                        mensajes.Add("El campo 'Dni' debe poseer entre 7 y 8 dígitos");
                    }
                }
                else
                    mensajes.Add("El campo 'Dni' es Obligatorio");
                if (!rdbFemenino.Checked && !rdbMasculino.Checked)
                    mensajes.Add("Debe seleccionar el Sexo para dar de alta el paciente");
                if (camaSeleccionada.Cama == null)
                    mensajes.Add("Debe seleccionar una habitación y una cama para dar de alta el paciente");
                if (String.IsNullOrEmpty(this.txtNombre.Text.Trim()))
                    mensajes.Add("El campo 'Nombre' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtApellido.Text.Trim()))
                    mensajes.Add("El campo 'Apellido' es Obligatorio");
                if (String.IsNullOrEmpty(this.txtEstadoFisico.Text.Trim()))
                    mensajes.Add("El campo 'Estado Físico' es Obligatorio");
                if (parienteSeleccionado.Parientes == null || parienteSeleccionado.Parientes.Count() < 1)
                    mensajes.Add("Debe seleccionar al menos un pariente para dar de alta el paciente");
                if (repositorioPaciente.Existe(dni) || repositorioParientes.Existe(dni) || repositorioUsuarios.Existe(dni) || parienteSeleccionado.Parientes.Where(x => x.Dni == dni).Count() > 0)
                    mensajes.Add("El Dni ingresado ya se encuentra registrado");

                if (mensajes.Count.Equals(0))
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

                        Paciente.Dni = dni;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogueadorErrores.Loguear(ex);
            }
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
            camaSeleccionada.Cama = null;
            
            this.Close();
        }

        private void frmAltaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
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
                            cargarDGV();
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