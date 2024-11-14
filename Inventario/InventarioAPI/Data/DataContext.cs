using InventarioControlador.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
