using AniosFelicesSystem.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñosFelices.DTO
{
    public class PacienteDTOMap
    {
        public List<PacienteDTO> llenarListaPacienteDTO(List<Paciente> pacientes)
        {
            List<PacienteDTO> listaPacientes = new List<PacienteDTO>();
            foreach (var paciente in pacientes)
            {
                PacienteDTO p = new PacienteDTO();
                p.Dni = paciente.Dni;
                p.Cama = paciente.Cama.IdCama.ToString();
                p.Habitacion = paciente.Cama.Habitacion.ToString();
                p.Nombre = paciente.Nombre;
                p.Apellido = paciente.Apellido;
                p.EstadoFisico = paciente.EstadoFisico;
                p.Estado = paciente.Estado;

                /*Asi con las propiedades que necesites*/
                listaPacientes.Add(p);
            }
            return listaPacientes;
        }

    }
}