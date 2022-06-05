using Microsoft.EntityFrameworkCore;
using tpi.DBContexts;
using tpi.Entities;

namespace tpi.Services
{
    public class AppDBRespository : IAppDBRepository
    {
        private readonly AppTPIContext _context;

        public AppDBRespository(AppTPIContext context)
        {
            _context = context;
        }

        public Persona? GetPersonaById(int id)
        {
            return _context.Personas.Where(p => p.Id == id).FirstOrDefault();
        }

        public Persona? GetPersonaByEmailAndPassword(string? email, string? password)
        {
            return _context.Personas.Where(p => p.Email == email && p.Password == password ).Include(p => p.TipoPersona).FirstOrDefault();
        }
        public IEnumerable<Persona> GetPersonas()
        {
            return _context.Personas.Include(p => p.TipoPersona).ToList();
        }

        public IEnumerable<TipoPersona> GetTiposPersona()
        {
            return _context.TiposPersona.ToList();
        }

        public TipoPersona? GetTipoPersona(int idPersona)
        {
            return _context.Personas.FirstOrDefault(p => p.Id == idPersona)?.TipoPersona;
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >=0);
        }

    }
}
