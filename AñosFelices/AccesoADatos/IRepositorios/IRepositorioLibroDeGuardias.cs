using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Libro de guardias
    /// </summary>
    public interface IRepositorioLibroDeGuardias : IRepositorioGenerico<LibroDeGuardias, long>
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

        /// <summary>
        /// Obtiene un registro de libro de guardias en base a los parámetros recibidos
        /// </summary>
        /// <param name="paciente">Paciente</param>
        /// <param name="turno">Turno</param>
        /// <param name="nombreCampo">Indica el tipo de registro</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        LibroDeGuardias ObtenerPorPacienteTurnoTipoRegistro(Paciente paciente, String turno, String nombreCampo);

        /// <summary>
        /// Verifica dado un dni si existe en la tabla de parientes
        /// </summary>
        /// <param name="id">Identificador del Pariente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        bool Existe(Paciente paciente, String turno, String nombreCampo);
    }
}
