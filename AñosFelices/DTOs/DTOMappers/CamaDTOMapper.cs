using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;

namespace AñosFelices.DTOs.DTOMappers
{
    public class CamaDTOMapper
    {
        /// <summary>
        /// Retorna un listado de DTOs de Cama
        /// </summary>
        /// <param name="camas">Listado de camas</param>
        /// <returns>Listado de DTOs Cama</returns>
        public List<CamaDTO> LlenarListado(List<Cama> camas)
        {
            var listadoCamas = new List<CamaDTO>();

            foreach (var cama in camas)
            {
                var camaDTO = new CamaDTO();
                camaDTO.IdCama = cama.IdCama;
                camaDTO.IdHabitacion = cama.Habitacion.IdHabitacion;
                camaDTO.Estado = cama.Estado;

                listadoCamas.Add(camaDTO);
            }

            return listadoCamas;
        }

        /// <summary>
        /// Retorna un listado de DTOs de Cama
        /// </summary>
        /// <param name="camas">Listado de DTO camas</param>
        /// <returns>Listado de DTOs Cama</returns>
        public List<CamaDTO> LlenarListado(List<CamaDTO> camas)
        {
            var listadoCamas = new List<CamaDTO>();

            foreach (var cama in camas)
            {
                var camaDTO = new CamaDTO();
                camaDTO.IdCama = cama.IdCama;
                camaDTO.IdHabitacion = cama.IdHabitacion;
                camaDTO.Estado = cama.Estado;

                listadoCamas.Add(camaDTO);
            }

            return listadoCamas;
        }

        /// <summary>
        /// Retorna un listado de Camas
        /// </summary>
        /// <param name="camas">Listado de DTO camas</param>
        /// <returns>Listado de Cama</returns>
        public List<Cama> LlenarListadoBe(List<CamaDTO> camas)
        {
            var listadoCamas = new List<Cama>();

            foreach (var cama in camas)
            {
                var result = new Cama();
                result.IdCama = cama.IdCama;
                result.Estado = cama.Estado == "Libre" ? "L" : "O";

                listadoCamas.Add(result);
            }

            return listadoCamas;
        }
    }
}
