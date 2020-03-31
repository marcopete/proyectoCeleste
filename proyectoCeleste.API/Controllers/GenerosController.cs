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
    public class GenerosController : ControllerBase
    {
        private readonly ISistemaRepositorio _repositorio;
        public GenerosController(ISistemaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerGeneros()
        {
            var generos = await _repositorio.ObtenerGeneros();

            return Ok(generos);
        }        
    }
}