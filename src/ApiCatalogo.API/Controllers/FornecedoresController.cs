using Microsoft.AspNetCore.Mvc;
using ApiCatalogo.API.Controllers;
using ApiCatalogo.Application.Dtos.ViewModels;
using ApiCatalogo.Application.Services.Interfaces;

namespace ApiCatalogo.API.V1.Controllers
{
    [Route("api/(fornecedores")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorService _FornecedorService;

        public FornecedoresController(IFornecedorService fornecedorService)
        {
            _FornecedorService = fornecedorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedor = await _FornecedorService.ObterTodosAsync();

            return Ok(fornecedor);
        }
    }
}
