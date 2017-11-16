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
                usuarioDTO.nombre = usuario.Nombre;
                usuarioDTO.apellido = usuario.Apellido;
                usuarioDTO.direccion = usuario.Direccion;
                usuarioDTO.mail = usuario.Mail;
                usuarioDTO.telefono1 = usuario.Telefono1;
                usuarioDTO.telefono2 = usuario.Telefono2;
                usuarioDTO.estado = usuario.Estado;
                listadoUsuarios.Add(usuarioDTO);
            }

            return listadoUsuarios;
        }
    }
}
