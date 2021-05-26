using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;
using System.Linq;

namespace LojaCFF.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
