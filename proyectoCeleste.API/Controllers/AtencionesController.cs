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
    public class AtencionesController : ControllerBase
    {
        private readonly ISistemaRepositorio _repositorio;
        private readonly IMapper _mapeador;
        public AtencionesController(ISistemaRepositorio repositorio, IMapper mapeador)
        {
            _mapeador = mapeador;
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerAtenciones()
        {
            var atenciones = await _repositorio.ObtenerAtenciones();

            var atencionesRetornadas = _mapeador.Map<IEnumerable<AtencionesParaListarDto>>(atenciones);

            return Ok(atencionesRetornadas);
        } 

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerAtencion(int id)
        {
            var atencion = await _repositorio.ObtenerAtencion(id);

            var atencionRetornada = _mapeador.Map<AtencionesParaDetallesDto>(atencion);

            return Ok(atencionRetornada);
        }                

    }
}