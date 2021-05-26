using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaCFF.Tests.Domain.ProdutoSevice
{
    [TestClass, TestCategory("Servicos")]
    public class ProdutoServiceTests
    {
        [TestMethod]
        public void OServicoDeveAdicionarUmProduto()
        {
            TipoProduto tipo1 = new TipoProduto { Id = 1, Nome = "Tipo 1" };

            var produto = new Produto {
                Id = 1,
                Nome = "Produto 1",
                Preco = 55.99m,
                Qtde = 100,
                TipoProduto = tipo1                
            };

            ProdutoService service = new ProdutoService(new ProdutoRepositoryFake());

            service.Add(produto);

            Assert.IsTrue(BDFakeProduto.Produtos.Count == 1);
        }

        [TestMethod]
        public void OServicoDeveZerarEstoqueDeUmProduto()
        {

            #region Add Produto;

            TipoProduto tipo1 = new TipoProduto { Id = 1, Nome = "Tipo 1" };

            var produto = new Produto
            {
                Id = 1,
                Nome = "Produto 1",
                Preco = 55.99m,
                Qtde = 100,
                TipoProduto = tipo1
            };

            #endregion

            ProdutoService service = new ProdutoService(new ProdutoRepositoryFake());

            service.Add(produto);

            var produtoBD = service.Get(1);

            Assert.IsTrue(produtoBD.Qtde == 100);

            service.ZerarEstoque(produtoBD);

            produtoBD = null;
            produtoBD = service.Get(1);

            Assert.IsTrue(produtoBD.Qtde == 0);
        }
    }
}
