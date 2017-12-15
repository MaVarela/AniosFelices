using AñosFelices.EntidadesDeNegocio;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.Mappings
{
    public class LibroDeGuardiasMap : ClassMap<LibroDeGuardias>
    {
        public LibroDeGuardiasMap()
        {
            Table("LibroDeGuardias");
            Id(x => x.Id, "IdLibroDeGuardia").GeneratedBy.Increment();
            References(x => x.Usuario)
                .Column("DniUsuario")
                .Class<Usuario>()
                .Not.Nullable()
                .Not.LazyLoad();
            References(x => x.Paciente)
                .Column("DniPaciente")
                .Class<Paciente>()
                .Not.Nullable()
                .Not.LazyLoad();
            Map(x => x.Turno, "Turno");
            Map(x => x.MedicacionAdministrada, "MedAdministrada");
            Map(x => x.Observaciones, "Observaciones");
            Map(x => x.Presion, "Presion");
            Map(x => x.Recomendaciones, "Recomendaciones");
            Map(x => x.Temperatura, "Temperatura");
            Map(x => x.ComidaRealizada, "ComidaRealizada");
            Map(x => x.Azucar, "Azucar");
            Map(x => x.ActividadRealizada, "ActRealizada");
            Map(x => x.Fecha, "Fecha").Not.Nullable();
        }
    }
}
