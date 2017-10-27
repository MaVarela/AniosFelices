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
        public void Agregar(Rol obj)
        {
            if(obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(obj);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Permite editar un rol
        /// </summary>
        /// <param name="obj">Rol modificado</param>
        public void Editar(Rol obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {

                    session.Update(obj);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Permite inhabilitar un rol (Método no implementado)
        /// </summary>
        /// <param name="obj">Rol a inhabilitar</param>
        public void Inhabilitar(Rol obj)
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
            if (id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<Rol>(id);
            }
            return null;
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
