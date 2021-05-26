using LojaCFF.Domain.Entities;

namespace LojaCFF.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        void ZerarEstoque(Produto entity);
    }
}
