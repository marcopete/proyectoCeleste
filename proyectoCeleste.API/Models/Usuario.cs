using System;
using System.Collections.Generic;

namespace proyectoCeleste.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string TelefonoPrincipal { get; set; }
        public string TelefonoSecundario { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
        public Ciudad Ciudad { get; set; }
        public int CiudadId { get; set; }
    }
}