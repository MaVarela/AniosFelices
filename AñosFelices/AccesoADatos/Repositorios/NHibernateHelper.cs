using AñosFelices.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Configuration;

namespace AñosFelices.AccesoADatos.Repositorios
{
    /// <summary>
    /// Controlador de Hibernate
    /// </summary>
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactoryGetInstance()
        {
            if(_sessionFactory == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
                var configuration = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString).ShowSql)
                    .Mappings(m => m.FluentMappings
                        .AddFromAssemblyOf<RolMap>()
                        .AddFromAssemblyOf<UsuarioMap>()
                        .AddFromAssemblyOf<PacienteMap>()
                        .AddFromAssemblyOf<ParienteMap>()
                        .AddFromAssemblyOf<CamaMap>()
                        .AddFromAssemblyOf<HabitacionMap>()
                        .AddFromAssemblyOf<LibroDeGuardiasMap>()
                        .AddFromAssemblyOf<HistoriaClinicaMap>()
                        .AddFromAssemblyOf<UsuarioMap>())
                    .BuildConfiguration();

                var exporter = new SchemaUpdate(configuration);
                exporter.Execute(true, true);

                _sessionFactory = configuration.BuildSessionFactory();
            }
            return _sessionFactory;
        }

        

        public static ISession OpenSession()
        {
            return SessionFactoryGetInstance().OpenSession();
        }
    }
}
