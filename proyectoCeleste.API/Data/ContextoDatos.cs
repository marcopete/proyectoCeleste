using Microsoft.EntityFrameworkCore;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Data
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos(DbContextOptions<ContextoDatos> options) :  base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<TipoMascota> TipoMascotas { get; set; }
        public DbSet<Atencion> Atenciones { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<TipoAtencion> TipoAtenciones { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}