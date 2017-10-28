using AñosFelices.EntidadesDeNegocio;
using System;

namespace AniosFelicesSystem.EntidadesDeNegocio
{
    /// <summary>
    /// Cama
    /// </summary>
    public class Cama
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Cama()
        {
            this.Id = new CamaId();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="idCama">Número de la cama</param>
        /// <param name="habitacion">Habitación a la que pertenece la cama</param>
        /// <param name="estado">Estado</param>
        public Cama(int idCama, Habitacion habitacion)
        {
            this.Id = new CamaId();
            this.IdCama = idCama;
            this.Habitacion = habitacion;
            this.Estado = "L";
        }


        private CamaId camaId { get; set; }

        /// <summary>
        /// Identificador de Historia Clínica
        /// </summary>
        public virtual CamaId Id
        {
            get { return this.camaId; }
            set { this.camaId = value; }
        }

        public virtual int IdCama
        {
            get { return this.Id.IdCama; }
            set { this.Id.IdCama = value; }
        }

        /// <summary>
        /// Habitación a la que pertenece la cama
        /// </summary>
        public virtual Habitacion Habitacion
        {
            get { return this.Id.Habitacion; }
            set { this.Id.Habitacion = value; }
        }

        /// <summary>
        /// Estado
        /// </summary>
        public virtual String Estado { get; set; }

        /// <summary>
        /// Implementa la lógica necesaria para determinar la igualdad entre instancias de esta clase
        /// </summary>
        /// <param name="obj">Instancia que se quiere comparar</param>
        /// <returns>True si las instancias son iguales, false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var entidad = (obj as Cama);
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
