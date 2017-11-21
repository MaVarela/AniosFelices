using System;


namespace AñosFelices
{

    /// <summary>
    /// DTO de usuario
    /// </summary>
   public class UsuarioDTO
    {
        public virtual int Dni { get; set; }
        public virtual String Rol { get; set; }
        public virtual int IdRol { get; set; }
        public virtual String Password { get; set; }
        public virtual String Nombre { get; set; }
        public virtual String Apellido { get; set; }
        public virtual String Direccion { get; set; }
        public virtual String Telefono1 { get; set; }
        public virtual String Telefono2 { get; set; }
        public virtual String Mail { get; set; }
        public virtual String Estado { get; set; }
    }
}

