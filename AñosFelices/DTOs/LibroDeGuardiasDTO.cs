using AñosFelices.EntidadesDeNegocio;
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
        public LibroDeGuardiasDTO(Paciente paciente, Usuario usuario, String turno, DateTime fecha, String actividadRealizada, String comidaRealizada, String medicacionAdministrada, String recomendaciones, String observaciones, Decimal presion, Decimal azucar, Decimal temperatura)
        {
            this.Paciente.Dni = paciente.Dni;
            this.Usuario.Dni = usuario.Dni;
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
        /// Paciente
        /// </summary>
        
        public virtual Paciente Paciente
        {
            get { return this.Paciente; }
            set { this.Paciente = value; }
        }

        /// <summary>
        /// Usuario
        /// </summary>
        public virtual Usuario Usuario
        {
            get { return Usuario; }
            set { this.Usuario = value; }
        }

        /// <summary>
        /// Turno
        /// </summary>
        public virtual String Turno
        {
            get { return Turno; }
            set { Turno = value; }
        }

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
        public virtual Decimal Presion { get; set; }

        /// <summary>
        /// Nivel de azúcar
        /// </summary>
        public virtual Decimal Azucar { get; set; }

        /// <summary>
        /// Temperatura
        /// </summary>
        public virtual Decimal Temperatura { get; set; }
    }
}
