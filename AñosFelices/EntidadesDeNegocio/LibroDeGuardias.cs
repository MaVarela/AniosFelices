using AñosFelices.EntidadesDeNegocio;
using System;

namespace AñosFelices.EntidadesDeNegocio
{
    /// <summary>
    /// Libro de Guardias
    /// </summary>
    public class LibroDeGuardias
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LibroDeGuardias()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paciente">Paciente</param>
        /// <param name="usuario">Usuario</param>
        /// <param name="turno">Turno</param>
        /// <param name="fecha">Fecha</param>
        /// <param name="actividadRealizada">Actividad Realizada</param>
        /// <param name="comidaRealizada">Comida Realizada</param>
        /// <param name="medicacionAdministrada">Medicación Administrada</param>
        /// <param name="recomendaciones">Recomendaciones</param>
        /// <param name="observaciones">Observaciones</param>
        /// <param name="presion">Presión</param>
        /// <param name="azucar">Azúcar</param>
        /// <param name="temperatura">Temperatura</param>
        public LibroDeGuardias(Paciente paciente, Usuario usuario, String turno, DateTime fecha, String actividadRealizada, String comidaRealizada, String medicacionAdministrada, String recomendaciones, String observaciones, String presion, Decimal azucar, Decimal temperatura)
        {
            this.Paciente = paciente;
            this.Usuario = usuario;
            this.Turno = turno;
            this.Fecha = fecha;
            this.ActividadRealizada = actividadRealizada;
            this.ComidaRealizada = comidaRealizada;
            this.MedicacionAdministrada = medicacionAdministrada;
            this.Recomendaciones = recomendaciones;
            this.Observaciones = observaciones;
            this.Presion = presion;
            this.Azucar = azucar;
            this.Temperatura = temperatura;
        }

        /// <summary>
        /// Identificador de Historia Clínica
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Paciente
        /// </summary>
        public virtual Paciente Paciente { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Turno
        /// </summary>
        public virtual String Turno { get; set; }

        /// <summary>
        /// Fecha
        /// </summary>
        public virtual DateTime Fecha { get; set; }

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
        public virtual String MedicacionAdministrada { get; set; }

        /// <summary>
        /// Recomendaciones
        /// </summary>
        public virtual String Recomendaciones { get; set; }

        /// <summary>
        /// Observaciones
        /// </summary>
        public virtual String Observaciones { get; set; }

        /// <summary>
        /// Presión
        /// </summary>
        public virtual String Presion { get; set; }

        /// <summary>
        /// Nivel de azúcar
        /// </summary>
        public virtual Decimal Azucar { get; set; }

        /// <summary>
        /// Temperatura
        /// </summary>
        public virtual Decimal Temperatura { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as LibroDeGuardias);
            if (entidad == null)
                return false;
            if (this.Id != null)
                return (this.Id.Equals(entidad.Id));
            return base.Equals(obj);
        }

        /// <summary>
        /// Implementa la lógica necesaria para obtener el hash de una instancia de esta clase
        /// </summary>
        /// <returns>Hashcode de la instancia</returns>
        public override int GetHashCode()
        {
            if (Id != null)
                return Id.GetHashCode();
            return base.GetHashCode();
        }
    }
}
