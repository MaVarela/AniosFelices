using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Paciente
    /// </summary>
    public interface IRepositorioPaciente : IRepositorioGenerico<Paciente, int>
    {
        /// <summary>
        /// Verifica dado un dni si existe en la tabla de pacientes
        /// </summary>
        /// <param name="id">Identificador del Paciente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        bool Existe(int id);
    }
}
