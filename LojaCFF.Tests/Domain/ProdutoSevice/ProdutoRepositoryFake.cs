using System;
using System.Collections.Generic;
using System.Linq;
using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;

namespace LojaCFF.Tests.Domain.ProdutoSevice
{
    public class ProdutoRepositoryFake : IProdutoRepository
    {

        public void Add(Produto entity)
        {
            BDFakeProduto.Produtos.Add(entity);
        }

        public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> Get()
        {
            throw new NotImplementedException();
        }

        public Produto Get(int id)
        {
            return BDFakeProduto.Produtos.First(p => p.Id == id);
        }

        public void ZerarEstoque(Produto entity)
        {
            entity.Qtde = 0;
            var produto = BDFakeProduto.Produtos.First();
            BDFakeProduto.Produtos.Remove(produto);
            BDFakeProduto.Produtos.Add(entity);
        }
    }
}
