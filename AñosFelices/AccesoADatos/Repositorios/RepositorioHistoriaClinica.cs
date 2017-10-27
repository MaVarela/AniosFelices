using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.EntidadesDeNegocio;
using NHibernate;
using System;
using System.Collections.Generic;

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
        public void Agregar(HistoriaClinica obj)
        {
            if (obj != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(obj);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Permite editar un registro de Historia clínica (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a editar</param>
        public void Editar(HistoriaClinica obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permite inhabilitar un registro de Historia clínica (Método no implementado)
        /// </summary>
        /// <param name="obj">Registro a inhabilitar</param>
        public void Inhabilitar(HistoriaClinica obj)
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
            if(id != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<HistoriaClinica>(id);
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
    }
}
