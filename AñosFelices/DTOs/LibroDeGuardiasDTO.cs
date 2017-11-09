using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs
{
    public class LibroDeGuardiasDTO
    {
        /// <summary>
        /// Fecha
        /// </summary>
        public virtual DateTime Fecha { get; set; }

        public virtual String Paciente { get; set; }

        /// <summary>
        /// Habitacion del paciente
        /// </summary>
        public virtual String Habitacion { get; set; }

        /// <summary>
        /// Cama del paciente
        /// </summary>

        public virtual String Cama { get; set; }

        /// <summary>
        /// Turno
        /// </summary>
        public virtual String Turno { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual String Usuario { get; set; }

        /// <summary>
        /// Actividad realizada
        /// </summary>
        public virtual String ActividadRealizada { get; set; }

        /// <summary>
        /// Comida realizada
        /// </summary>
        public virtual String ComidaRealizada { get; set; }

        /// <summary>
        /// Medicación administrada
        /// </summary>
        /// 

        /// <summary>
        /// Presión
        /// </summary>
        public virtual String Presion { get; set; }

        /// <summary>
        /// Temperatura
        /// </summary>
        public virtual Decimal Temperatura { get; set; }

        /// <summary>
        /// Nivel de azúcar
        /// </summary>
        public virtual Decimal Azucar { get; set; }

        public virtual String MedicacionAdministrada { get; set; }

        /// <summary>
        /// Observaciones
        /// </summary>
        public virtual String Observaciones { get; set; }

        /// <summary>
        /// Recomendaciones
        /// </summary>
        public virtual String Recomendaciones { get; set; }

       

        

        
    }
}
