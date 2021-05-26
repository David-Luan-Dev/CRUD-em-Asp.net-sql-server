using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCFF.Domain.Entities
{
    public class TipoProduto : Entity
    {
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
