using Microsoft.EntityFrameworkCore;
using SuzanoAPI.Entities;

namespace SuzanoAPI.Repositories
{
    public class SuzanoDbContext : DbContext
    {
        public SuzanoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Ani> ani { get; set; }
        public DbSet<Msg_emergencial> msg_emergencial { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<ClienteProduto> cliente_produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Primary Key
            modelBuilder.Entity<Ani>().HasKey(ani => ani.Phone);
            modelBuilder.Entity<Msg_emergencial>().HasKey(msg => msg.Message);
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<ClienteProduto>().HasKey(cp => new {cp.Cliente_Id, cp.Produto_Id });

            //Foreign Key
            modelBuilder.Entity<Ani>().HasOne(ani => ani.Cliente).WithMany(cli => cli.Ani).HasForeignKey(ani => ani.Cliente_id);
            modelBuilder.Entity<ClienteProduto>().HasOne(cp => cp.Cliente).WithMany(cli => cli.ClientesProdutos).HasForeignKey(cp => cp.Cliente_Id);
            modelBuilder.Entity<ClienteProduto>().HasOne(cp => cp.Produto).WithMany(prod => prod.ClientesProdutos).HasForeignKey(cp => cp.Produto_Id);
        }
    }
}
