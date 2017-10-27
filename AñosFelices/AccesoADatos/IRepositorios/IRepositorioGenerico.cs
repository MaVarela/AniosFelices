using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void Agregar(T obj);

        /// <summary>
        /// Permite editar un registro
        /// </summary>
        /// <param name="obj">Objeto modificado</param>
        void Editar(T obj);
        
        /// <summary>
        /// Permite remover un registro
        /// </summary>
        /// <param name="obj">Objeto a remover</param>
        void Inhabilitar(T obj);

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
    }
}
