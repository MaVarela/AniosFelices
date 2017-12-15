using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;
using System;
using NHibernate.Criterion;

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
        /// <returns>Usuario</returns>
        public Usuario Agregar(Usuario obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "A";
                    session.Save(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite editar un usuario
        /// </summary>
        /// <param name="obj">Usuario modificado</param>
        /// <returns>Usuario</returns>
        public Usuario Editar(Usuario obj)
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
        /// Permite inhabilitar un usuario
        /// </summary>
        /// <param name="obj">Usuario a inhabilitar</param>
        /// <returns>Usuario</returns>
        public Usuario Inhabilitar(Usuario obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "B";
                    session.Update(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite habilitar un usuario
        /// </summary>
        /// <param name="obj">Usuario a habilitar</param>
        /// <returns>Usuario</returns>
        public Usuario Habilitar(Usuario obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "A";
                    session.Update(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
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
        /// Verifica dado un dni si existe en la tabla de usuarios
        /// </summary>
        /// <param name="id">Identificador del Usuario</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        public bool Existe(int id)
        {
            bool existe = false;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                existe = (session.Get<Usuario>(id) != null);
            }
            return existe;
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

        public IList<Usuario> BuscarRegistros(int? rol, String nombre, String apellido)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(Usuario));

                if (rol != null)
                {
                    criteria.CreateAlias("Rol", "rol");
                    criteria.Add(Expression.Eq("rol.IdRol", rol));
                }

                if (!String.IsNullOrEmpty(apellido))
                    criteria.Add(Restrictions.Like("Apellido", apellido, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(nombre))
                    criteria.Add(Restrictions.Like("Nombre", nombre, MatchMode.Anywhere));

                var registrosUsuarios = criteria.List<Usuario>();

                return registrosUsuarios;
            }
        }
    }
}
