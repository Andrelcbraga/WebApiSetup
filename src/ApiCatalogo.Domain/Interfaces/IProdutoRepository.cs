using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        // para exemplo vai ser usado o Iqueriable e retornos bool como opção a mais de uso para cada contexto.

        IQueryable<Produto> GetProdutos();
        Task<Produto> GetProduto(int id);
        Produto Create(Produto produto);
        bool Update(Produto produto);
        bool Delete(int id);

    }
}
