using WebApiSetup.Application.Dtos.ViewModels;
using WebApiSetup.Domain.Entities;

namespace WebApiSetup.Application.Services.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);
        Task<IEnumerable<FornecedorViewModel>> ObterTodos();
    }
}
