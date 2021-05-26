using LojaCFF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCFF.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        void Add(Produto entity);
        void Delete(Produto entity);
        void Edit(Produto entity);
        IEnumerable<Produto> Get();
        Produto Get(int id);
        void ZerarEstoque(Produto produto);
    }
}
