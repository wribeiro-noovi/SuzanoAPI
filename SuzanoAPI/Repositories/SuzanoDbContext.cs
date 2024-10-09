using Microsoft.EntityFrameworkCore;
using SuzanoAPI.Entities;

namespace SuzanoAPI.Repositories
{
    public class SuzanoDbContext : DbContext
    {
        public SuzanoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Ani> ani { get; set; }
        public DbSet<Msg_emergencial> msg_emergencial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ani>().HasKey(ani => ani.Phone);
            modelBuilder.Entity<Msg_emergencial>().HasKey(msg => msg.Message);
        }
    }
}
