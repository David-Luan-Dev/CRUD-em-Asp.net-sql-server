using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace LojaCFF.Data.EF
{
    public class DbInitializer : CreateDatabaseIfNotExists<LojaCFFDataContext>
    {
        protected override void Seed(LojaCFFDataContext context)
        {
            var Ingles = new TipoProduto { Nome = "Ingles" };
            var Espanhol = new TipoProduto { Nome = "Espanhol" };
            var Frances = new TipoProduto { Nome = "Frances" };

            var produtos = new List<Produto>() {
                new Produto() { Nome = "Ingles", Preco = 70.5M, Qtde= 150, TipoProduto = Ingles },
                new Produto() { Nome = "Espanhol", Preco = 9.5M, Qtde= 250, TipoProduto = Espanhol },
                new Produto() { Nome = "Frances", Preco = 8.99M, Qtde= 520, TipoProduto = Frances }
            };

            context.Produtos.AddRange(produtos);

           

            context.Usuarios.Add(new Usuario
            {
                Nome = "Cesar",
                Email = "cesar@cesar.com",
                Senha = "123456".Encrypt()
            });

            context.SaveChanges();
        }
    }
}