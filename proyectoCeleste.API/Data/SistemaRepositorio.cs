using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Data
{
    public class SistemaRepositorio : ISistemaRepositorio
    {
        private readonly ContextoDatos _contexto;
        public SistemaRepositorio(ContextoDatos contexto)
        {
            _contexto = contexto;
        }
        public void Agregar<T>(T entity) where T : class
        {
            _contexto.Add(entity);
        }

        public void Eliminar<T>(T entity) where T : class
        {
            _contexto.Remove(entity);
        }

        public async Task<bool> GuardarTodo()
        {
            return await _contexto.SaveChangesAsync() > 0;
        }

        // NOTA DEL DESARROLLADOR: MAS DE UN INCLUDE!!!! ESTO MERECE UN SCHOP!!! MPF
        public async Task<Mascota> ObtenerMascota(int id)
        {
            var mascota = await _contexto.Mascotas.Include(f => f.Fotos).Include(a => a.Atenciones).FirstOrDefaultAsync(m => m.Id == id);

            return mascota;
        }

        public async Task<IEnumerable<Mascota>> ObtenerMascotas()
        {
            var mascotas = await _contexto.Mascotas.Include(f => f.Fotos).ToListAsync();

            return mascotas;
        }

        public async Task<Usuario> ObtenerUsuario(int id)
        {
            var usuario = await _contexto.Usuarios.Include(m => m.Mascotas).FirstOrDefaultAsync(u => u.Id == id);

            return usuario;
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuarios()
        {
            var usuarios = await _contexto.Usuarios.Include(m => m.Mascotas).ToListAsync();

            return usuarios;
        }

        public async Task<Atencion> ObtenerAtencion(int id)
        {
            var atencion = await _contexto.Atenciones.FirstOrDefaultAsync(a => a.Id == id);

            return atencion;
        }
        
        public async Task<IEnumerable<Atencion>> ObtenerAtenciones()
        {
            var atenciones = await _contexto.Atenciones.ToListAsync();

            return atenciones;
        }

        public async Task<IEnumerable<Region>> ObtenerRegiones()
        {
            var regiones = await _contexto.Regiones.ToListAsync();

            return regiones;
        }        

        public async Task<IEnumerable<TipoAtencion>> ObtenerTipoAtenciones()
        {
            var tipoAtenciones = await _contexto.TipoAtenciones.ToListAsync();

            return tipoAtenciones;
        }

        public async Task<IEnumerable<TipoMascota>> ObtenerTipoMascotas()
        {
            var tipoMascotas = await _contexto.TipoMascotas.ToListAsync();

            return tipoMascotas;
        }


        public async Task<IEnumerable<Ciudad>> ObtenerCiudades()
        {
            var ciudades = await _contexto.Ciudades.ToListAsync();

            return ciudades;
        }

        public async Task<IEnumerable<Log>> ObtenerLogs()
        {
            var logs = await _contexto.Logs.ToListAsync();

            return logs;
        }

        public async Task<IEnumerable<Genero>> ObtenerGeneros()
        {
            var generos = await _contexto.Generos.ToListAsync();

            return generos;
        }                 

    }
}