using Microsoft.EntityFrameworkCore;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Data
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos(DbContextOptions<ContextoDatos> options) :  base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}