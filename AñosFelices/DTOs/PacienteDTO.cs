using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    public class PacienteDTO
    {
        /*public PacienteDTO()
        {

        }*/

        /*public PacienteDTO(int dni, string cama, string habitacion, string nombre, String apellido, String estadoFisico, string estado)
        {
            this.Dni = dni;
            this.Cama = cama;
            this.Habitacion = habitacion;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.EstadoFisico = estadoFisico;
            this.Estado = estado;
        }*/

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
