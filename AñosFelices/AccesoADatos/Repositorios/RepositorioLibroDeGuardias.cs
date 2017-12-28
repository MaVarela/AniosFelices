using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Linq;
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
        public LibroDeGuardias ObtenerPorId(long id)
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
                criteria.CreateCriteria("Paciente", "Paciente", JoinType.InnerJoin);
                if(fecha != null)
                    criteria.Add(Restrictions.Eq("Fecha", fecha));
                if (!String.IsNullOrEmpty(nombre))
                    criteria.Add(Restrictions.Like("Paciente.Nombre", nombre, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(apellido))
                    criteria.Add(Restrictions.Like("Paciente.Apellido", apellido, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(turno))
                    criteria.Add(Restrictions.Like("Turno", turno, MatchMode.Anywhere));

                var registrosLibroDeGuardias = criteria.List<LibroDeGuardias>();

                return registrosLibroDeGuardias;
            }
        }

        /// <summary>
        /// Verifica dado un dni si existe en la tabla de parientes
        /// </summary>
        /// <param name="id">Identificador del Pariente</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        public bool Existe(Paciente paciente, String turno, String nombreCampo)
        {
            bool existe = false;

            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(LibroDeGuardias));
                criteria.Add(Restrictions.Eq("Fecha", DateTime.Today));
                criteria.Add(Restrictions.Eq("Paciente.Dni", paciente.Dni));
                if (!String.IsNullOrEmpty(turno))
                    criteria.Add(Restrictions.Like("Turno", turno, MatchMode.Anywhere));
                if(!String.IsNullOrEmpty(nombreCampo))
                {
                    if(nombreCampo == "ActividadRealizada")
                        criteria.Add(Restrictions.IsNotNull("ActividadRealizada"));
                    if (nombreCampo == "ComidaRealizada")
                        criteria.Add(Restrictions.IsNotNull("ComidaRealizada"));
                    if (nombreCampo == "")
                    {
                        criteria.Add(Restrictions.IsNotNull("MedicacionAdministrada"));
                        criteria.Add(Restrictions.IsNotNull("Temperatura"));
                        criteria.Add(Restrictions.IsNotNull("Azucar"));
                        criteria.Add(Restrictions.IsNotNull("Observaciones"));
                        criteria.Add(Restrictions.IsNotNull("Recomendaciones"));
                    }
                }

                var registrosLibroDeGuardias = criteria.List<LibroDeGuardias>();

                existe = (registrosLibroDeGuardias.Count > 0);
            }
            return existe;
        }

        /// <summary>
        /// Obtiene un registro de libro de guardias en base a los parámetros recibidos
        /// </summary>
        /// <param name="paciente">Paciente</param>
        /// <param name="turno">Turno</param>
        /// <param name="nombreCampo">Indica el tipo de registro</param>
        /// <returns>True en caso que exista, false en caso contrario</returns>
        public LibroDeGuardias ObtenerPorPacienteTurnoTipoRegistro(Paciente paciente, String turno, String nombreCampo, DateTime fecha)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(LibroDeGuardias));
                criteria.Add(Restrictions.Eq("Fecha", fecha));
                criteria.Add(Restrictions.Eq("Paciente.Dni", paciente.Dni));
                if (!String.IsNullOrEmpty(turno))
                    criteria.Add(Restrictions.Like("Turno", turno, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(nombreCampo))
                {
                    if (nombreCampo == "ActividadRealizada")
                        criteria.Add(Restrictions.IsNotNull("ActividadRealizada"));
                    if (nombreCampo == "ComidaRealizada")
                        criteria.Add(Restrictions.IsNotNull("ComidaRealizada"));
                    if (nombreCampo == "")
                    {
                        criteria.Add(Restrictions.IsNotNull("MedicacionAdministrada"));
                        criteria.Add(Restrictions.IsNotNull("Temperatura"));
                        criteria.Add(Restrictions.IsNotNull("Azucar"));
                        criteria.Add(Restrictions.IsNotNull("Observaciones"));
                        criteria.Add(Restrictions.IsNotNull("Recomendaciones"));
                    }
                }

                var registrosLibroDeGuardias = criteria.List<LibroDeGuardias>();

                return registrosLibroDeGuardias.FirstOrDefault();
            }
        }
    }
}
