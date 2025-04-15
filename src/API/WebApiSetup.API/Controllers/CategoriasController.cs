using Microsoft.AspNetCore.Mvc;
using WebApiSetup.Domain.Entidades;

namespace WebApiSetup.API.V1.Controllers
{
    public class CategoriasController : Controller
    {
        public CategoriasController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return Ok();
        }

        [HttpGet("{categoriaId}")]
        public async Task<ActionResult<Categoria>> GetCategoria(Guid categoriaId)
        {
            return Ok();
        }

    }
}
