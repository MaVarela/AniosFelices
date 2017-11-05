using AñosFelices.EntidadesDeNegocio;
using System;
using System.Globalization;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Identificador de Pariente
    /// </summary>
    public class ParienteId
    {
        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente { get; set; }

        /// <summary>
        /// Dni de Pariente
        /// </summary>
        public virtual int DniPariente { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            ParienteId Id = obj as ParienteId;

            if (Id == null)
                return false;
            return this.DniPariente.Equals(Id.DniPariente) && this.Paciente.Equals(Id.Paciente);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if (this.Paciente == null)
                return base.GetHashCode();
            return (String.Format(CultureInfo.InvariantCulture, "{0}@@{1}", this.DniPariente.GetHashCode(), this.Paciente.Dni.GetHashCode())).GetHashCode();
        }

        /// <summary>
        /// Retorna el Identificador de Pariente en forma de String
        /// </summary>
        /// <returns>Retorna el Identificador de Pariente en forma de String</returns>
        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Pariente: {0}, Paciente: {1}",
                this.DniPariente.ToString(),
                this.Paciente.Dni.ToString());
        }
    }
}
