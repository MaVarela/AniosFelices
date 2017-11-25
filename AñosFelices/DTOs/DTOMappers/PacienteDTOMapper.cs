using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;

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
                if (paciente.Cama != null)
                {
                    pacienteDTO.Cama = paciente.Cama.IdCama.ToString();
                    pacienteDTO.Habitacion = paciente.Cama.Habitacion.IdHabitacion.ToString();
                }
                pacienteDTO.Nombre = paciente.Nombre;
                pacienteDTO.Apellido = paciente.Apellido;
                pacienteDTO.Sexo = paciente.Sexo;
                pacienteDTO.FechaIngreso = paciente.FechaIngreso;
                pacienteDTO.EstadoFisico = paciente.EstadoFisico;
                pacienteDTO.Estado = paciente.Estado == "A" ? "Habilitado" : "Inhabilitado";

                /*Asi con las propiedades que necesites*/
                listadoPacientes.Add(pacienteDTO);
            }
            return listadoPacientes;
        }
    }
}