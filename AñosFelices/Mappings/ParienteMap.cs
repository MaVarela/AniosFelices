﻿using AñosFelices.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mapping de Pariente
    /// </summary>
    public class ParienteMap : ClassMap<Pariente>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ParienteMap()
        {
            Table("Parientes");
            Id(x => x.Dni, "DniPariente").GeneratedBy.Assigned().Not.Nullable();
            Map(x => x.Nombre, "Nombre").Not.Nullable();
            Map(x => x.Apellido, "Apellido").Not.Nullable();
            Map(x => x.Direccion, "Direccion").Not.Nullable();
            Map(x => x.Mail, "Mail");
            Map(x => x.Telefono1, "Telefono1").Not.Nullable();
            Map(x => x.Telefono2, "Telefono2");
            Map(x => x.Estado, "Estado").Not.Nullable();
            Map(x => x.Parentezco, "Parentezco").Not.Nullable();
            HasManyToMany<Paciente>(x => x.Pacientes)
                    .AsSet()
                    .Not.LazyLoad()
                    .Table("PacientesParientes")
                    .ParentKeyColumn("DniPariente")
                    .ChildKeyColumn("DniPaciente")
                    .Inverse()
                    .Cascade.SaveUpdate();
        }
    }
}
