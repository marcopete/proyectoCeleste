using System.Linq;
using AutoMapper;
using proyectoCeleste.API.Dtos;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Helpers
{
    public class PerfilesAutoMapper : Profile
    {
        public PerfilesAutoMapper()
        {
            CreateMap<Usuario, UsuarioParaListarDto>();
            CreateMap<Usuario, UsuarioParaDetallesDto>();
            CreateMap<Mascota, MascotaParaListarDto>()
                .ForMember(destino => destino.UrlFoto, opciones => opciones.MapFrom(fuente => fuente.Fotos.FirstOrDefault(fuente => fuente.FotoPrincipal).Url))
                .ForMember(destino => destino.Edad, opciones => opciones.MapFrom(fuente => fuente.FechaNacimiento.CalcularEdad()));
            CreateMap<Mascota, MascotaParaDetallesDto>()
                .ForMember(destino => destino.UrlFoto, opciones => opciones.MapFrom(fuente => fuente.Fotos.FirstOrDefault(fuente => fuente.FotoPrincipal).Url))
                .ForMember(destino => destino.Edad, opciones => opciones.MapFrom(fuente => fuente.FechaNacimiento.CalcularEdad()));
            CreateMap<Foto, FotoParaDetallesDto>();
            CreateMap<Atencion, AtencionesParaListarDto>();
            CreateMap<Atencion, AtencionesParaDetallesDto>();
        }
    }
}