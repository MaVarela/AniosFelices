using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.Utilidades
{
    public class RegistroSeleccionado
    {
        private static RegistroSeleccionado registro;
        public static RegistroSeleccionado Instance()
        {
            if (registro == null)
            {
                registro = new RegistroSeleccionado();
            }

            return registro;
        }

        public LibroDeGuardias Registro { get; set; }

        }
}
