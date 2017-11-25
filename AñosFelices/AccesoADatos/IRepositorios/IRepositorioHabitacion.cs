using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad habitacion
    /// </summary>
    public interface IRepositorioHabitacion : IRepositorioGenerico<Habitacion, int>
    {
        /// <summary>
        /// Permite habilitar un habitación
        /// </summary>
        /// <param name="obj">Habitación a habilitar</param>
        /// <returns>Habitación</returns>
        Habitacion Habilitar(Habitacion obj);
    }
}
