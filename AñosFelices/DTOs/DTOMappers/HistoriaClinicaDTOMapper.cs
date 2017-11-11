using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.EntidadesDeNegocio;
using System.Collections.Generic;


namespace AñosFelices.DTO
{
    class HistoriaClinicaDTOMapper
    {

        public List<HistoriaClinicaDTO> ListarConsultasHistoriasClinicas(List<HistoriaClinica> historiaclinica)
        {
            var listadoRecomendacionesAlim = new List<HistoriaClinicaDTO>();

            foreach (var historiaclinicaRecAlim in historiaclinica)
            {
                if (historiaclinicaRecAlim.RecomendacionAlimentaria != null)
                {
                    var historiaclinicaDTO = new HistoriaClinicaDTO();
                    historiaclinicaDTO.DNIPaciente = historiaclinicaRecAlim.Paciente.Dni;
                    historiaclinicaDTO.Nombre = historiaclinicaRecAlim.Paciente.Nombre;
                    historiaclinicaDTO.Apellido = historiaclinicaRecAlim.Paciente.Apellido;
                    historiaclinicaDTO.Usuario = historiaclinicaRecAlim.Usuario.Dni;
                    historiaclinicaDTO.Fecha = historiaclinicaRecAlim.FechaVisita;
                    historiaclinicaDTO.RecomendacionAlimentaria = historiaclinicaRecAlim.RecomendacionAlimentaria;
                    historiaclinicaDTO.RecomendacionActividadFisica = historiaclinicaRecAlim.RecomendacionActividadFisica;
                    historiaclinicaDTO.MedicacionRecomendada = historiaclinicaRecAlim.MedicacionRecomendada;
                    historiaclinicaDTO.EstadoGeneral = historiaclinicaRecAlim.EstadoGeneral;

                    listadoRecomendacionesAlim.Add(historiaclinicaDTO);
                }
            }

            return listadoRecomendacionesAlim;
        }

        public List<HistoriaClinicaDTO> ListarRecActividadFisica(List<HistoriaClinica> historiaclinica)
        {
            var listadoRecomendacionesAlim = new List<HistoriaClinicaDTO>();

            foreach (var historiaclinicaRecAlim in historiaclinica)
            {
                if (historiaclinicaRecAlim.RecomendacionActividadFisica != null)
                {
                    var historiaclinicaDTO = new HistoriaClinicaDTO();
                    historiaclinicaDTO.DNIPaciente = historiaclinicaRecAlim.Paciente.Dni;
                    historiaclinicaDTO.Nombre = historiaclinicaRecAlim.Paciente.Nombre;
                    historiaclinicaDTO.Apellido = historiaclinicaRecAlim.Paciente.Apellido;
                    historiaclinicaDTO.Usuario = historiaclinicaRecAlim.Usuario.Dni;
                    historiaclinicaDTO.Fecha = historiaclinicaRecAlim.FechaVisita;
                    historiaclinicaDTO.RecomendacionAlimentaria = historiaclinicaRecAlim.RecomendacionAlimentaria;
                    historiaclinicaDTO.RecomendacionActividadFisica = historiaclinicaRecAlim.RecomendacionActividadFisica;
                    historiaclinicaDTO.MedicacionRecomendada = historiaclinicaRecAlim.MedicacionRecomendada;
                    historiaclinicaDTO.EstadoGeneral = historiaclinicaRecAlim.EstadoGeneral;

                    listadoRecomendacionesAlim.Add(historiaclinicaDTO);
                }

            }

            return listadoRecomendacionesAlim;
        }

        public List<HistoriaClinicaDTO> ListarRecMedicacion(List<HistoriaClinica> historiaclinica)
        {
            var listadoRecomendacionesAlim = new List<HistoriaClinicaDTO>();

            foreach (var historiaclinicaRecAlim in historiaclinica)
            {
                if (historiaclinicaRecAlim.MedicacionRecomendada!=null)
                {
                    var historiaclinicaDTO = new HistoriaClinicaDTO();
                    historiaclinicaDTO.DNIPaciente = historiaclinicaRecAlim.Paciente.Dni;
                    historiaclinicaDTO.Nombre = historiaclinicaRecAlim.Paciente.Nombre;
                    historiaclinicaDTO.Apellido = historiaclinicaRecAlim.Paciente.Apellido;
                    historiaclinicaDTO.Usuario = historiaclinicaRecAlim.Usuario.Dni;
                    historiaclinicaDTO.Fecha = historiaclinicaRecAlim.FechaVisita;
                    historiaclinicaDTO.RecomendacionAlimentaria = historiaclinicaRecAlim.RecomendacionAlimentaria;
                    historiaclinicaDTO.RecomendacionActividadFisica = historiaclinicaRecAlim.RecomendacionActividadFisica;
                    historiaclinicaDTO.MedicacionRecomendada = historiaclinicaRecAlim.MedicacionRecomendada;
                    historiaclinicaDTO.EstadoGeneral = historiaclinicaRecAlim.EstadoGeneral;

                     listadoRecomendacionesAlim.Add(historiaclinicaDTO);
                }
               
            }

            return listadoRecomendacionesAlim;
        }

        public List<HistoriaClinicaDTO> ListarEstadoGeneral(List<HistoriaClinica> historiaclinica)
        {
            var listadoRecomendacionesAlim = new List<HistoriaClinicaDTO>();

            foreach (var historiaclinicaRecAlim in historiaclinica)
            {
                if (historiaclinicaRecAlim.EstadoGeneral != null)
                {
                    var historiaclinicaDTO = new HistoriaClinicaDTO();
                    historiaclinicaDTO.DNIPaciente = historiaclinicaRecAlim.Paciente.Dni;
                    historiaclinicaDTO.Nombre = historiaclinicaRecAlim.Paciente.Nombre;
                    historiaclinicaDTO.Apellido = historiaclinicaRecAlim.Paciente.Apellido;
                    historiaclinicaDTO.Usuario = historiaclinicaRecAlim.Usuario.Dni;
                    historiaclinicaDTO.Fecha = historiaclinicaRecAlim.FechaVisita;
                    historiaclinicaDTO.RecomendacionAlimentaria = historiaclinicaRecAlim.RecomendacionAlimentaria;
                    historiaclinicaDTO.RecomendacionActividadFisica = historiaclinicaRecAlim.RecomendacionActividadFisica;
                    historiaclinicaDTO.MedicacionRecomendada = historiaclinicaRecAlim.MedicacionRecomendada;
                    historiaclinicaDTO.EstadoGeneral = historiaclinicaRecAlim.EstadoGeneral;

                    listadoRecomendacionesAlim.Add(historiaclinicaDTO);
                }

            }

            return listadoRecomendacionesAlim;
        }

    }
}
