using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices
{
    public class EmpleadoSeleccionado
    {
        private static EmpleadoSeleccionado usuario;

        public static EmpleadoSeleccionado Instance()
        {
            if (usuario == null)
            {
                usuario = new EmpleadoSeleccionado();
            }

            return usuario;
        }

        public Usuario Usuario { get; set; }

        }
    }


