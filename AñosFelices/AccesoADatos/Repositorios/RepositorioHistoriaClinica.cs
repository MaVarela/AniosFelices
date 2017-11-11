using AñosFelices.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using NHibernate;
using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Acceso a datos para la entidad Historia clínica
    /// </summary>
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        /// <summary>
        /// Permite persistir un registro de Historia clínica
        /// </summary>
        /// <param name="obj">Registro a persistir</param>
        /// <returns>HistoriaClinica</returns>
        public HistoriaClinica Agregar(HistoriaClinica obj)
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
        /// Permite editar un registro de Historia clínica (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a editar</param>
        /// <returns>HistoriaClinica</returns>
        public HistoriaClinica Editar(HistoriaClinica obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite inhabilitar un registro de Historia clínica (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a inhabilitar</param>
        /// <returns>HistoriaClinica</returns>
        public HistoriaClinica Inhabilitar(HistoriaClinica obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite recuperar un registro de Historia clínica en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del registro de Historia clínica</param>
        /// <returns>Un registro de Historia clínica</returns>
        public HistoriaClinica ObtenerPorId(HistoriaClinicaId id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite recuperar un registro de Historia clínica en base a su identificador
        /// </summary>
        /// <param name="id">Identificador del registro de Historia clínica</param>
        /// <returns>Un registro de Historia clínica</returns>
        public IList<HistoriaClinica> ObtenerPorUsuarioPacienteFecha(HistoriaClinicaId id)
        {
            if (id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    var criteria = session
                       .CreateCriteria(typeof(HistoriaClinica));
                    criteria.CreateCriteria("Id.Paciente", "Paciente", JoinType.InnerJoin);
                    criteria.CreateCriteria("Id.Usuario", "Usuario", JoinType.InnerJoin);
                    criteria.Add(Restrictions.Eq("Paciente.Dni", id.Paciente.Dni));
                    criteria.Add(Restrictions.Eq("Usuario.Dni", id.Usuario.Dni));
                    criteria.Add(Expression.Sql("convert(varchar(10), FechaVisita, 103) = convert(varchar(10), (?), 103)", id.FechaVisita.ToShortDateString(), NHibernateUtil.String));

                    var historiaClinica = criteria.List<HistoriaClinica>();

                    return historiaClinica;
                }
            }
            return null;
        }

        /// <summary>
        /// Permite recuperar un listado de los registros de Historia clínica
        /// </summary>
        /// <returns>Una lista de registros de Historia clínica</returns>
        public IList<HistoriaClinica> ObtenerTodos()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var registrosHistoriaClinica = session
                    .CreateCriteria(typeof(HistoriaClinica))
                    .List<HistoriaClinica>();
                return registrosHistoriaClinica;
            }
        }

        /// <summary>
        /// Obtiene registros de historia clínica en en base a los filtros
        /// </summary>
        /// <param name="dni">Dni del paciente</param>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <returns>Un listado</returns>
        public IList<HistoriaClinica> BuscarRegistros(int? dni, String nombre, String apellido)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var criteria = session
                    .CreateCriteria(typeof(HistoriaClinica));
                criteria.CreateCriteria("Id.Paciente", "Paciente", JoinType.InnerJoin);
                if (dni != null)
                    criteria.Add(Restrictions.Eq("Paciente.Dni", dni));
                if (!String.IsNullOrEmpty(nombre))
                    criteria.Add(Restrictions.Like("Paciente.Nombre", nombre, MatchMode.Anywhere));
                if (!String.IsNullOrEmpty(apellido))
                    criteria.Add(Restrictions.Like("Paciente.Apellido", apellido, MatchMode.Anywhere));

                var registrosHistoriaClinica = criteria.List<HistoriaClinica>();

                return registrosHistoriaClinica;
            }
        }
    }
}
