using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Services.Interfaces
{
    public interface IProdutoService
    {
       IEnumerable<Produto> GetProdutos();
       Task<Produto> GetProdutoById(int id);
        Produto Create(Produto produto);
        bool Update(Produto produto);
        bool Delete(int id);
    }
}
