using AñosFelices.EntidadesDeNegocio;
using AñosFelices.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTOs.DTOMappers
{
    public class ParienteDTOMapper
    {
        /// <summary>
        /// Retorna un listado de DTOs de Pariente
        /// </summary>
        /// <param name="camas">Listado de DTO parientes</param>
        /// <returns>Listado de DTOs Pariente</returns>
        public List<ParienteDTO> LlenarListado(List<ParienteDTO> parientes)
        {
            var listadoParientes = new List<ParienteDTO>();

            foreach (var pariente in parientes)
            {
                var parienteDTO = new ParienteDTO();
                parienteDTO.Dni = pariente.Dni;
                parienteDTO.Nombre = pariente.Nombre;
                parienteDTO.Apellido = pariente.Apellido;
                parienteDTO.Direccion = pariente.Direccion;
                parienteDTO.Mail = pariente.Mail;
                parienteDTO.Telefono1 = pariente.Telefono1;
                parienteDTO.Telefono2 = pariente.Telefono2;
                parienteDTO.Parentezco = pariente.Parentezco;

                listadoParientes.Add(parienteDTO);
            }

            return listadoParientes;
        }

        public List<Pariente> LlenarListadoPersist(List<ParienteDTO> parientes, Paciente paciente)
        {
            var listadoParientes = new List<Pariente>();
            
            foreach (var parienteDTO in parientes)
            {
                ParienteId idPariente = new ParienteId();
                idPariente.DniPariente = parienteDTO.Dni;
                idPariente.Paciente = paciente;
                var pariente = new Pariente();

                pariente.Id = idPariente;
                pariente.DniPariente = idPariente.DniPariente;
                pariente.Paciente = idPariente.Paciente;

                pariente.Nombre = parienteDTO.Nombre;
                pariente.Apellido = parienteDTO.Apellido;
                pariente.Direccion = parienteDTO.Direccion;
                pariente.Mail = parienteDTO.Mail;
                pariente.Telefono1 = parienteDTO.Telefono1;
                pariente.Telefono2 = parienteDTO.Telefono2;
                pariente.Parentezco = parienteDTO.Parentezco;
                pariente.Estado = "A";

                listadoParientes.Add(pariente);
            }

            return listadoParientes;
        }

        public List<ParienteDTO> LlenarListado(List<Pariente> parientes)
        {
            var pacienteSeleccionado = PacienteSeleccionado.Instance();
            var listadoParientes = new List<ParienteDTO>();

            foreach (var pariente in parientes)
            {
                var parienteDTO = new ParienteDTO();
                parienteDTO.Dni = pariente.DniPariente;
                parienteDTO.Nombre = pariente.Nombre;
                parienteDTO.Apellido = pariente.Apellido;
                parienteDTO.Direccion = pariente.Direccion;
                parienteDTO.Mail = pariente.Mail;
                parienteDTO.Telefono1 = pariente.Telefono1;
                parienteDTO.Telefono2 = pariente.Telefono2;
                parienteDTO.Parentezco = pariente.Parentezco;

                if(pariente.Paciente.Dni == pacienteSeleccionado.Paciente.Dni)
                {
                    listadoParientes.Add(parienteDTO);
                }
            }

            return listadoParientes;
        }
    }
}
