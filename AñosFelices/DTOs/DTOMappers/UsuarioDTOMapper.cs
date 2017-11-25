using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;


namespace AñosFelices
{
 public   class UsuarioDTOMapper
    {
        public List<UsuarioDTO> LlenarListado(List<Usuario> usuarios)
        {
            var listadoUsuarios = new List<UsuarioDTO>();

            foreach (var usuario in usuarios)
            {
                var usuarioDTO = new UsuarioDTO();
                usuarioDTO.Dni = usuario.Dni;
                usuarioDTO.Rol = usuario.Rol.Descripcion;
                usuarioDTO.IdRol = usuario.Rol.IdRol;
                usuarioDTO.Password = usuario.Password;
                usuarioDTO.Nombre = usuario.Nombre;
                usuarioDTO.Apellido = usuario.Apellido;
                usuarioDTO.Direccion = usuario.Direccion;
                usuarioDTO.Mail = usuario.Mail;
                usuarioDTO.Telefono1 = usuario.Telefono1;
                usuarioDTO.Telefono2 = usuario.Telefono2;
                usuarioDTO.FechaIngreso = usuario.FechaIngreso;
                usuarioDTO.Estado = usuario.Estado == "A" ? "Habilitado" : "Inhabilitado";
                listadoUsuarios.Add(usuarioDTO);
            }

            return listadoUsuarios;
        }
    }
}
