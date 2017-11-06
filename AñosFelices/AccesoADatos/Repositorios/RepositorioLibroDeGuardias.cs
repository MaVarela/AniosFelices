using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Collections.Generic;
using AñosFelices.DTOs;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad Libro de guardias
    /// </summary>
    public class RepositorioLibroDeGuardias : IRepositorioLibroDeGuardias
    {
        /// <summary>
        /// Permite persistir un registro en el libro de guardias
        /// </summary>
        /// <param name="obj">Registro a persistir</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Agregar(LibroDeGuardias obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite editar un registro del libro de guardias (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a editar</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Editar(LibroDeGuardias obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite inhabilitar un registro del libro de guardias (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a inhabilitar</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Inhabilitar(LibroDeGuardias obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite recuperar un registro del libro de guardias en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del registro de libro de guardias</param>
        /// <returns>Un registro del libro de guardias</returns>
        public LibroDeGuardias ObtenerPorId(LibroDeGuardiasId id)
        {
            if(id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<LibroDeGuardias>(id);
            }
            return null;
        }

        /// <summary>
        /// Permite recuperar un listado de los registros de libro de guardias
        /// </summary>
        /// <returns>Una lista de registros del libro de guardias</returns>
        public IList<LibroDeGuardias> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var registrosLibroDeGuardias = session
                    .CreateCriteria(typeof(LibroDeGuardias))
                    .List<LibroDeGuardias>();
                return registrosLibroDeGuardias;
            }
        }
    }
}
