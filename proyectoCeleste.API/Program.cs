using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using proyectoCeleste.API.Data;

namespace proyectoCeleste.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var huesped = CreateHostBuilder(args).Build();
           using (var alcance = huesped.Services.CreateScope())
           {
               var servicios = alcance.ServiceProvider;
               try
               {
                   var contexto = servicios.GetRequiredService<ContextoDatos>();
                   contexto.Database.Migrate();
                   CargaDatosJson.CargaRegiones(contexto);
                   CargaDatosJson.CargaCiudades(contexto);
                   CargaDatosJson.CargaTipoMascota(contexto);
                   CargaDatosJson.CargaTipoAtencion(contexto);
                   CargaDatosJson.CargaUsuarios(contexto);
                //    CargaDatosJson.CargaAtencion(contexto);                   
               }
               catch (Exception ex)
               {
                   var logger = servicios.GetRequiredService<ILogger<Program>>();
                   logger.LogError(ex, "Error durante la migración");
               }
           }

           huesped.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
