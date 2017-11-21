using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;
namespace AñosFelices.DTOs.DTOMappers
{
    /// <summary>
    /// DTO Mapper de rol
    /// </summary>
   public class RolDTOMapper
    {
        /// <summary>
        /// Retorna un listado de DTOs de Rol
        /// </summary>
        /// <param name="habitaciones">Listado de Roles</param>
        /// <returns>Listado de DTOs Rol</returns>
        public List<RolDTO> LlenarListado(List<Rol> roles)
        {
            var listadoRoles = new List<RolDTO>();

            foreach (var rol in roles)
            {
                var rolDTO = new RolDTO();
                rolDTO.IdRol = rol.IdRol;
                rolDTO.Descripcion = rol.Descripcion;

                listadoRoles.Add(rolDTO);
            }

            return listadoRoles;
        }
    }
}
