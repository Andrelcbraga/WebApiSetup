using Microsoft.AspNetCore.Mvc;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Application.Services.Interfaces;

namespace ApiCatalogo.API.Controllers
{
    [Route("Produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        /// <summary>
        /// Busca todos os produtos por paginação e ordenação.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetAsync()
        {
            var produtos = _produtoService.GetProdutos();
            if (produtos is null) return NotFound();

            return Ok(produtos);
        }

        [HttpGet("{id}", Name = "ObterProduto")]
        public async Task<ActionResult<Produto>> GetByIdAsync(int id)
        {
            var produto = await _produtoService.GetProdutoById(id);

            if (produto is null) return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

            var novoProduto = _produtoService.Create(produto);

            return new CreatedAtRouteResult("ObterProduto",
                new { id = novoProduto.ProdutoId }, novoProduto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            //_context.Entry(produto).State = EntityState.Modified;
            //_context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            //var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            //var produto = _context.Produtos.Find(id);

            // if (produto is null)
            {
                return NotFound("Produto não localizado...");
            }
            // _context.Produtos.Remove(produto);
            // _context.SaveChanges();

            // return Ok(produto);
        }

    }
}
