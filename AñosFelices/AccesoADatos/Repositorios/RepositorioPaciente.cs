using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Collections.Generic;
using System;
using NHibernate.Criterion;

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
        /// Verifica dado un dni si existe en la tabla de pacientes
        /// </summary>
        /// <param name="id">Identificador del Paciente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        public bool Existe(int id)
        {
            bool existe = false;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                existe = (session.Get<Paciente>(id) != null);
            }
            return existe;
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

        public IList<Paciente> BuscarRegistros(int? habitacion, String nombre, String apellido)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(Paciente));

                if (habitacion != null)
                {
                    criteria.CreateAlias("Cama", "cama");
                    criteria.Add(Expression.Eq("cama.Id.Habitacion.IdHabitacion", habitacion));
                }

                if (!String.IsNullOrEmpty(apellido))
                    criteria.Add(Restrictions.Like("Apellido", apellido, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(nombre))
                    criteria.Add(Restrictions.Like("Nombre", nombre, MatchMode.Anywhere));

                var registrosPacientes = criteria.List<Paciente>();

                return registrosPacientes;
            }
        }
    }
}
