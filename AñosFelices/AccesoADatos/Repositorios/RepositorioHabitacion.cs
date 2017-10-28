using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Collections.Generic;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad habitación
    /// </summary>
    public class RepositorioHabitacion : IRepositorioHabitacion
    {
        /// <summary>
        /// Permite persistir una habitación
        /// </summary>
        /// <param name="obj">Habitación a persistir</param>
        public void Agregar(Habitacion obj)
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
        /// Permite editar una habitación
        /// </summary>
        /// <param name="obj">Habitación modificada</param>
        public void Editar(Habitacion obj)
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
        /// Permite inhabilitar una habitación
        /// </summary>
        /// <param name="obj">Habitación a inhabilitar</param>
        public void Inhabilitar(Habitacion obj)
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
        /// Permite recuperar una habitación en base a su identificador
        /// </summary>
        /// <param name="id">Identificador de la habitación</param>
        /// <returns>Una habitación</returns>
        public Habitacion ObtenerPorId(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Habitacion>(id);
            }
        }

        /// <summary>
        /// Permite recuperar un listado de habitaciones
        /// </summary>
        /// <returns>Una lista de habitaciones</returns>
        public IList<Habitacion> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var habitaciones = session
                    .CreateCriteria(typeof(Habitacion))
                    .List<Habitacion>();
                return habitaciones;
            }
        }
    }
}
