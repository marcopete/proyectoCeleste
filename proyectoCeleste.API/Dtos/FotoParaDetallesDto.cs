using System;

namespace proyectoCeleste.API.Dtos
{
    public class FotoParaDetallesDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCarga { get; set; }
        public bool FotoPrincipal { get; set; }
    }
}