using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad Paciente
    /// </summary>
    public class RepositorioPariente : IRepositorioPariente
    {
        /// <summary>
        /// Permite persistir un pariente
        /// </summary>
        /// <param name="obj">Pariente a persistir</param>
        /// <returns>Pariente</returns> 
        public Pariente Agregar(Pariente obj)
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
        /// Permite editar un pariente
        /// </summary>
        /// <param name="obj">Pariente modificado</param>
        /// <returns>Pariente</returns> 
        public Pariente Editar(Pariente obj)
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
        /// Permite inhabilitar un pariente
        /// </summary>
        /// <param name="obj">Pariente a inhabilitar</param>
        /// <returns>Pariente</returns> 
        public Pariente Inhabilitar(Pariente obj)
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
        /// Permite recuperar un pariente en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del pariente</param>
        /// <returns>Un usuario</returns>
        public Pariente ObtenerPorId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Pariente>(id);
        }

        /// <summary>
        /// Permite recuperar un listado de parientes
        /// </summary>
        /// <returns>Una lista de parientes</returns>
        public IList<Pariente> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var parientes = session
                    .CreateCriteria(typeof(Pariente))
                    .List<Pariente>();
                return parientes;
            }
        }
    }
}
