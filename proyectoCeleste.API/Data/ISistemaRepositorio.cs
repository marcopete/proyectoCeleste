using System.Collections.Generic;
using System.Threading.Tasks;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Data
{
    public interface ISistemaRepositorio
    {
         void Agregar<T>(T entity) where T: class;
         void Eliminar<T>(T entity) where T: class;
         Task<bool> GuardarTodo();
         Task<IEnumerable<Usuario>> ObtenerUsuarios();
         Task<Usuario> ObtenerUsuario(int id);
         Task<IEnumerable<Mascota>> ObtenerMascotas();
         Task<Mascota> ObtenerMascota(int id);
         Task<IEnumerable<Atencion>> ObtenerAtenciones();
         Task<Atencion> ObtenerAtencion(int id);
    }
}