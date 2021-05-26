using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCFF.UI.ViewModel.Produto
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public short Qtde { get; set; }

        [Required, Display(Name = "Tipo")]
        public int TipoProdutoId { get; set; }

        public string TipoProduto { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}