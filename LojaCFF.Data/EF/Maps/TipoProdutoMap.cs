using LojaCFF.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LojaCFF.Data.EF.Maps
{
    public class TipoProdutoMap : EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoMap()
        {
            // Tabela
            ToTable("TiposProdutos");

            // Primary Key
            HasKey(p => p.Id);

            // Colunas
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            Property(p => p.DataCadastro).IsRequired();

            // Relacionamentos
        }
    }
}
