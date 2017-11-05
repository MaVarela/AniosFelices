using System;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Rol
    /// </summary>
    public class Rol
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Rol()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="descripcion">Descripción del rol</param>
        public Rol(String descripcion)
        {
            this.Descripcion = descripcion;
        }

        /// <summary>
        /// Identificador del rol
        /// </summary>
        public virtual int IdRol { get; set; }

        /// <summary>
        /// Descripción del rol
        /// </summary>
        public virtual String Descripcion { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Rol);
            if (entidad == null)
                return false;
            return (this.IdRol.Equals(entidad.IdRol));
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            return IdRol.GetHashCode();
        }
    }
}
