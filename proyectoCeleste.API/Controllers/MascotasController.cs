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
    public class MascotasController : ControllerBase
    {
        private readonly ISistemaRepositorio _repositorio;
        private readonly IMapper _mapeador;
        public MascotasController(ISistemaRepositorio repositorio, IMapper mapeador)
        {
            _mapeador = mapeador;
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerMascotas()
        {
            var mascotas = await _repositorio.ObtenerMascotas();

            var mascotasRetornadas = _mapeador.Map<IEnumerable<MascotaParaListarDto>>(mascotas);

            return Ok(mascotasRetornadas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerMascota(int id)
        {
            var mascota = await _repositorio.ObtenerMascota(id);

            var mascotaRetornada = _mapeador.Map<MascotaParaDetallesDto>(mascota);

            return Ok(mascotaRetornada);
        }
    }
}