


using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto?> ObterProdutoPorIdAsync(int produtoId);
        Task<IEnumerable<Produto?>> ObterProdutosAsync();
    }
}
