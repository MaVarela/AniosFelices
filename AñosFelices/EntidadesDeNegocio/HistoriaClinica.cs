using AñosFelices.EntidadesDeNegocio;
using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    /// <summary>
    /// Historia Clínica
    /// </summary>
    public class HistoriaClinica
    {
        /// <summary>
        /// Consturctor
        /// </summary>
        public HistoriaClinica()
        {
            this.Id = new HistoriaClinicaId();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paciente">Paciente</param>
        /// <param name="usuario">Usuario</param>
        /// <param name="fechaVisita">Fecha de visita del médico</param>
        /// <param name="recomendacionActividadFisica">Recomendación de actividad física</param>
        /// <param name="recomendacionAlimentaria">Recomendación alimentaria</param>
        /// <param name="medicacionRecomendada">Medicación recomendada</param>
        /// <param name="estadoGeneral">Estado general del paciente</param>
        public HistoriaClinica(Paciente paciente, Usuario usuario, DateTime fechaVisita, String recomendacionActividadFisica, String recomendacionAlimentaria, String medicacionRecomendada, String estadoGeneral)
        {
            this.Paciente = paciente;
            this.Usuario = usuario;
            this.FechaVisita = fechaVisita;
            this.RecomendacionActividadFisica = recomendacionActividadFisica;
            this.MedicacionRecomendada = medicacionRecomendada;
            this.RecomendacionAlimentaria = recomendacionAlimentaria;
            this.EstadoGeneral = estadoGeneral;
        }

        private HistoriaClinicaId historiaClinicaId {get;set;}

        /// <summary>
        /// Identificador de Historia Clínica
        /// </summary>
        public virtual HistoriaClinicaId Id
        {
            get { return this.historiaClinicaId; }
            set { this.historiaClinicaId = value; }
        }

        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente
        {
            get { return this.Id.Paciente; }
            set { this.Id.Paciente = value; }
        }

        /// <summary>
        /// Fecha de visita del médico
        /// </summary>
        public virtual DateTime FechaVisita
        {
            get { return this.Id.FechaVisita; }
            set { this.Id.FechaVisita = value; }
        }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual Usuario Usuario
        {
            get { return this.Id.Usuario; }
            set { this.Id.Usuario = value; }
        }

        /// <summary>
        /// Recomendación de actividad física
        /// </summary>
        public virtual String RecomendacionActividadFisica { get; set; }

        /// <summary>
        /// Recomendación alimentaria
        /// </summary>
        public virtual String RecomendacionAlimentaria { get; set; }

        /// <summary>
        /// Medicación recomendada
        /// </summary>
        public virtual String MedicacionRecomendada { get; set; }

        /// <summary>
        /// Estado general del paciente
        /// </summary>
        public virtual String EstadoGeneral { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as HistoriaClinica);
            if (entidad == null)
                return false;
            if (this.Id != null)
                return (this.Id.Equals(entidad.Id));
            return base.Equals(obj);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if (Id != null)
                return Id.GetHashCode();
            return base.GetHashCode();
        }
    }
}
