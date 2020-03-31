using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using proyectoCeleste.API.Data;
using proyectoCeleste.API.Dtos;
using System.Collections.Generic;

namespace proyectoCeleste.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadesController : ControllerBase
    {
        private readonly ISistemaRepositorio _repositorio;
        public CiudadesController(ISistemaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerCiudades()
        {
            var ciudades = await _repositorio.ObtenerCiudades();

            return Ok(ciudades);
        }        
    }
}