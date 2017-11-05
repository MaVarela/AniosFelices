using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs
{
    /// <summary>
    /// DTO de habitación
    /// </summary>
    public class HabitacionDTO
    {
        /// <summary>
        /// Identificador de habitación
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Categoría de la habitación
        /// </summary>
        public virtual String Categoria { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }
    }
}
