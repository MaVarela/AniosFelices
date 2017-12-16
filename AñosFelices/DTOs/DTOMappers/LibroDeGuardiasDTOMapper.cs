using AñosFelices.AccesoADatos.IRepositorios;
using AñosFelices.AccesoADatos.Repositorios;
using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs.DTOMappers
{
    public class LibroDeGuardiasDTOMapper
    {
        public List<LibroDeGuardiasDTO> llenarListaLibroDeGuardiasDTO(List<LibroDeGuardias> registros)
        {
            var consultaActiva = ConsultaActiva.Instance();
            var listadoActividadDTO = new List<LibroDeGuardiasDTO>();
            var listadoComidaDTO = new List<LibroDeGuardiasDTO>();
            var listadoEstadoDTO = new List<LibroDeGuardiasDTO>();

            foreach (var registro in registros)
            {
                var libroDeGuardiasDTO = new LibroDeGuardiasDTO();
                libroDeGuardiasDTO.Fecha = registro.Fecha;
                libroDeGuardiasDTO.Paciente = registro.Paciente.Apellido + " " + registro.Paciente.Nombre;
                libroDeGuardiasDTO.Habitacion = registro.Paciente.Cama.Habitacion.IdHabitacion.ToString();
                libroDeGuardiasDTO.Cama = registro.Paciente.Cama.IdCama.ToString();
                libroDeGuardiasDTO.Turno = registro.Turno;
                libroDeGuardiasDTO.Usuario = registro.Usuario.Apellido + " " + registro.Usuario.Nombre;
                libroDeGuardiasDTO.ActividadRealizada = registro.ActividadRealizada;
                libroDeGuardiasDTO.ComidaRealizada = registro.ComidaRealizada;
                libroDeGuardiasDTO.Presion = registro.Presion;
                libroDeGuardiasDTO.Temperatura = Convert.ToInt32(registro.Temperatura);
                libroDeGuardiasDTO.Azucar = Convert.ToInt32(registro.Azucar);
                libroDeGuardiasDTO.MedicacionAdministrada = registro.MedicacionAdministrada;
                libroDeGuardiasDTO.Observaciones = registro.Observaciones;
                libroDeGuardiasDTO.Recomendaciones = registro.Recomendaciones;

                string [] Turno;
                Turno = libroDeGuardiasDTO.Turno.Split(',');
                libroDeGuardiasDTO.Turno = Turno[0];

                if (libroDeGuardiasDTO.ActividadRealizada == null)
                {
                    if (libroDeGuardiasDTO.ComidaRealizada == null)
                        listadoEstadoDTO.Add(libroDeGuardiasDTO);
                    else
                        listadoComidaDTO.Add(libroDeGuardiasDTO);
                }
                else
                    listadoActividadDTO.Add(libroDeGuardiasDTO);
            }

            if (consultaActiva.Consulta == "ConsultarActividad")
                return listadoActividadDTO;
            else
            {
                if (consultaActiva.Consulta == "ConsultarComida")
                    return listadoComidaDTO;
                else
                    return listadoEstadoDTO;
            }
        }

        #region codigo viejo
        /*public LibroDeGuardiasId llenarListaLibroDeGuardiasDTOID(List<LibroDeGuardias> registros, int index)
        {
            var consultaActiva = ConsultaActiva.Instance();
            var idActividad = new LibroDeGuardiasId();
            var listadoActividadDTO = new List<LibroDeGuardiasDTO>();
            var listadoComidaDTO = new List<LibroDeGuardiasDTO>();
            var listadoEstadoDTO = new List<LibroDeGuardiasDTO>();
            int contador = 0;

            foreach (var registro in registros)
            {
                if (contador == index)
                {
                    LibroDeGuardiasId idLibroGuardias = new LibroDeGuardiasId();

                    idActividad.Usuario = registro.Usuario;
                    idActividad.Paciente = registro.Paciente;
                    idActividad.Turno = registro.Turno;
                    return idActividad;
                }
                contador++;
            }
            return idActividad;
        }*/
        #endregion
    }
}
