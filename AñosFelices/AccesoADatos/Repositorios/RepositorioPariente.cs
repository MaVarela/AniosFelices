using AniosFelicesSystem.EntidadesDeNegocio;
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
        public void Agregar(Pariente obj)
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
        /// Permite editar un pariente
        /// </summary>
        /// <param name="obj">Pariente modificado</param>
        public void Editar(Pariente obj)
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
        /// Permite inhabilitar un pariente
        /// </summary>
        /// <param name="obj">Pariente a inhabilitar</param>
        public void Inhabilitar(Pariente obj)
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
