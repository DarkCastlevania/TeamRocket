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
       public DbSet<Paciente> paciente {get; set;}
       public DbSet<Medico> medico {get; set;}
       public DbSet<Enfermera> enfermera {get; set;}
       public DbSet<Familiar> familiar {get; set;}


       //private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Erocket;Integrated Security = True";
       private const string connectionString = @"Data Source=tcp:teamrocket.database.windows.net,1433;Initial Catalog=Erocket;Persist Security Info=False;User ID=admijessie;Password=Teamrocket1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
       public AplicacionContext() { }
       
            public AplicacionContext(DbContextOptions<AplicacionContext> options)
            : base (options) { }

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