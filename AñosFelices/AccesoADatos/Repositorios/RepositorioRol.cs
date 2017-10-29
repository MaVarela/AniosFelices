using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad rol
    /// </summary>
    public class RepositorioRol : IRepositorioRol
    {
        /// <summary>
        /// Permite persistir un rol
        /// </summary>
        /// <param name="obj">Rol a persistir</param>
        /// <returns>Rol</returns>
        public Rol Agregar(Rol obj)
        {
            if(obj != null)
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
        /// Permite editar un rol
        /// </summary>
        /// <param name="obj">Rol modificado</param>
        /// <returns>Rol</returns>
        public Rol Editar(Rol obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {

                    session.Update(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite inhabilitar un rol (Método no implementado)
        /// </summary>
        /// <param name="obj">Rol a inhabilitar</param>
        /// <returns>Rol</returns>
        public Rol Inhabilitar(Rol obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite recuperar un rol en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del rol</param>
        /// <returns>Un rol</returns>
        public Rol ObtenerPorId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Rol>(id);
            }
        }

        /// <summary>
        /// Permite recuperar un listado de roles
        /// </summary>
        /// <returns>Una lista de roles</returns>
        public IList<Rol> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var roles = session
                    .CreateCriteria(typeof(Rol))
                    .List<Rol>();
                return roles;
            }
        }
    }
}
