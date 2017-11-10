using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs
{
    class HistoriaClinicaDTO
    {
        public int DNIPaciente { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public int Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public String RecomendacionActividadFisica { get; set; }

        public String RecomendacionAlimentaria { get; set; }

        public String MedicacionRecomendada { get; set; }

        public String EstadoGeneral { get; set; }


    }
}
