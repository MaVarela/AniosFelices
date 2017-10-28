using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    /// <summary>
    /// Persona
    /// </summary>
    public class Persona
    {
        public Persona()
        {

        }

        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public virtual String Nombre { get; set; }

        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public virtual String Apellido { get; set; }


        /// <summary>
        /// Teléfono de la persona
        /// </summary>
        public virtual String Telefono1 { get; set; }

        /// <summary>
        /// Teléfono de la persona
        /// </summary>
        public virtual String Telefono2 { get; set; }


        /// <summary>
        /// Dirección de la persona
        /// </summary>
        public virtual String Direccion { get; set; }

        /// <summary>
        /// Dirección de correo de la persona
        /// </summary>
        public virtual String Mail { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }
    }
}
