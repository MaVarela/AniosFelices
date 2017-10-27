using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    /// <summary>
    /// Pariente
    /// </summary>
    public class Pariente : Persona
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Pariente()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dni">Dni del pariente</param>
        /// <param name="paciente">Paciente</param>
        /// <param name="telefono1">Teléfono del pariente</param>
        /// <param name="telefono2">Teléfono del pariente</param>
        /// <param name="parentezco">Parentezco</param>
        /// <param name="direccion">Dirección del pariente</param>
        /// <param name="mail">Dirección de correo del pariente</param>
        /// <param name="estado">Estado</param>
        public Pariente(int dni, String nombre, String apellido, Paciente paciente, String telefono1, String telefono2, String parentezco, String direccion, String mail, String estado)
        {           
            this.Dni = dni;
            this.Paciente = paciente;
            this.Telefono1 = telefono1;
            this.Telefono2 = telefono2;
            this.Parentezco = parentezco;
            this.Direccion = direccion;
            this.Mail = mail;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Estado = String.IsNullOrEmpty(estado) ? "A" : estado;
        }

        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente { get; set; }

        /// <summary>
        /// Parentezco con el paciente
        /// </summary>
        public virtual String Parentezco { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Pariente);
            if (entidad == null)
                return false;
            return (this.Dni.Equals(entidad.Dni));
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }
    }
}
