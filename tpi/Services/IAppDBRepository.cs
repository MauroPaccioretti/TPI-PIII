using tpi.Entities;

namespace tpi.Services
{
    public interface IAppDBRepository
    {
        IEnumerable<Persona> GetPersonas();
        Persona? GetPersona(int id);
        TipoPersona? GetTipoPersona(int idPersona);
        bool GuardarCambios();

    }
}
