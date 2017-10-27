using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using NHibernate;
using System;
using System.Linq;

namespace AñosFelices
{
    //static class Program
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        //static void Main()
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPrincipal());

            /*
            Rol fantasma = new Rol("Fantasma");
            Rol admin = new Rol("Administrador");
            Rol enfermera = new Rol("Enfermera");
            Rol medico = new Rol("Médico");
            */

            IRepositorioRol repositorioRol = new RepositorioRol();
            IRepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            IRepositorioHabitacion repositorioHabitacion = new RepositorioHabitacion();
            IRepositorioCama repositorioCama = new RepositorioCama();
            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            //repositorioRol.Agregar(fantasma);
            //repositorioRol.Agregar(admin);
            //repositorioRol.Agregar(enfermera);
            //repositorioRol.Agregar(medico);


            /*var roles = repositorioRol.ObtenerTodos();
            if (roles.Count() > 0)
            {
                foreach(var rol in roles)
                {
                    Console.WriteLine(rol.IdRol.ToString() + ": " + rol.Descripcion);
                }
            }*/
            
            var rol3 = repositorioRol.ObtenerPorId(3);
            if (rol3 != null)
            {
                Console.WriteLine(rol3.IdRol.ToString() + ": " + rol3.Descripcion);
                //Usuario administrador = new Usuario(34493011, rol, "123456", "Mariano", "Varela", "México 751", "4736-7808", null, "marianovarela89@yahoo.es");
                /*Usuario medico = new Usuario(34493012, rol, "123456", "Juan", "Navarro", "Patagonia 235", "4740-2240", null, "juanNavarro@gmail.com");
                repositorioUsuario.Agregar(medico);
                var usuario = repositorioUsuario.ObtenerPorId(34493012);
                if(usuario != null)
                    Console.WriteLine(usuario.Dni.ToString() + ": " + usuario.Nombre + ", " + usuario.Apellido);*/
            }
            /*
            rol.Descripcion = "Administrador";
            repositorioRol.Update(rol);

            rol = repositorioRol.ObtenerPorId(1);
            Console.WriteLine("Rol Actualizado " + rol.IdRol.ToString() + ": " + rol.Descripcion);
             */

            Habitacion habitacion = new Habitacion("Hombres (Alta Dependencia)", null);
            Habitacion habitacion2 = new Habitacion("Mujeres (Alta Dependencia)", null);
            /*repositorioHabitacion.Agregar(habitacion);
            repositorioHabitacion.Agregar(habitacion2);*/
            /*habitacion = repositorioHabitacion.ObtenerPorId(1);
            if(habitacion.Camas.Count() > 0)
            {
                habitacion.Categoria = "Hombres (No Dependientes)";

                /*
                foreach (var cama in habitacion.Camas)
                {
                    cama.Estado = "L";
                }
                
            }*/
            //repositorioHabitacion.Editar(habitacion);
            //habitacion2 = repositorioHabitacion.ObtenerPorId(2);
            /*if (habitacion != null)
            {
                Cama cama = new Cama(1, habitacion);
                Cama cama2 = new Cama(2, habitacion);
                //repositorioCama.Agregar(cama);
                repositorioCama.Agregar(cama2);
            }
            if (habitacion2 != null)
            {
                Cama cama = new Cama(1, habitacion2);
                Cama cama2 = new Cama(2, habitacion2);
                //repositorioCama.Agregar(cama);
                repositorioCama.Agregar(cama2);
            }*/

            habitacion = repositorioHabitacion.ObtenerPorId(1);
            if (habitacion.Camas.Count() > 0)
            {
                var paciente = new Paciente(34493020, habitacion.Camas.First(), "Pepe", "Grillo", "No Dependiente");
                repositorioPaciente.Agregar(paciente);
            }
        }
    }
}
