using System.Collections.Generic;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Dtos
{
    public class MascotaParaDetallesDto
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public int Edad { get; set; }
        public string AntecedentesPrincipales { get; set; }
        public int UsuarioId { get; set; }
        public int TipoMascotaId { get; set; }
        public string UrlFoto { get; set; }
        public ICollection<FotoParaDetallesDto> Fotos { get; set; }
        public ICollection<AtencionesParaDetallesDto> Atenciones { get; set; }
    }
}