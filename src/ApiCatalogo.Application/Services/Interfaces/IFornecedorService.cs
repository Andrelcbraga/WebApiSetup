using ApiCatalogo.Application.Dtos.ViewModels;
using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Services.Interfaces
{
    public interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);
        Task<IEnumerable<FornecedorViewModel>> ObterTodosAsync();
    }
}
