﻿using System;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using System.Windows.Forms;

namespace AñosFelices
{
    public partial class frmConsultarRecAlim : Form
    {
        IRepositorioHistoriaClinica consultarhc = new RepositorioHistoriaClinica();
        public frmConsultarRecAlim()
        {
            InitializeComponent();
            this.Grilla1.DataSource = consultarhc.ObtenerTodos();
        }

        private void frmConsultarRecAlim_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbDato.Text == "")
            {
                this.Grilla1.DataSource = consultarhc.ObtenerTodos();
            }

            if (cmbDato.Text == "DNI Paciente")
            {
                /*if (txtDato.Text != "")
                {
                    this.Grilla1.DataSource = consultarhc.ObtenerPorId(txtDato.Text);
                }
                else {*/
                    MessageBox.Show("No se han completado los campos. Por favor ingresar los datos correpondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }

        }
    }
}
