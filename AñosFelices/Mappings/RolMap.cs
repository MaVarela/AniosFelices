using AñosFelices.EntidadesDeNegocio;
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
            Table("Roles");
            Id(x => x.IdRol, "IdRol").GeneratedBy.Increment();
            Map(x => x.Descripcion, "Descripcion").Not.Nullable();
        }
    }
}
