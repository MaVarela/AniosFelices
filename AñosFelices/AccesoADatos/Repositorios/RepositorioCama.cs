using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad cama
    /// </summary>
    public class RepositorioCama : IRepositorioCama
    {
        /// <summary>
        /// Permite persistir una cama
        /// </summary>
        /// <param name="obj">Cama a persistir</param>
        /// <return>Cama</return>
        public Cama Agregar(Cama obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    obj.Estado = "L";
                    session.Save(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite editar una cama
        /// </summary>
        /// <param name="obj">Cama modificada</param>
        /// <return>Cama</return>
        public Cama Editar(Cama obj)
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
        /// Permite inhabilitar una cama
        /// </summary>
        /// <param name="obj">Cama a inhabilitar</param>
        /// <return>Cama</return>
        public Cama Inhabilitar(Cama obj)
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
        /// Permite recuperar una cama en base a su identificador
        /// </summary>
        /// <param name="id">Identificador de la cama</param>
        /// <returns>Una cama</returns>
        public Cama ObtenerPorId(CamaId id)
        {
            if (id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<Cama>(id);
            }
            return null;
        }

        /// <summary>
        /// Permite recuperar un listado de camas
        /// </summary>
        /// <returns>Una lista de camas</returns>
        public IList<Cama> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var camas = session
                    .CreateCriteria(typeof(Cama))
                    .List<Cama>();
                return camas;
            }
        }
    }
}
