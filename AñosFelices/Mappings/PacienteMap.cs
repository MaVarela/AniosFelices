using AniosFelicesSystem.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Paciente
    /// </summary>
    public class PacienteMap : ClassMap<Paciente>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PacienteMap()
        {
            Id(x => x.Dni, "DniPariente").GeneratedBy.Assigned().Not.Nullable();
            Map(x => x.Nombre, "Nombre").Not.Nullable();
            Map(x => x.Apellido, "Apellido").Not.Nullable();
            Map(x => x.Estado, "Estado").Not.Nullable();
            Map(x => x.EstadoFisico, "EstadoFisico");
            References(x => x.Cama)
                .Columns("IdCama","IdHabitacion")
                .Class<Cama>()
                .Not.Nullable();
        }
    }
}
