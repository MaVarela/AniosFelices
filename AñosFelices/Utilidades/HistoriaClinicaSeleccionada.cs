using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.Utilidades
{
    public class HistoriaClinicaSeleccionada
    {
        private static HistoriaClinicaSeleccionada historiaclinica;

        public static HistoriaClinicaSeleccionada Instance()
        {
            if (historiaclinica == null)
            {
                historiaclinica = new HistoriaClinicaSeleccionada();
            }

            return historiaclinica;
        }

        public HistoriaClinica HistoriaClinica { get; set; }
    }
}
