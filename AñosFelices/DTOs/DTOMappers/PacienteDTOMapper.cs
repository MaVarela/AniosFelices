using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTO
{
    public class PacienteDTOMapper
    {
        public List<PacienteDTO> llenarListaPacienteDTO(List<Paciente> pacientes)
        {
            var listadoPacientes = new List<PacienteDTO>();

            foreach (var paciente in pacientes)
            {
                var pacienteDTO = new PacienteDTO();
                pacienteDTO.Dni = paciente.Dni;
                pacienteDTO.Cama = paciente.Cama.IdCama.ToString();
                pacienteDTO.Habitacion = paciente.Cama.Habitacion.IdHabitacion.ToString();
                pacienteDTO.Nombre = paciente.Nombre;
                pacienteDTO.Apellido = paciente.Apellido;
                pacienteDTO.EstadoFisico = paciente.EstadoFisico;
                pacienteDTO.Estado = paciente.Estado;

                /*Asi con las propiedades que necesites*/
                listadoPacientes.Add(pacienteDTO);
            }
            return listadoPacientes;
        }
    }
}