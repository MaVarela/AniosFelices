using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTOs;
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
    public partial class frmAltaPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioCama repositorioCama = new RepositorioCama();
        IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
        ParienteSeleccionado ParienteSeleccionado = ParienteSeleccionado.Instance();

        public frmAltaPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var camaSeleccionada = CamaSeleccionada.Instance();
            var ListadoHabitaciones = new frmHabitacionesList();
            ListadoHabitaciones.ShowDialog();


            if (camaSeleccionada.Cama != null)
            {
                this.txtCama.Text = camaSeleccionada.Cama.IdCama.ToString();
                this.txtHabitacion.Text = camaSeleccionada.Cama.IdHabitacion.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount < 2)
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
            var listado = mapper.LlenarListado(ParienteSeleccionado.Parientes);


            dataGridView1.DataSource = listado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var camaSeleccionada = CamaSeleccionada.Instance();
            if (!String.IsNullOrEmpty(mkdDni.Text))
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    if (!String.IsNullOrEmpty(txtApellido.Text))
                    {
                        if (!String.IsNullOrEmpty(txtEstadoFisico.Text))
                        {
                            if (camaSeleccionada.Cama != null)
                            {
                                if (this.dataGridView1.RowCount > 0)
                                {
                                    if (MessageBox.Show("¿Está seguro de que desea guardar el Registro?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        var habitacion = repositorioHabitacion.ObtenerPorId(camaSeleccionada.Cama.IdHabitacion);
                                        habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault().Estado = "O";
                                        repositorioHabitacion.Editar(habitacion);

                                        var Pariente = new Pariente();
                                        var Paciente = new Paciente();
                                        var PacienteDTO = new PacienteDTO();
                                        var pacienteSeleccionado = PacienteSeleccionado.Instance();

                                        if (pacienteSeleccionado.Paciente == null)
                                        {
                                            pacienteSeleccionado.Paciente = new Paciente();
                                        }

                                        Paciente.Dni = Convert.ToInt32(this.mkdDni.Text);
                                        Paciente.Cama = habitacion.Camas.Where(x => x.IdCama == camaSeleccionada.Cama.IdCama).FirstOrDefault();
                                        Paciente.Nombre = this.txtNombre.Text.Trim();
                                        Paciente.Apellido = this.txtApellido.Text.Trim();
                                        Paciente.EstadoFisico = this.txtEstadoFisico.Text.Trim();

                                        Paciente.Parientes = new List<Pariente>();

                                        ParienteDTOMapper mapper = new ParienteDTOMapper();
                                        var listado = mapper.LlenarListadoPersist(ParienteSeleccionado.Parientes, Paciente);
                                
                                        Paciente.Parientes = listado;
                                        repositorioPaciente.Agregar(Paciente);
                                        MessageBox.Show("Registro Guardado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        pacienteSeleccionado.Paciente = null;
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
                            MessageBox.Show("El campo 'Estado Físico' es Obligatorio");
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

        private void button4_Click(object sender, EventArgs e)
        {
            mkdDni.Text = null;
            txtApellido.Text = null;
            txtCama.Text = null;
            txtEstadoFisico.Text = null;
            txtHabitacion.Text = null;
            txtNombre.Text = null;
            this.Close();
        }

        private void frmAltaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int index;
                var parienteDTO = new ParienteDTO();
                index = Convert.ToInt32(dataGridView1.CurrentRow.Index.ToString());
                parienteDTO.Dni = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                parienteDTO.Nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                parienteDTO.Apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                parienteDTO.Direccion = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                parienteDTO.Telefono1 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                parienteDTO.Telefono2 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                parienteDTO.Mail = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                parienteDTO.Parentezco = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
                var modificarPariente = new frmModificarPariente(index, parienteDTO);
                modificarPariente.ShowDialog();

                cargarDGV();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el Pariente?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var parienteDTO = new ParienteDTO();
                    parienteDTO.Dni = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    if (ParienteSeleccionado.Parientes.Count() > 0)
                    {
                        ParienteSeleccionado.Parientes.Remove(ParienteSeleccionado.Parientes.Where(x => x.Dni == parienteDTO.Dni).First());
                        cargarDGV();
                    }
                }
            }
        }
    }
}