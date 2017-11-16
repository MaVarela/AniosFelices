using AñosFelices.DTOs;
using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.Utilidades
{
    public class ParienteSeleccionado
    {
        private static ParienteSeleccionado pariente;

        public static ParienteSeleccionado Instance()
        {
            if (pariente == null)
            {
                pariente = new ParienteSeleccionado();
            }

            return pariente;
        }

        public List<ParienteDTO> Parientes { get; set; }

        public ParienteDTO Pariente { get; set; }
    }
}
