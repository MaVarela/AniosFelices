using AniosFelicesSystem.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Rol
    /// </summary>
    public class RolMap : ClassMap<Rol>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RolMap()
        {
            Id(x => x.IdRol, "IdRol").GeneratedBy.Increment();
            Map(x => x.Descripcion, "Descripcion").Not.Nullable();
        }
    }
}
