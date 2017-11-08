using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AñosFelices.DTOs;

namespace AñosFelices.Utilidades
{

    /// <summary>
    /// Clase útil para poder guardar la cama seleccionada de un grid
    /// </summary>
    public class CamaSeleccionada
    {
        private static CamaSeleccionada cama;

        public static CamaSeleccionada Instance()
        {
            if (cama == null)
            {
                cama = new CamaSeleccionada();
            }

            return cama;
        }

        public  CamaDTO Cama { get; set; }
    }
}
