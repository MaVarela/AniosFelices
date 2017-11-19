using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz genérica de acceso a datos
    /// </summary>
    /// <typeparam name="T">Tipo de entidad</typeparam>
    public interface IRepositorioGenerico<T, TId>
    {
        /// <summary>
        /// Permite persistir un registro
        /// </summary>
        /// <param name="obj">Objeto a persistir</param>
        /// <returns>Objeto persistido</returns>
        T Agregar(T obj);

        /// <summary>
        /// Permite editar un registro
        /// </summary>
        /// <param name="obj">Objeto modificado</param>
        /// <returns>Objeto persistido</returns>
        T Editar(T obj);
        
        /// <summary>
        /// Permite remover un registro
        /// </summary>
        /// <param name="obj">Objeto a inhabilitar</param>
        /// <returns>Objeto persistido</returns>
        T Inhabilitar(T obj);

        /// <summary>
        /// Permite recuperar un registro en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del objeto</param>
        /// <returns>Un objeto</returns>
        T ObtenerPorId(TId id);

        /// <summary>
        /// Permite recuperar un listado de registros
        /// </summary>
        /// <returns>Una lista de objetos</returns>
        IList<T> ObtenerTodos();

        void Borrar(T obj);
    }
}
