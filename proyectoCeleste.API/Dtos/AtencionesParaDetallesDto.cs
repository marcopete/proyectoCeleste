using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Dtos
{
    public class AtencionesParaDetallesDto
    {
        public int Id { get; set; }
        public TipoAtencion TipoAtencion { get; set; }
        public int TipoAtencionId { get; set; }
        public string DescripcionAtencion { get; set; }
        public int ValorEstimadoAtencion { get; set; }
        public int MascotaId { get; set; }
    }
}