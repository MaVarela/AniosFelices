using System;
using System.Collections.Generic;
using System.Linq;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Paciente
    /// </summary>
    public class Paciente
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Paciente()
        {
            this.Parientes = new List<Pariente>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="habitacion">Habitación a la que pertenece el paciente</param>
        /// <param name="cama">Cama del paciente</param>
        /// <param name="nombre">Nombre del paciente</param>
        /// <param name="apellido">Apellido del paciente</param>
        /// <param name="estadoFisico">Estado Físico del paciente</param>
        /// <param name="estado">Estado</param>
        public Paciente(int dni, Cama cama, String nombre, String apellido, String estadoFisico, ICollection<Pariente> parientes)
        {
            this.Parientes = parientes != null ? parientes : new List<Pariente>();
            this.Dni = dni;
            this.Cama = cama;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.EstadoFisico = estadoFisico;
        }

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
        /// Cama del paciente
        /// </summary>
        public virtual Cama Cama { get; set; }

        /// <summary>
        /// Estado físico del paciente
        /// </summary>
        public virtual String EstadoFisico { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }

        /// <summary>
        /// Camas de la habitación
        /// </summary>
        public virtual ICollection<Pariente> Parientes { get; set; }


        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Paciente);
            if (entidad == null)
                return false;
            return (this.Dni.Equals(entidad.Dni));
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }
    }
}
