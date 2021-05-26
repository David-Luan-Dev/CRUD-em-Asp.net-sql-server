using LojaCFF.Domain.Entities;

namespace LojaCFF.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}
