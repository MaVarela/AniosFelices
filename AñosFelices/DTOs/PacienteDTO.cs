using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    public class PacienteDTO
    {
        /// <summary>
        /// Dni de la persona
        /// </summary>
        public virtual int Dni { get; set; }

        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public virtual String Nombre { get; set; }

        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public virtual String Apellido { get; set; }

        public virtual String Sexo { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Habitacion del paciente
        /// </summary>
        public virtual String Habitacion { get; set; }

        /// <summary>
        /// Cama del paciente
        /// </summary>

        public virtual String Cama { get; set; }

        /// <summary>
        /// Estado físico del paciente
        /// </summary>
        public virtual String EstadoFisico { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }
    }
}
