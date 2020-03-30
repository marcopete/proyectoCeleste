using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Data
{
    public class CargaDatosJson
    {
        public static void CargaUsuarios(ContextoDatos contexto)
        {
            if (!contexto.Usuarios.Any())
            {
                var dataUsuarios = System.IO.File.ReadAllText("Data/CargaDatosUsuario.json");
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(dataUsuarios);
                foreach (var usuario in usuarios)
                {
                    byte[] passwordhash, passwordsalt;
                    CrearHashDePassword("password", out passwordhash, out passwordsalt);

                    usuario.PasswordHash = passwordhash;
                    usuario.PasswordSalt = passwordsalt;
                    usuario.NombreUsuario = usuario.NombreUsuario.ToLower();
                    contexto.Usuarios.Add(usuario);
                }
                contexto.SaveChanges();
            } 
        }        
        public static void CargaRegiones(ContextoDatos contexto)
        {
            if (!contexto.Regiones.Any())
            {
                var dataRegiones = System.IO.File.ReadAllText("Data/CargaDatosRegiones.json");
                var regiones = JsonConvert.DeserializeObject<List<Region>>(dataRegiones);
                foreach (var region in regiones)
                {
                    contexto.Regiones.Add(region);
                }
                contexto.SaveChanges();
            } 
        }
        public static void CargaCiudades(ContextoDatos contexto)
        {
            if (!contexto.Ciudades.Any())
            {
                var dataCiudades = System.IO.File.ReadAllText("Data/CargaDatosCiudades.json");
                var ciudades = JsonConvert.DeserializeObject<List<Ciudad>>(dataCiudades);
                foreach (var ciudad in ciudades)
                {
                    contexto.Ciudades.Add(ciudad);
                }
                contexto.SaveChanges();
            } 
        }

        public static void CargaTipoMascota(ContextoDatos contexto)
        {
            if (!contexto.TipoMascotas.Any())
            {
                var dataTipoMascota = System.IO.File.ReadAllText("Data/CargaDatosTipoMascota.json");
                var tipoMascotas = JsonConvert.DeserializeObject<List<TipoMascota>>(dataTipoMascota);
                foreach (var tipoMascota in tipoMascotas)
                {
                    contexto.TipoMascotas.Add(tipoMascota);
                }
                contexto.SaveChanges();
            } 
        }
        public static void CargaTipoAtencion(ContextoDatos contexto)
        {
            if (!contexto.TipoAtenciones.Any())
            {
                var dataTipoAtencion = System.IO.File.ReadAllText("Data/CargaDatosTipoAtencion.json");
                var tipoAtenciones = JsonConvert.DeserializeObject<List<TipoAtencion>>(dataTipoAtencion);
                foreach (var tipoAtencion in tipoAtenciones)
                {
                    contexto.TipoAtenciones.Add(tipoAtencion);
                }
                contexto.SaveChanges();
            } 
        }

        public static void CargaAtencion(ContextoDatos contexto)
        {
            if (!contexto.Atenciones.Any())
            {
                var dataAtencion = System.IO.File.ReadAllText("Data/CargaAtenciones.json");
                var atenciones = JsonConvert.DeserializeObject<List<Atencion>>(dataAtencion);
                foreach (var atencion in atenciones)
                {
                    contexto.Atenciones.Add(atencion);
                }
                contexto.SaveChanges();
            } 
        }        

        private static void CrearHashDePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}