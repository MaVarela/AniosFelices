using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.Utilidades;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AñosFelices
{
    /// <summary>
    /// Inicializador de Base de Datos
    /// </summary>
    public static class InicializadorDB
    {
        /// <summary>
        /// Inicializa la Base de Datos en caso de que no posea registros
        /// </summary>
        public static void InicializarDB()
        {
            Rol resplegal = new Rol("Responsable Legal");
            Rol enfermera = new Rol("Enfermera");
            Rol medico = new Rol("Médico");
            Rol encargada = new Rol("Encargada");
            Rol encargadacocina = new Rol("Encargada de Cocina");
            Rol asistente = new Rol("Asistente");

            NHibernateHelper.OpenSession();

            IRepositorioRol repositorioRol = new RepositorioRol();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
            IRepositorioCama repositorioCama = new RepositorioCama();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            IRepositorioPariente repositorioPariente = new RepositorioPariente();
            IRepositorioLibroDeGuardias repositorioLibroDeGuardias = new RepositorioLibroDeGuardias();
            IRepositorioHistoriaClinica repositorioHistoriaClinica = new RepositorioHistoriaClinica();

            var rol1 = repositorioRol.ObtenerPorId(1);
            var rol2 = repositorioRol.ObtenerPorId(2);
            var rol3 = repositorioRol.ObtenerPorId(3);
            var rol4 = repositorioRol.ObtenerPorId(4);
            var rol5 = repositorioRol.ObtenerPorId(5);
            var rol6 = repositorioRol.ObtenerPorId(6);
            if (rol1 == null)
                rol1 = repositorioRol.Agregar(resplegal);
            if (rol2 == null)
                rol2 = repositorioRol.Agregar(enfermera);
            if (rol3 == null)
                rol3 = repositorioRol.Agregar(medico);
            if (rol4 == null)
                rol4 = repositorioRol.Agregar(encargada);
            if (rol5 == null)
                rol5 = repositorioRol.Agregar(encargadacocina);
            if (rol6 == null)
                rol6 = repositorioRol.Agregar(asistente);
            Usuario RespLegal = new Usuario();
            Usuario getMedico = new Usuario();

            if (rol1 != null)
            {
                RespLegal = repositorioUsuario.ObtenerPorId(34493011);
                if (RespLegal == null)
                {
                    Usuario reslegal = new Usuario(34493011, rol1, "123456", "Mariano", "Varela", "México 751", "4736-7808", null, "marianovarela89@yahoo.es", System.DateTime.Today);
                    RespLegal = repositorioUsuario.Agregar(reslegal);
                }
            }
            if (rol3 != null)
            {
                getMedico = repositorioUsuario.ObtenerPorId(34493012);
                if (getMedico == null)
                {
                    Usuario uMedico = new Usuario(34493012, rol3, "123456", "Juan", "Navarro", "Patagonia 235", "4740-2240", null, "juanNavarro@gmail.com", System.DateTime.Today);
                    repositorioUsuario.Agregar(uMedico);
                }
            }

            var hab1 = repositorioHabitacion.ObtenerPorId(1);
            try
            {
                if (hab1 == null)
                {
                    Habitacion habitacion = new Habitacion("Hombres - Dependientes", null);
                    Cama cama = new Cama(1, habitacion);
                    Cama cama2 = new Cama(2, habitacion);
                    habitacion.Camas.Add(cama);
                    habitacion.Camas.Add(cama2);
                    hab1 = repositorioHabitacion.Agregar(habitacion);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Paciente paciente = new Paciente();

            if (hab1 != null && hab1.Camas.Count() > 0)
            {
                try
                {
                    paciente = repositorioPaciente.ObtenerPorId(34493020);

                    if (paciente == null)
                    {
                        hab1.Camas.First().Estado = "O";
                        paciente = new Paciente(34493020, "Masculino", System.DateTime.Today, hab1.Camas.First(), "José", "Perez", "No Dependiente", null);
                       var pariente = new Pariente(24445102, "Marcela", "Perez", "1150170733", null, "Hija", "Francia 550", "MarcelgaPerez@gmail.com", null);
                       pariente.Pacientes.Add(paciente);
                       paciente.Parientes.Add(pariente);
                       paciente = repositorioPaciente.Agregar(paciente);
                    }
                    LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();
                    idLibroGuardias.Paciente = paciente;
                    idLibroGuardias.Turno = "Diurno, Actividad Física";
                    idLibroGuardias.Usuario = RespLegal;
                    var actividadFisica = repositorioLibroDeGuardias.ObtenerPorId(idLibroGuardias);
                    if (actividadFisica == null)
                    {
                        actividadFisica = new LibroDeGuardias() { Id = idLibroGuardias };
                        actividadFisica.ActividadRealizada = "Yoga";
                        actividadFisica.Fecha = System.DateTime.Today;
                        actividadFisica = repositorioLibroDeGuardias.Agregar(actividadFisica);
                    }

                    List<Pariente> parientes = repositorioPariente.ObtenerParientesNoAsociados(paciente.Parientes.ToList()).ToList();
                    
                }
                catch (Exception e)
                {
                    LogueadorErrores.Loguear(e);
                }
            }
        }
    }
}
