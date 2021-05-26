using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaCFF.UI.ViewModel.Produto.Maps
{
    public static class Extensions
    {
        public static IEnumerable<ProdutoViewModel> ToProdutosViewsModels(this IEnumerable<Domain.Entities.Produto> produtos)
        {
            return produtos.Select(p => new ProdutoViewModel {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                Qtde = p.Qtde,
                TipoProduto = p.TipoProduto.Nome,
                TipoProdutoId = p.TipoProdutoId,
                DataCadastro = p.DataCadastro
            });
        }

        public static Domain.Entities.Produto ToProduto(this ProdutoViewModel produtoVM)
        {
            return new Domain.Entities.Produto {
                Id = produtoVM.Id,
                Nome = produtoVM.Nome,
                Preco = produtoVM.Preco,
                Qtde = produtoVM.Qtde,
                TipoProdutoId = produtoVM.TipoProdutoId,
                DataCadastro = produtoVM.DataCadastro
            };
        }

        public static ProdutoViewModel ToProdutoViewModel(this Domain.Entities.Produto produto)
        {
            return new ProdutoViewModel
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                Qtde = produto.Qtde,
                TipoProdutoId = produto.TipoProdutoId,
                TipoProduto = produto.TipoProduto.Nome,
                DataCadastro = produto.DataCadastro
            };
        }
    }
}