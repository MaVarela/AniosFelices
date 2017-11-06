using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.Utilidades
{
    /// <summary>
    /// Clase útil para poder guardar el usuario logueado
    /// </summary>
    public class UsuarioLogueado
    {
        private static UsuarioLogueado usuario;

        public static UsuarioLogueado Instance()
        {
            if (usuario == null)
            {
                usuario = new UsuarioLogueado();
            }

            return usuario;
        }

        public Usuario Usuario { get; set; }

    }
}
