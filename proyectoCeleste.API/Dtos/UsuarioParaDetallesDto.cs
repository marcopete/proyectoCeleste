using System;
using System.Collections.Generic;
using proyectoCeleste.API.Models;

namespace proyectoCeleste.API.Dtos
{
    public class UsuarioParaDetallesDto
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string TelefonoPrincipal { get; set; }
        public string TelefonoSecundario { get; set; }
        public int RegionId { get; set; }
        public int CiudadId { get; set; }
        public ICollection<MascotaParaDetallesDto> Mascotas { get; set; }
    }
}