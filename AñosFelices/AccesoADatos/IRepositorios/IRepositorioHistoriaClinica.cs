using AniosFelicesSystem.EntidadesDeNegocio;
using AñosFelices.EntidadesDeNegocio;

namespace AñosFelices.AccesoADatos.IRepositorios
{
    /// <summary>
    /// Interfaz de acceso a datos para la entidad Historía clínica
    /// </summary>
    public interface IRepositorioHistoriaClinica : IRepositorioGenerico<HistoriaClinica, HistoriaClinicaId>
    {
        object ObtenerPorId(string p);
    }
}
