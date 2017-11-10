using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Libro de guardias
    /// </summary>
    public interface IRepositorioLibroDeGuardias : IRepositorioGenerico<LibroDeGuardias, LibroDeGuardiasId>
    {
        /// <summary>
        /// Obtiene registros de libro de guardias en en base a los filtros
        /// </summary>
        /// <param name="fecha">Fecha</param>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <param name="turno">Turno</param>
        /// <returns>Un listado</returns>
        IList<LibroDeGuardias> BuscarRegistros(DateTime? fecha, String nombre, String apellido, String turno);
    }
}
