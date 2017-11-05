using System;
using System.Collections.Generic;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Habitación
    /// </summary>
    public class Habitacion
    {
        /// <summary>
        /// Cconstructor
        /// </summary>
        public Habitacion()
        {
            this.Camas = new List<Cama>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="categoria">Categoría de la habitación</param>
        /// <param name="estado">Estado</param>
        /// <param name="camas">Camas de la habitación</param>
        public Habitacion(String categoria, ICollection<Cama> camas)
        {
            this.Camas = camas != null ? camas : new List<Cama>();
            this.Categoria = categoria;
        }

        /// <summary>
        /// Identificador de habitación
        /// </summary>
        public virtual int IdHabitacion { get; set; }

        /// <summary>
        /// Categoría de la habitación
        /// </summary>
        public virtual String Categoria { get; set; }

        /// <summary>
        /// Camas de la habitación
        /// </summary>
        public virtual ICollection<Cama> Camas { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Habitacion);
            if (entidad == null)
                return false;
            return (this.IdHabitacion.Equals(entidad.IdHabitacion));
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            return IdHabitacion.GetHashCode();
        }

    }
}
