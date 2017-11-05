using AñosFelices.EntidadesDeNegocio;
using FluentNHibernate.Mapping;

namespace AñosFelices.Mappings
{
    /// <summary>
    /// Mappint de Historia Clínica
    /// </summary>
    public class HistoriaClinicaMap : ClassMap<HistoriaClinica>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HistoriaClinicaMap()
        {
            Table("HistoriasClinicas");
            CompositeId(x => x.Id)
                .KeyReference(x => x.Paciente, "DniPaciente")
                .KeyReference(x => x.Usuario, "DniUsuario")
                .KeyProperty(x => x.FechaVisita, "FechaVisita");
            Map(x => x.EstadoGeneral, "EstadoGeneral");
            Map(x => x.MedicacionRecomendada, "MedRecomendada");
            Map(x => x.RecomendacionActividadFisica, "RecActFisica");
            Map(x => x.RecomendacionAlimentaria, "RecAlimentaria");
        }
    }
}
