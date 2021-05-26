using LojaCFF.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace LojaCFF.Data.EF.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Tabela
            ToTable("Usuarios");

            // Primary Key
            HasKey(p => p.Id);

            // Colunas
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).HasColumnType("varchar").HasMaxLength(200);
            Property(p => p.Email)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired()
                // Deixar o email Unico na base da dados
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("UQ_dbo.Usuario.Email") {
                            IsUnique = true
                        }
                    )
                );
            Property(p => p.Senha).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            Property(p => p.DataCadastro).IsRequired();

            // Relacionamentos
        }
    }
}
