using System;


namespace AñosFelices
{

    /// <summary>
    /// DTO de usuario
    /// </summary>
   public class UsuarioDTO
    {
        /// <summary>
        /// Identificador de usuario
        /// </summary>
        public virtual int Dni { get; set; }

        /// <summary>
        ///id de rol
        /// </summary>
        public virtual String Rol { get; set; }
        public virtual int IdRol { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public virtual String Password { get; set; }

        public virtual String nombre { get; set; }

        public virtual String apellido { get; set; }
             public virtual String direccion { get; set; }
        public virtual String telefono1 { get; set; }
        public virtual String telefono2 { get; set; }
        public virtual String mail { get; set; }
        public virtual String estado { get; set; }
       

    }
}

