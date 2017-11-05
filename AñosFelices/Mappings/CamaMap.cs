using AñosFelices.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Cama
    /// </summary>
    public class CamaMap : ClassMap<Cama>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CamaMap()
        {
            Table("Camas");
            CompositeId(x => x.Id)
                .KeyReference(x => x.Habitacion, "IdHabitacion")
                .KeyProperty(x => x.IdCama, "IdCama");
            Map(x => x.Estado, "Estado").Not.Nullable();
        }
    }
}
