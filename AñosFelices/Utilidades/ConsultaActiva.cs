using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.Utilidades
{
    public class ConsultaActiva
    {
        private static ConsultaActiva consulta;

        public static ConsultaActiva Instance()
        {
            if (consulta == null)
            {
                consulta = new ConsultaActiva();
            }

            return consulta;
        }

        public String Consulta { get; set; }
    }
}
