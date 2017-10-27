using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad usuario
    /// </summary>
    public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Permite persistir un usuario
        /// </summary>
        /// <param name="obj">Usuario a persistir</param>
        public void Agregar(Usuario obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "A";
                    session.Save(obj);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Permite editar un usuario
        /// </summary>
        /// <param name="obj">Usuario modificado</param>
        public void Editar(Usuario obj)
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
        /// Permite inhabilitar un usuario
        /// </summary>
        /// <param name="obj">Usuario a inhabilitar</param>
        public void Inhabilitar(Usuario obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "B";
                    session.Update(obj);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Permite recuperar un usuario en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        /// <returns>Un usuario</returns>
        public Usuario ObtenerPorId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Usuario>(id);
        }

        /// <summary>
        /// Permite recuperar un listado de usuarios
        /// </summary>
        /// <returns>Una lista de usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var usuarios = session
                    .CreateCriteria(typeof(Usuario))
                    .List<Usuario>();
                return usuarios;
            }
        }
    }
}
