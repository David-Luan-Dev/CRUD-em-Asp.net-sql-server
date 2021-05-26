using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCFF.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public short Qtde { get; set; }

        public int TipoProdutoId { get; set; }

        public virtual TipoProduto TipoProduto { get; set; }
    }
}
