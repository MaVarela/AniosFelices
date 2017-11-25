using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.DTO;
using AñosFelices.Utilidades;
using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using AñosFelices.EntidadesDeNegocio;
using AniosFelicesSystem.EntidadesDeNegocio;

namespace AñosFelices
{
    public partial class frmConsultarEstadoPaciente : Form
    {
        IRepositorioHistoriaClinica repositoriohistoriaclinica = new RepositorioHistoriaClinica();
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        UsuarioLogueado usuario = UsuarioLogueado.Instance();

        public frmConsultarEstadoPaciente()
        {
            InitializeComponent();
        }

        private void frmConsultarEstadoPaciente_Load(object sender, EventArgs e)
        {
            cargar();
            cmbDato.SelectedIndex = 0;
        }

        private void cargar()
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            var listado = mapper.ListarEstadoGeneral((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));

            configurarGrilla(listado);

        }

        private void configurarGrilla(List<HistoriaClinicaDTO> listado)
        {
            this.dgvEstadoPaciente.DataSource = listado;
            this.dgvEstadoPaciente.Columns[0].Visible = true;
            this.dgvEstadoPaciente.Columns[1].Visible = true;
            this.dgvEstadoPaciente.Columns[2].Visible = true;
            this.dgvEstadoPaciente.Columns[3].Visible = true;
            this.dgvEstadoPaciente.Columns[4].Visible = true;
            this.dgvEstadoPaciente.Columns[5].Visible = false;
            this.dgvEstadoPaciente.Columns[6].Visible = false;
            this.dgvEstadoPaciente.Columns[7].Visible = false;
            this.dgvEstadoPaciente.Columns[8].Visible = true;

            this.dgvEstadoPaciente.Columns[0].HeaderText = "DNI del Paciente";
            this.dgvEstadoPaciente.Columns[4].HeaderText = "Fecha de Visita";
            this.dgvEstadoPaciente.Columns[8].HeaderText = "Estado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDTOMapper mapper = new HistoriaClinicaDTOMapper();
            List<HistoriaClinicaDTO> listado = new List<HistoriaClinicaDTO>();
            if (cmbDato.Text == "Todos")
            {
                 listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
            }

            if (cmbDato.Text == "DNI Paciente")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(int.Parse(txtDato.Text),null,null));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            if (cmbDato.Text == "Nombre")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, txtDato.Text, null));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            if (cmbDato.Text == "Apellido")
            {

                if (txtDato.Text != "")
                {
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, txtDato.Text));
                }
                else
                {
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listado = mapper.ListarConsultasHistoriasClinicas((List<HistoriaClinica>)repositoriohistoriaclinica.BuscarRegistros(null, null, null));
                }
            }

            configurarGrilla(listado);  
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbDato.Text == "DNI Paciente")
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    txtDato.Text = "";
                    lblMensaje.Text = "*Solo se permiten numeros";
                    lblMensaje.Visible = true;
                    lblMensaje.ForeColor = Color.Red;
                    e.Handled = true;
                }
                else { lblMensaje.Visible = false; }
            }
            else
            {
                if (cmbDato.Text == "Nombre" || cmbDato.Text == "Apellido")
                {
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        txtDato.Text = "";
                        lblMensaje.Text = "*Solo se permiten letras";
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = Color.Red;
                        e.Handled = true;
                    }

                    else { lblMensaje.Visible = false; }
                }
            }
        }

        private void cmbDato_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDato.Text = "";
            lblMensaje.Visible = false;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (this.dgvEstadoPaciente.CurrentRow != null)
            {

                var frmDetalle = new frmDetalleHistoriaClinica();
                var historiaclinicaSeleccionada = HistoriaClinicaSeleccionada.Instance();
                var paciente = repositorioPaciente.ObtenerPorId(Convert.ToInt32(dgvEstadoPaciente.SelectedRows[0].Cells[0].Value));
                var fechavisita = Convert.ToDateTime(dgvEstadoPaciente.SelectedRows[0].Cells[4].Value);
                var historiaclinicaId = new HistoriaClinicaId() { FechaVisita = fechavisita, Paciente = paciente, Usuario = usuario.Usuario };
                var historiaclinica = repositoriohistoriaclinica.ObtenerPorUsuarioPacienteFecha(historiaclinicaId).Where(x => !String.IsNullOrEmpty(x.EstadoGeneral)).FirstOrDefault();

                historiaclinicaSeleccionada.HistoriaClinica = historiaclinica;

                frmDetalle.Show();
            }
        }
    }
}
