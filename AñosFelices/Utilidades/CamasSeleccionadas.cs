using System.Collections.Generic;
using AñosFelices.DTOs;

namespace AñosFelices.Utilidades
{

    /// <summary>
    /// Clase útil para poder guardar la cama seleccionada de un grid
    /// </summary>
    public class CamasSeleccionadas
    {
        private static CamasSeleccionadas cama;

        public static CamasSeleccionadas Instance()
        {
            if (cama == null)
            {
                cama = new CamasSeleccionadas();
            }

            return cama;
        }

        public  List<CamaDTO> Camas { get; set; }
    }
}
