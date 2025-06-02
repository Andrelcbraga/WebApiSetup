using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetCategoriaById(int id);
        Categoria Adicionar(Categoria categoria);
        Task<Categoria> Atualizar(Categoria categoria);
        Task<Categoria> Remover(int id);
    }
}
