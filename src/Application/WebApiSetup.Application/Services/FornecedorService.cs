using Mapster;
using WebApiSetup.Application.Dtos.ViewModels;
using WebApiSetup.Application.Services.Interfaces;
using WebApiSetup.Domain.Entities;
using WebApiSetup.Domain.Interfaces;

namespace WebApiSetup.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _FornecedorRepository;
        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _FornecedorRepository = fornecedorRepository;
        }

        public async Task<IEnumerable<FornecedorViewModel>> ObterTodos()
        {
            var fornecedor = await _FornecedorRepository.ObterTodos();

            var fornecedorDto = fornecedor.Adapt<IEnumerable<FornecedorViewModel>>();

            return fornecedorDto;
        }

        Task IFornecedorService.Adicionar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        Task IFornecedorService.Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        Task IFornecedorService.AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        Task IFornecedorService.Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}
