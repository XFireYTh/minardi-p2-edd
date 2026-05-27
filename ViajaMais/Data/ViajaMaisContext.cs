using Microsoft.EntityFrameworkCore;
using ViajaMais.Entities;

namespace ViajaMais.Data
{
    public class ViajaMaisContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<PacoteViagem> PacoteViagem { get; set; }
        public DbSet<Reserva> Reservas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=C:\\Users\\Th\\source\\repos\\ViajaMais\\ViajaMais\\DbViajaMais.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cliente>();
        }
    }
}
