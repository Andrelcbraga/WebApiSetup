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
        private readonly ILogger<CategoriasController> _logger;

        public CategoriasController(ICategoriaService service, ILogger<CategoriasController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Busca todas as categorias.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            var categorias = await _service.GetCategorias();

            return Ok(categorias);
        }

         /// <summary>
        /// Busca todos os produtos por Por Id.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public async Task<ActionResult<Categoria>> GetCategoriaById(int id)
        {
            var categoria = await _service.GetCategoriaById(id);

            if (categoria == null)
            {
                return NotFound("Categoria não encotrada");
            }

            return Ok(categoria);
        }

        /// <summary>
        /// Busca todos os produtos por Por Id.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Dados inválidos");
            }
            var categoriaCriada = _service.Adicionar(categoria);

            return new CreatedAtRouteResult("ObterCategoria", new { id = categoriaCriada.CategoriaId }, categoriaCriada);

        }

 /// <summary>
        /// Busca todos os produtos por Por Id.
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("Dados inválidos");
            }
            var update = _service.Atualizar(categoria);

            return Ok(update);
        }
    }
}