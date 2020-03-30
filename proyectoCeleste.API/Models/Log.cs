using System;
using System.Collections.Generic;

namespace proyectoCeleste.API.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime FechaLogIn { get; set; }
        public string TipoLog { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}