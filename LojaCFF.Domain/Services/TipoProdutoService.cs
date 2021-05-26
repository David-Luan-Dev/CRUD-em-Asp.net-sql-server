using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;
using LojaCFF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace LojaCFF.Domain.Services
{
    public class TipoProdutoService : ITipoProdutoService, IDisposable
    {
        private readonly ITipoProdutoRepository _repoTipoProduto;

        public TipoProdutoService(ITipoProdutoRepository repoTipoProduto)
        {
            _repoTipoProduto = repoTipoProduto;
        }

        public void Add(TipoProduto entity)
        {
            //TODO: minha regra de negocio

            _repoTipoProduto.Add(entity);
        }

        public void Delete(TipoProduto entity)
        {
            _repoTipoProduto.Delete(entity);
        }

        public void Edit(TipoProduto entity)
        {
            _repoTipoProduto.Edit(entity);
        }

        public IEnumerable<TipoProduto> Get()
        {
            return _repoTipoProduto.Get();
        }

        public TipoProduto Get(int id)
        {
            return _repoTipoProduto.Get(id);
        }

        public void Dispose()
        {
            _repoTipoProduto.Dispose();
        }
    }
}
