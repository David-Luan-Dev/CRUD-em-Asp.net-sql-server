using LojaCFF.Domain.Entities;
using System.Collections.Generic;

namespace LojaCFF.Domain.Interfaces.Services
{
    public interface ITipoProdutoService
    {
        void Add(TipoProduto entity);
        void Delete(TipoProduto entity);
        void Edit(TipoProduto entity);
        IEnumerable<TipoProduto> Get();
        TipoProduto Get(int id);
    }
}
