using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;
using Repositorios;
using Manejadores;
using Microsoft.EntityFrameworkCore;


namespace MVCvivero
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ViveroContext>
                (opciones => opciones
                        .UseSqlServer(Configuration.GetConnectionString("MiConexion")));                    
            
            
            // ================ COMIENZO DE ANTES ======
            services.AddSession();

            // TIPO PLANTA
            services.AddScoped<IManejadorTipoPlanta, ManejadorTipoPlanta>();
            services.AddScoped<IRepositorioTiposPlantas, RepositorioTipoPlantaEF>();

            //  PLANTA
            services.AddScoped<IManejadorPlanta, ManejadorPlanta>();
            services.AddScoped<IRepositorioPlantas, RepositorioPlantaEF>();

            // TIPO ILUMINACION
            services.AddScoped<IRepositorioTiposIluminaciones, RepositorioTipoIluminacionEF>();

            //Usuario

            services.AddScoped<IManejadorUsuario, ManejadorUsuario>();
            services.AddScoped<IRepositorioUsuarios, RepositorioUsuarioEF>();
            // ========================== FIN DE ANTES



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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=CompraMVC}/{action=Index}/{id?}");
            });
        }
    }
}
