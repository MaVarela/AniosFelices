using System;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Usuario
    /// </summary>
    public class Usuario : Persona
    {
        /// <summary>
        /// Consturctor
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rol">Rol del Usuario</param>
        /// <param name="password">Password del Usuario</param>
        /// <param name="nombre">Nombre del Usuario</param>
        /// <param name="apellido">Apellido del Usuario</param>
        /// <param name="direccion">Dirección del Usuario</param>
        /// <param name="telefono1">Teléfono del Usuario</param>
        /// <param name="telefono2">Teléfono del Usuario</param>
        /// <param name="mail">Dirección de correo del Usuario</param>
        /// <param name="estado">Estado</param>
        public Usuario(int dni, Rol rol, String password, String nombre, String apellido, String direccion, String telefono1, String telefono2, String mail, DateTime fechaIngreso)
        {
            this.Dni = dni;
            this.Rol = rol;
            this.Password = password;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono1 = telefono1;
            this.Telefono2 = telefono2;
            this.Mail = mail;
            this.FechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Dni del Usuario
        /// </summary>
        public virtual int Dni { get; set; }

        /// <summary>
        /// Rol del Usuario
        /// </summary>
        public virtual Rol Rol { get; set; }

        /// <summary>
        /// Password del Usuario
        /// </summary>
        public virtual String Password { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Usuario);
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
