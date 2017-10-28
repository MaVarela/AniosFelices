using AniosFelicesSystem.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Usuario
    /// </summary>
    public class UsuarioMap : ClassMap<Usuario>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioMap()
        {
            Table("Usuarios");
            Id(x => x.Dni, "DniUsuario").GeneratedBy.Assigned().Not.Nullable();
            Map(x => x.Nombre, "Nombre").Not.Nullable();
            Map(x => x.Apellido, "Apellido").Not.Nullable();
            Map(x => x.Direccion, "Direccion").Not.Nullable();
            Map(x => x.Mail, "Mail");
            Map(x => x.Telefono1, "Telefono1").Not.Nullable();
            Map(x => x.Telefono2, "Telefono2");
            Map(x => x.Estado, "Estado").Not.Nullable();
            Map(x => x.Password, "Password").Not.Nullable();
            References<Rol>(x => x.Rol, "IdRol").Not.Nullable();
        }
    }
}
