using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.Utilidades
{
    /// <summary>
    /// Clase útil para poder guardar la selección de un paciente en un gridView
    /// </summary>
    public class PacienteSeleccionado
    {
        private static PacienteSeleccionado paciente;

        public static PacienteSeleccionado Instance()
        {
            if (paciente == null)
            {
                paciente = new PacienteSeleccionado();
            }

            return paciente;
        }

        public Paciente Paciente { get; set; }
    }
}
