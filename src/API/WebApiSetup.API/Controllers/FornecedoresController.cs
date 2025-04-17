using Microsoft.AspNetCore.Mvc;
using WebApiSetup.API.Controllers;
using WebApiSetup.Application.Dtos.ViewModels;
using WebApiSetup.Application.Services.Interfaces;

namespace WebApiSetup.API.V1.Controllers
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
            var fornecedor = await _FornecedorService.ObterTodos();

            return Ok(fornecedor);
        }
    }
}
