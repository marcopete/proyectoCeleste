using System;

namespace proyectoCeleste.API.Dtos
{
    public class MascotaParaListarDto
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public int Edad { get; set; }
        public int UsuarioId { get; set; }
        public int TipoMascotaId { get; set; }
        public string UrlFoto { get; set; }
        public int GeneroId { get; set; }
    }
}