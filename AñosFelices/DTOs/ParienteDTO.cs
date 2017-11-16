using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs
{
    public class ParienteDTO
    {
        public virtual int Dni { get; set; }

        public virtual String Nombre { get; set; }

        public virtual String Apellido { get; set; }

        public virtual String Direccion { get; set; }

        public virtual String Telefono1 { get; set; }
        
        public virtual String Telefono2 { get; set; }

        public virtual String Mail  { get; set; }

        public virtual String Parentezco { get; set; }
    }
}
