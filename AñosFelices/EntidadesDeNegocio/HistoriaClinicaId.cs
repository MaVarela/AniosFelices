using AñosFelices.EntidadesDeNegocio;
using System;
using System.Globalization;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Identificador de Historia Clínica
    /// </summary>
    public class HistoriaClinicaId
    {
        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente { get; set; }

        /// <summary>
        /// Fecha de visita del médico
        /// </summary>
        public virtual DateTime FechaVisita { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            HistoriaClinicaId Id = obj as HistoriaClinicaId;

            if (Id == null)
                return false;
            return this.Paciente.Equals(Id.Paciente) && this.Usuario.Equals(Id.Usuario) && this.FechaVisita.Equals(Id.FechaVisita);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if(this.Usuario == null || this.Paciente == null || this.FechaVisita == null)
                return base.GetHashCode();
            return (String.Format(CultureInfo.InvariantCulture, "{0}@@{1}@@{2}", this.Paciente.GetHashCode(), this.Usuario.GetHashCode(), this.FechaVisita.GetHashCode())).GetHashCode();
        }

        /// <summary>
        /// Retorna el Identificador de Historia Clínica en forma de String
        /// </summary>
        /// <returns>Retorna el Identificador de Historia Clínica en forma de String</returns>
        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Paciente: {0}, Usuario: {1}, FechaVisita: {2}",
                this.Paciente.ToString(),
                this.Usuario.ToString(),
                this.FechaVisita.ToShortDateString());
        }
    }
}
