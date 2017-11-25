using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.Utilidades
{
    /// <summary>
    /// Clase útil para poder guardar la habitación seleccionada de un grid
    /// </summary>
    public class HabitacionSeleccionada
    {
        private static HabitacionSeleccionada habitacion;

        public static HabitacionSeleccionada Instance()
        {
            if(habitacion == null)
            {
                habitacion = new HabitacionSeleccionada();
            }

            return habitacion;
        }

        public HabitacionDTO Habitacion { get; set; }

        public Habitacion HabitacionRecuperada { get; set; }
    }
}
