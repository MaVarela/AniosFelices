using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using AñosFelices.DTOs;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad Libro de guardias
    /// </summary>
    public class RepositorioLibroDeGuardias : IRepositorioLibroDeGuardias
    {
        /// <summary>
        /// Permite persistir un registro en el libro de guardias
        /// </summary>
        /// <param name="obj">Registro a persistir</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Agregar(LibroDeGuardias obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(obj);
                    transaction.Commit();
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite editar un registro del libro de guardias (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a editar</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Editar(LibroDeGuardias obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite inhabilitar un registro del libro de guardias (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a inhabilitar</param>
        /// <return>LibroDeGuardias</return>
        public LibroDeGuardias Inhabilitar(LibroDeGuardias obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite recuperar un registro del libro de guardias en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del registro de libro de guardias</param>
        /// <returns>Un registro del libro de guardias</returns>
        public LibroDeGuardias ObtenerPorId(LibroDeGuardiasId id)
        {
            if(id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<LibroDeGuardias>(id);
            }
            return null;
        }

        /// <summary>
        /// Permite recuperar un listado de los registros de libro de guardias
        /// </summary>
        /// <returns>Una lista de registros del libro de guardias</returns>
        public IList<LibroDeGuardias> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var registrosLibroDeGuardias = session
                    .CreateCriteria(typeof(LibroDeGuardias))
                    .List<LibroDeGuardias>();
                return registrosLibroDeGuardias;
            }
        }

        /// <summary>
        /// Obtiene registros de libro de guardias en en base a los filtros
        /// </summary>
        /// <param name="fecha">Fecha</param>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <param name="turno">Turno</param>
        /// <returns>Un listado</returns>
        public IList<LibroDeGuardias> BuscarRegistros(DateTime? fecha, String nombre, String apellido, String turno)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(LibroDeGuardias));
                criteria.CreateCriteria("Id.Paciente", "Paciente", JoinType.InnerJoin);
                if(fecha != null)
                    criteria.Add(Restrictions.Eq("Fecha", fecha));
                if (!String.IsNullOrEmpty(nombre))
                    criteria.Add(Restrictions.Like("Paciente.Nombre", nombre, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(apellido))
                    criteria.Add(Restrictions.Like("Paciente.Apellido", apellido, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(turno))
                    criteria.Add(Restrictions.Like("Id.Turno", turno, MatchMode.Anywhere));

                var registrosLibroDeGuardias = criteria.List<LibroDeGuardias>();

                return registrosLibroDeGuardias;
            }
        }

        public void Borrar(LibroDeGuardias obj)
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
