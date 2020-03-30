using System;

namespace proyectoCeleste.API.Dtos
{
    public class UsuarioParaListarDto
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string TelefonoPrincipal { get; set; }
    }
}