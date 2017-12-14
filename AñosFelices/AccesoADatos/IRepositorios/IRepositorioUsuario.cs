using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad usuario
    /// </summary>
    public interface IRepositorioUsuario : IRepositorioGenerico<Usuario, int>
    {
        /// <summary>
        /// Permite habilitar un usuario
        /// </summary>
        /// <param name="obj">Usuario a habilitar</param>
        /// <returns>Usuario</returns>
        Usuario Habilitar(Usuario obj);

        /// <summary>
        /// Verifica dado un dni si existe en la tabla de usuarios
        /// </summary>
        /// <param name="id">Identificador del Usuario</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        bool Existe(int id);
    }
}
