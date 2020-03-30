using System;

namespace proyectoCeleste.API.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCarga { get; set; }
        public bool FotoPrincipal { get; set; }
        public Mascota Mascota { get; set; }
        public int MascotaId { get; set; }
    }
}