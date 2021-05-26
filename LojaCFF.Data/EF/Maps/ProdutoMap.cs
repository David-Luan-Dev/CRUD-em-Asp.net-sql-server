using LojaCFF.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LojaCFF.Data.EF.Maps
{
    public class ProdutoMap :  EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Tabela
            ToTable("Produtos");

            // Primary Key
            HasKey(p => p.Id);

            // Colunas
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            Property(p => p.Preco).HasColumnType("money");
            Property(p => p.Qtde).HasColumnName("Quantidade").IsRequired();
            Property(p => p.TipoProdutoId);
            Property(p => p.DataCadastro).IsRequired();

            // Relacionamentos
            HasRequired(produto => produto.TipoProduto)
                .WithMany(tipo => tipo.Produtos)
                .HasForeignKey(fk => fk.TipoProdutoId);
        }
    }
}
