using AniosFelicesSystem.EntidadesDeNegocio;
using System;
using System.Globalization;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Identificador de Libro de guardias
    /// </summary>
    public class LibroDeGuardiasId
    {
        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Turno
        /// </summary>
        public virtual String Turno { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            LibroDeGuardiasId Id = obj as LibroDeGuardiasId;

            if (Id == null)
                return false;
            return this.Paciente.Equals(Id.Paciente) && this.Usuario.Equals(Id.Usuario) && this.Turno.Equals(Id.Turno);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if (this.Usuario == null || this.Paciente == null || this.Turno == null)
                return base.GetHashCode();
            return (String.Format(CultureInfo.InvariantCulture, "{0}@@{1}@@{2}", this.Paciente.GetHashCode(), this.Usuario.GetHashCode(), this.Turno.GetHashCode())).GetHashCode();
        }

        /// <summary>
        /// Retorna el Identificador de Libro de guardias en forma de String
        /// </summary>
        /// <returns>Retorna el Identificador de Libro de guardias en forma de String</returns>
        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Paciente: {0}, Usuario: {1}, Turno: {2}",
                this.Paciente.ToString(),
                this.Usuario.ToString(),
                this.Turno.ToString());
        }
    }
}
