using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistencia;


namespace frontsito
{
    public class Startup
    {

        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Erocket;Integrated Security = True";
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
       
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddScoped<IRepositorioCliente,RepositorioCliente>();
            services.AddScoped<IRepositorioEmpleado,RepositorioEmpleado>(); 
            services.AddScoped<IRepositorioDirectivo,RepositorioDirectivo>(); 
            services.AddScoped<IRepositorioProducto,RepositorioProducto>(); 
            services.AddScoped<IRepositorioVenta,RepositorioVenta>(); 
            services.AddScoped<IRepositorioEmpresa,RepositorioEmpresa>(); 
            services.AddDbContext<AplicacionContext>(options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
