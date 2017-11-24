using AñosFelices.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Habitación
    /// </summary>
    public class HabitacionMap : ClassMap<Habitacion>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HabitacionMap()
        {
            Table("Habitaciones");
            Id(x => x.IdHabitacion, "IdHabitacion").GeneratedBy.Increment();
            Map(x => x.Estado, "Estado");
            Map(x => x.Categoria, "Categoria");
            HasMany<Cama>(x => x.Camas)
                .AsSet()
                .Not.LazyLoad()
                .KeyColumn("IdHabitacion")
                .Cascade.SaveUpdate()
                .Cascade.AllDeleteOrphan()
                .Inverse();
        }
    }
}
