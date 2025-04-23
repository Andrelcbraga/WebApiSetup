using ApiCatalogo.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriasController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            var categorias = await _service.GetCategorias();

            return Ok(categorias);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Categoria>> GetCategoriaById(int id)
        {
            var categoria = await _service.GetCategoriaById(id);

            return Ok(categoria);
        }

    }
}
