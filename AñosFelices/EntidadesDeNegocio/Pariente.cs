using AñosFelices.EntidadesDeNegocio;
using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    /// <summary>
    /// Pariente
    /// </summary>
    public class Pariente : Persona
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Pariente()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dni">Dni del pariente</param>
        /// <param name="paciente">Paciente</param>
        /// <param name="telefono1">Teléfono del pariente</param>
        /// <param name="telefono2">Teléfono del pariente</param>
        /// <param name="parentezco">Parentezco</param>
        /// <param name="direccion">Dirección del pariente</param>
        /// <param name="mail">Dirección de correo del pariente</param>
        /// <param name="estado">Estado</param>
        public Pariente(int dni, String nombre, String apellido, Paciente paciente, String telefono1, String telefono2, String parentezco, String direccion, String mail)
        {
            this.Id = new ParienteId();
            this.DniPariente = dni;
            this.Paciente = paciente;
            this.Telefono1 = telefono1;
            this.Telefono2 = telefono2;
            this.Parentezco = parentezco;
            this.Direccion = direccion;
            this.Mail = mail;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Estado = "A";
        }

         private ParienteId parienteId { get; set; }

        /// <summary>
        /// Identificador de Historia Clínica
        /// </summary>
        public virtual ParienteId Id
        {
            get { return this.parienteId; }
            set { this.parienteId = value; }
        }

        /// <summary>
        /// Dni del Pariente
        /// </summary>
        public virtual int DniPariente
        {
            get { return this.Id.DniPariente; }
            set { this.Id.DniPariente = value; }
        }

        /// <summary>
        /// Habitación a la que pertenece la cama
        /// </summary>
        public virtual Paciente Paciente
        {
            get { return this.Id.Paciente; }
            set { this.Id.Paciente = value; }
        }
        /// <summary>
        /// Parentezco con el paciente
        /// </summary>
        public virtual String Parentezco { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Pariente);
            if (entidad == null)
                return false;
            return (this.Id.Equals(entidad.Id));
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
