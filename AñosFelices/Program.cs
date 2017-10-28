using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using NHibernate;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AñosFelices
{
    //static class Program
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
            Console.WriteLine("Son todos unos forros, Arancibia.");


//        static void Main(string[] args){

//            Rol admin = new Rol("Administrador");
//            Rol enfermera = new Rol("Enfermera");
//            Rol medico = new Rol("Médico");

//            IRepositorioRol repositorioRol = new RepositorioRol();
//            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
//            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
//            IRepositorioCama repositorioCama = new RepositorioCama();
//            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
//            IRepositorioPariente repositorioPariente = new RepositorioPariente();

//            var rol1 = repositorioRol.ObtenerPorId(1);
//            var rol2 = repositorioRol.ObtenerPorId(2);
//            var rol3 = repositorioRol.ObtenerPorId(3);
//            if (rol1 == null)
//                repositorioRol.Agregar(admin);
//            if (rol2 == null)
//                repositorioRol.Agregar(enfermera);
//            if (rol3 == null)
//                repositorioRol.Agregar(medico);

//            rol1 = repositorioRol.ObtenerPorId(1);
//            rol3 = repositorioRol.ObtenerPorId(3);
//            if (rol1 != null)
//            {
//                var getAdmin = repositorioUsuario.ObtenerPorId(34493011);
//                if (getAdmin == null)
//                {
//                    Usuario administrador = new Usuario(34493011, rol1, "123456", "Mariano", "Varela", "México 751", "4736-7808", null, "marianovarela89@yahoo.es");
//                    repositorioUsuario.Agregar(administrador);
//                }
//            }
//            if (rol3 != null)
//            {
//                var getMedico = repositorioUsuario.ObtenerPorId(34493012);
//                if (getMedico == null)
//                {
//                    Usuario uMedico = new Usuario(34493012, rol3, "123456", "Juan", "Navarro", "Patagonia 235", "4740-2240", null, "juanNavarro@gmail.com");
//                    repositorioUsuario.Agregar(uMedico);
//                }
//            }

//            var hab1 = repositorioHabitacion.ObtenerPorId(1);
//            try
//            {
//                if (hab1 == null)
//                {
//                    Habitacion habitacion = new Habitacion("Hombres (Alta Dependencia)", null);
//                    Cama cama = new Cama(1, habitacion);
//                    Cama cama2 = new Cama(2, habitacion);
//                    habitacion.Camas.Add(cama);
//                    habitacion.Camas.Add(cama2);
//                    repositorioHabitacion.Agregar(habitacion);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }


//            hab1 = repositorioHabitacion.ObtenerPorId(1);
//            if (hab1 != null && hab1.Camas.Count() > 0)
//            {
//                try
//                {
//                    if (repositorioPaciente.ObtenerPorId(34493020) == null)
//                    {
//                        var paciente = new Paciente(34493020, hab1.Camas.First(), "Pepe", "Grillo", "No Dependiente", null);
//                        var pariente = new Pariente(34493021, "Pepa", "Pig", paciente, "1144342200", null, "Hija", "Calle 123", "PepaPig@gmail.com");
//                        paciente.Parientes.Add(pariente);
//                        repositorioPaciente.Agregar(paciente);
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//            }
        }
    }
}
