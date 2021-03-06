﻿using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using NHibernate.Criterion;

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
        /// Verifica dado un dni si existe en la tabla de parientes
        /// </summary>
        /// <param name="id">Identificador del Pariente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        public bool Existe(int id)
        {
            bool existe = false;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                existe = (session.Get<Pariente>(id) != null);
            }
            return existe;
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

        /// <summary>
        /// Permite recuperar un listado de parientes no asociados a un paciente
        /// </summary>
        /// <returns>Una lista de parientes</returns>
        public IList<Pariente> ObtenerParientesNoAsociados(List<Pariente> parientesAsociados)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var parientes = session
                    .CreateCriteria(typeof(Pariente), "pariente")
                    .Add(Restrictions.Not(Expression.In("Dni", parientesAsociados.Select(x => x.Dni).ToList())))
                    .List<Pariente>();
                return parientes;
            }
        }
    }
}
