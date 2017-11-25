using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;
using System.Linq;

namespace AñosFelices.DTOs.DTOMappers
{
    /// <summary>
    /// DTO Mapper de habitacion
    /// </summary>
    public class HabitacionDTOMapper
    {
        /// <summary>
        /// Retorna un listado de DTOs de Habitación
        /// </summary>
        /// <param name="habitaciones">Listado de habitaciones</param>
        /// <returns>Listado de DTOs Habitación</returns>
        public List<HabitacionDTO> LlenarListado(List<Habitacion> habitaciones)
        {
            var listadoHabitaciones = new List<HabitacionDTO>();

            foreach (var habitacion in habitaciones)
            {
                var habitacionDTO = new HabitacionDTO();
                habitacionDTO.Id = habitacion.IdHabitacion;
                habitacionDTO.Categoria = habitacion.Categoria;
                habitacionDTO.Estado = habitacion.Estado == "A" ? "Habilitada" : "Inhabilitada";

                listadoHabitaciones.Add(habitacionDTO);
            }

            return listadoHabitaciones;
        }

        /// <summary>
        /// Retorna un listado de DTOs de Habitación
        /// </summary>
        /// <param name="habitaciones">Listado de habitaciones</param>
        /// <returns>Listado de DTOs Habitación</returns>
        public List<HabitacionDTO> LlenarListadoConsultaEstado(List<Habitacion> habitaciones)
        {
            var listadoHabitaciones = new List<HabitacionDTO>();

            foreach (var habitacion in habitaciones)
            {
                var estado = habitacion.Camas.Where(x => x.Estado == "L").Count() > 0 ? "Disponible" : "Completa";

                var habitacionDTO = new HabitacionDTO();
                habitacionDTO.Id = habitacion.IdHabitacion;
                habitacionDTO.Categoria = habitacion.Categoria;
                habitacionDTO.Estado = habitacion.Estado == "B" ? "Inhabilitada" : estado;

                listadoHabitaciones.Add(habitacionDTO);
            }

            return listadoHabitaciones;
        }

        public List<HabitacionDTO> LlenarListadoSexo(List<Habitacion> habitaciones, string sexo)
        {
            var listadoHabitaciones = new List<HabitacionDTO>();

            foreach (var habitacion in habitaciones)
            {
                var habitacionDTO = new HabitacionDTO();
                habitacionDTO.Id = habitacion.IdHabitacion;
                habitacionDTO.Categoria = habitacion.Categoria;
                habitacionDTO.Estado = habitacion.Estado;

                string [] Sexo;
                Sexo = habitacionDTO.Categoria.Split(' ');
                //habitacionDTO.Categoria = Sexo[0];

                if (Sexo[0] == sexo)
                {
                    listadoHabitaciones.Add(habitacionDTO);
                }
            }

            return listadoHabitaciones;
        }
    }
}
