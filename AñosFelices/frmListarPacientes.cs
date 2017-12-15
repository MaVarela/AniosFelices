using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using AñosFelices.DTO;
using AñosFelices.DTOs.DTOMappers;

namespace AñosFelices
{
    public partial class frmListarPacientes : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        public frmListarPacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarPacientes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();
            var listado = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.ObtenerTodos());

            this.dgvPacientes.DataSource = listado;
            this.dgvPacientes.Columns["Dni"].DisplayIndex = 0;
            this.dgvPacientes.Columns["Apellido"].DisplayIndex = 1;
            this.dgvPacientes.Columns["Nombre"].DisplayIndex = 2;
            this.dgvPacientes.Columns["EstadoFisico"].DisplayIndex = 3;
            this.dgvPacientes.Columns["Habitacion"].DisplayIndex = 4;
            this.dgvPacientes.Columns["Cama"].DisplayIndex = 5;
            this.dgvPacientes.Columns["FechaIngreso"].DisplayIndex = 6;
            this.dgvPacientes.Columns["Estado"].DisplayIndex = 7;
            this.dgvPacientes.Columns["Sexo"].Visible = false;
            this.dgvPacientes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";

            cargarCmbFiltrar();
            cmbHabitaciones.Items.Clear();
            cargarCmbHabitaciones();
        }

        private void cargarCmbFiltrar()
        {
            cmbFiltrar.Items.Add("Habitación");
            cmbFiltrar.Items.Add("Paciente");
            cmbFiltrar.SelectedIndex = 0;
        }

        private void cargarCmbHabitaciones()
        {
            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
            HabitacionDTOMapper mapper = new HabitacionDTOMapper();
            var listado = mapper.LlenarListado((List<Habitacion>)repositorioHabitacion.ObtenerTodos());

            for (int i = 0; i < listado.Count; i++)
            {
                cmbHabitaciones.Items.Add(listado[i].Id.ToString() + " - " + listado[i].Categoria.ToString());
                cmbHabitaciones.ValueMember = listado[i].Id.ToString();
            }

            cmbHabitaciones.SelectedIndex = 0;
        }

        private void btnParientes_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = PacienteSeleccionado.Instance();


                var dniPaciente = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value);
                pacienteSeleccionado.Paciente = repositorioPaciente.ObtenerPorId(dniPaciente);
                //pacienteSeleccionado.Paciente.Dni = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value);
                //pacienteSeleccionado.Paciente.Apellido = dgvPacientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                //pacienteSeleccionado.Paciente.Nombre = dgvPacientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                //pacienteSeleccionado.Paciente.Sexo = dgvPacientes.SelectedRows[0].Cells[3].Value.ToString();
                //pacienteSeleccionado.Paciente.FechaIngreso = Convert.ToDateTime(dgvPacientes.SelectedRows[0].Cells[4].Value.ToString());
                //pacienteSeleccionado.Paciente.EstadoFisico = dgvPacientes.SelectedRows[0].Cells["EstadoFisico"].Value.ToString();
                //pacienteSeleccionado.Paciente.Cama.Habitacion.IdHabitacion = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[5].Value);
                //pacienteSeleccionado.Paciente.Cama.Id.IdCama = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[6].Value);
                //pacienteSeleccionado.Paciente.Estado = dgvPacientes.SelectedRows[0].Cells[8].Value.ToString();
                
                var listarParientes = new frmParientes();
                listarParientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrar.Text == "Habitación")
            {
                txtApellido.Text = null;
                txtNombre.Text = null;
                lblHabitacion.Visible = true;
                cmbHabitaciones.Items.Clear();
                cmbHabitaciones.Visible = true;
                cargarCmbHabitaciones();
                lblApellido.Visible = false;
                txtApellido.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
            }
            else
            {
                txtApellido.Text = null;
                txtNombre.Text = null;
                lblHabitacion.Visible = false;
                cmbHabitaciones.Items.Clear();
                cmbHabitaciones.Visible = false;
                lblApellido.Visible = true;
                txtApellido.Visible = true;
                lblNombre.Visible = true;
                txtNombre.Visible = true;
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            cmbHabitaciones.Items.Clear();
            cmbFiltrar.Items.Clear();
            txtApellido.Text = null;
            txtNombre.Text = null;
            cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PacienteDTOMapper mapper = new PacienteDTOMapper();

            if (cmbFiltrar.SelectedItem.ToString() == "Paciente")
            {
                if (!String.IsNullOrEmpty(this.txtApellido.Text.Trim()) && txtApellido.Text.Trim() != "")
                {
                    if (!String.IsNullOrEmpty(this.txtNombre.Text.Trim()) && txtNombre.Text.Trim() != "")
                    {
                        this.dgvPacientes.DataSource = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.BuscarRegistros(null, txtNombre.Text, txtApellido.Text));

                        this.dgvPacientes.Columns["Dni"].DisplayIndex = 0;
                        this.dgvPacientes.Columns["Apellido"].DisplayIndex = 1;
                        this.dgvPacientes.Columns["Nombre"].DisplayIndex = 2;
                        this.dgvPacientes.Columns["EstadoFisico"].DisplayIndex = 3;
                        this.dgvPacientes.Columns["Habitacion"].DisplayIndex = 4;
                        this.dgvPacientes.Columns["Cama"].DisplayIndex = 5;
                        this.dgvPacientes.Columns["FechaIngreso"].DisplayIndex = 6;
                        this.dgvPacientes.Columns["Estado"].DisplayIndex = 7;
                        this.dgvPacientes.Columns["Sexo"].Visible = false;
                        this.dgvPacientes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
                    }
                    else
                        MessageBox.Show("El campo 'Nombre' es Obligatorio");
                }
                else
                    MessageBox.Show("El campo 'Apellido' es Obligatorio");
            }
            else
            {
                int habitacion;

                string[] Habitacion;
                Habitacion = cmbHabitaciones.Text.Split('-');
                habitacion = Convert.ToInt32(Habitacion[0].Trim());

                this.dgvPacientes.DataSource = mapper.llenarListaPacienteDTO((List<Paciente>)repositorioPaciente.BuscarRegistros(habitacion, null, null));

                this.dgvPacientes.Columns["Dni"].DisplayIndex = 0;
                this.dgvPacientes.Columns["Apellido"].DisplayIndex = 1;
                this.dgvPacientes.Columns["Nombre"].DisplayIndex = 2;
                this.dgvPacientes.Columns["EstadoFisico"].DisplayIndex = 3;
                this.dgvPacientes.Columns["Habitacion"].DisplayIndex = 4;
                this.dgvPacientes.Columns["Cama"].DisplayIndex = 5;
                this.dgvPacientes.Columns["FechaIngreso"].DisplayIndex = 6;
                this.dgvPacientes.Columns["Estado"].DisplayIndex = 7;
                this.dgvPacientes.Columns["Sexo"].Visible = false;
                this.dgvPacientes.Columns["FechaIngreso"].HeaderText = "Fecha de Ingreso";
            }
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
    }
}
