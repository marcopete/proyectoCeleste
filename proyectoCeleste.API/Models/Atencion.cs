using System;

namespace proyectoCeleste.API.Models
{
    public class Atencion
    {
        public int Id { get; set; }
        public TipoAtencion TipoAtencion { get; set; }
        public int TipoAtencionId { get; set; }
        public string DescripcionAtencion { get; set; }
        public int ValorEstimadoAtencion { get; set; }
        public Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
        public DateTime FechaAtencion { get; set; }
    }
}