using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=PUPPYPORTABLE;Database=CoderHouse;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}

