using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Infrastructure;

namespace ApiCatalogo.API.Controllers
{
    public class ProdutosController : ControllerBase
    {
        public ProdutosController()
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetAsync()
        {
            return Ok();
        }

        [HttpGet("{id}", Name = "GetProduto")]
        public async Task<ActionResult<Produto>> GetByIdAsync(int id)
        {
            return Ok();
        }

        [HttpPost]
        public  ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

            //AppDbContext.Produtos.Add(produto);
            //_context.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto",
                new { id = produto.ProdutoId }, produto);
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
