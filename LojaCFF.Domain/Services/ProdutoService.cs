using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;
using LojaCFF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace LojaCFF.Domain.Services
{
    public class ProdutoService : IProdutoService, IDisposable
    {
        private readonly IProdutoRepository _repoProduto;

        public ProdutoService(IProdutoRepository repoProduto)
        {
            _repoProduto = repoProduto;
        }

        public void Add(Produto entity)
        {
            _repoProduto.Add(entity);
        }

        public void Delete(Produto entity)
        {
            _repoProduto.Delete(entity);
        }

        public void Edit(Produto entity)
        {
            _repoProduto.Edit(entity);
        }

        public IEnumerable<Produto> Get()
        {
            return _repoProduto.Get();
        }

        public Produto Get(int id)
        {
            return _repoProduto.Get(id);
        }

        public void ZerarEstoque(Produto entity)
        {
            _repoProduto.ZerarEstoque(entity);
        }

        public void Dispose()
        {
            _repoProduto.Dispose();
        }
    }
}
