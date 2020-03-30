using System;
using Microsoft.AspNetCore.Http;

namespace proyectoCeleste.API.Helpers
{
    public static class Extensiones
    {
        public static void AgregarErrorDeAplicacion(this HttpResponse respuesta, string mensaje)
        {
            respuesta.Headers.Add("Application-Error", mensaje);
            respuesta.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            respuesta.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalcularEdad(this DateTime laFechaAcalcular)
        {
            var edad = DateTime.Today.Year - laFechaAcalcular.Year;
            if (laFechaAcalcular.AddYears(edad) > DateTime.Today)
                edad--;

            return edad;    
        }
    }
}