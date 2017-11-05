using AñosFelices.EntidadesDeNegocio;
using System;
using System.Globalization;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Identificador de cama
    /// </summary>
    public class CamaId
    {
        /// <summary>
        /// Número de la cama
        /// </summary>
        public virtual int IdCama { get; set; }

        /// <summary>
        /// Habitación a la que pertenece la cama
        /// </summary>
        public virtual Habitacion Habitacion { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            CamaId Id = obj as CamaId;

            if (Id == null)
                return false;
            return this.IdCama.Equals(Id.IdCama) && this.Habitacion.Equals(Id.Habitacion);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if (this.Habitacion == null)
                return base.GetHashCode();
            return (String.Format(CultureInfo.InvariantCulture, "{0}@@{1}", this.IdCama.GetHashCode(), this.Habitacion.IdHabitacion.GetHashCode())).GetHashCode();
        }

        /// <summary>
        /// Retorna el Identificador de Cama en forma de String
        /// </summary>
        /// <returns>Retorna el Identificador de Cama en forma de String</returns>
        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Nro. Cama: {0}, Habitación: {1}",
                this.IdCama.ToString(),
                this.Habitacion.IdHabitacion.ToString());
        }
    }
}
