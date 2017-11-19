using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad Paciente
    /// </summary>
    public class RepositorioPaciente : IRepositorioPaciente
    {
        /// <summary>
        /// Permite persistir un Paciente
        /// </summary>
        /// <param name="obj">Paciente a persistir</param>
        /// <returns>Paciente</returns> 
        public Paciente Agregar(Paciente obj)
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
            return null;
        }

        /// <summary>
        /// Permite editar un Paciente
        /// </summary>
        /// <param name="obj">Paciente modificado</param>
        /// <returns>Paciente</returns> 
        public Paciente Editar(Paciente obj)
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
        /// Permite inhabilitar un Paciente
        /// </summary>
        /// <param name="obj">Paciente a inhabilitar</param>
        /// <returns>Paciente</returns> 
        public Paciente Inhabilitar(Paciente obj)
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
        /// Permite recuperar un Paciente en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del Paciente</param>
        /// <returns>Un usuario</returns>
        public Paciente ObtenerPorId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Paciente>(id);
        }

        /// <summary>
        /// Permite recuperar un listado de Pacientes
        /// </summary>
        /// <returns>Una lista de Pacientes</returns>
        public IList<Paciente> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var pacientes = session
                    .CreateCriteria(typeof(Paciente))
                    .List<Paciente>();
                return pacientes;
            }
        }

        public void Borrar(Paciente obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(obj);
                    transaction.Commit();
                }
            }
        }
    }
}
