using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicacionContext : DbContext
    {
       
       public DbSet<Cliente> cliente {get; set;}
       public DbSet<Empleado> empleado {get; set;}
       public DbSet<Directivo> directivo {get; set;}
       public DbSet<Empresa> empresa {get; set;}
       public DbSet<Producto> producto {get; set;}
       public DbSet<Venta> venta {get; set;}

       private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Erocket;Integrated Security = True";

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            if (!optionsBuilder.IsConfigured)
            {
                    optionsBuilder
                    .UseSqlServer(connectionString);
            }
       }        
    }
}