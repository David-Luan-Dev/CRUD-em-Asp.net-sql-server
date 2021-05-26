using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCFF.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public void ZerarEstoque(Produto produto)
        {
            produto.Qtde = 0;
            _ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
