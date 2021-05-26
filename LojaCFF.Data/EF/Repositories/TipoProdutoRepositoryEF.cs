using LojaCFF.Domain.Entities;
using LojaCFF.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCFF.Data.EF.Repositories
{
    public class TipoProdutoRepositoryEF : RepositoryEF<TipoProduto>, ITipoProdutoRepository
    { }
}
