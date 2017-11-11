using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Historía clínica
    /// </summary>
    public interface IRepositorioHistoriaClinica : IRepositorioGenerico<HistoriaClinica, HistoriaClinicaId>
    {
        /// <summary>
        /// Obtiene registros de historia clínica en en base a los filtros
        /// </summary>
        /// <param name="dni">Dni del paciente</param>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <returns>Un listado</returns>
        IList<HistoriaClinica> BuscarRegistros(int? dni, String nombre, String apellido);

        /// <summary>
        /// Permite recuperar un registro de Historia clínica en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del registro de Historia clínica</param>
        /// <returns>Un registro de Historia clínica</returns>
        IList<HistoriaClinica> ObtenerPorUsuarioPacienteFecha(HistoriaClinicaId id);
    }
}
