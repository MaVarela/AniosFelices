using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Pariente
    /// </summary>
    public interface IRepositorioPariente : IRepositorioGenerico<Pariente, int>
    {
        /// <summary>
        /// Verifica dado un dni si existe en la tabla de parientes
        /// </summary>
        /// <param name="id">Identificador del Pariente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        bool Existe(int id);

        /// <summary>
        /// Permite recuperar un listado de parientes no asociados a un paciente
        /// </summary>
        /// <returns>Una lista de parientes</returns>
        IList<Pariente> ObtenerParientesNoAsociados(List<Pariente> parientesAsociados);
    }
}
