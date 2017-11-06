using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.Utilidades;
using System;
using System.Linq;

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
            Rol admin = new Rol("Administrador");
            Rol enfermera = new Rol("Enfermera");
            Rol medico = new Rol("Médico");
            Rol fantasma = new Rol("Fantasma");

            IRepositorioRol repositorioRol = new RepositorioRol();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
            IRepositorioCama repositorioCama = new RepositorioCama();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            IRepositorioPariente repositorioPariente = new RepositorioPariente();

            var rol1 = repositorioRol.ObtenerPorId(1);
            var rol2 = repositorioRol.ObtenerPorId(2);
            var rol3 = repositorioRol.ObtenerPorId(3);
            var rol4 = repositorioRol.ObtenerPorId(4);
            if (rol1 == null)
                rol1 = repositorioRol.Agregar(admin);
            if (rol2 == null)
                rol2 = repositorioRol.Agregar(enfermera);
            if (rol3 == null)
                rol3 = repositorioRol.Agregar(medico);
            if (rol4 == null)
                rol4 = repositorioRol.Agregar(fantasma);

            if (rol1 != null)
            {
                var getAdmin = repositorioUsuario.ObtenerPorId(34493011);
                if (getAdmin == null)
                {
                    Usuario administrador = new Usuario(34493011, rol1, "123456", "Mariano", "Varela", "México 751", "4736-7808", null, "marianovarela89@yahoo.es");
                    repositorioUsuario.Agregar(administrador);
                }
            }
            if (rol3 != null)
            {
                var getMedico = repositorioUsuario.ObtenerPorId(34493012);
                if (getMedico == null)
                {
                    Usuario uMedico = new Usuario(34493012, rol3, "123456", "Juan", "Navarro", "Patagonia 235", "4740-2240", null, "juanNavarro@gmail.com");
                    repositorioUsuario.Agregar(uMedico);
                }
            }

            var hab1 = repositorioHabitacion.ObtenerPorId(1);
            try
            {
                if (hab1 == null)
                {
                    Habitacion habitacion = new Habitacion("Hombres (Alta Dependencia)", null);
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

            if (hab1 != null && hab1.Camas.Count() > 0)
            {
                try
                {
                    if (repositorioPaciente.ObtenerPorId(34493020) == null)
                    {
                        var paciente = new Paciente(34493020, hab1.Camas.First(), "Pepe", "Grillo", "No Dependiente", null);
                        var pariente = new Pariente(34493021, "Pepa", "Pig", paciente, "1144342200", null, "Hija", "Calle 123", "PepaPig@gmail.com");
                        paciente.Parientes.Add(pariente);
                        repositorioPaciente.Agregar(paciente);
                    }
                }
                catch (Exception e)
                {
                    LogueadorErrores.Loguear(e);
                }
            }
        }
    }
}
