using tpi.Entities;

namespace tpi.Services
{
    public interface IAppDBRepository
    {
        IEnumerable<Persona> GetPersonas();
        Persona? GetPersonaById(int id);
        public Persona? GetPersonaByEmailAndPassword(string? email, string? password);
        TipoPersona? GetTipoPersona(int idPersona);
        bool GuardarCambios();
        IEnumerable<TipoPersona> GetTiposPersona();
    }
}
