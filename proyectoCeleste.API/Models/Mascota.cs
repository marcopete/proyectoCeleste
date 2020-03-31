using System;
using System.Collections.Generic;

namespace proyectoCeleste.API.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string AntecedentesPrincipales { get; set; }
        public ICollection<Foto> Fotos { get; set; }
        public ICollection<Atencion> Atenciones { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public TipoMascota TipoMascota { get; set; }
        public int TipoMascotaId { get; set; }
        public int GeneroId { get; set; }
    }
}
