using LojaCFF.Domain.Entities;
using System.Data.Entity;

namespace LojaCFF.Data.EF
{
    public class LojaCFFDataContext : DbContext
    {
        public LojaCFFDataContext() : base("LojaCFFConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TiposProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new Maps.ProdutoMap());
            modelBuilder.Configurations.Add(new Maps.TipoProdutoMap());
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());

            //base.OnModelCreating(modelBuilder);
        }
    }
}
