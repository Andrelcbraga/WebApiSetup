using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria?> GetCategoria(int? id);
        Categoria AddCategoria(Categoria categoria);
        Categoria? Update(Categoria categoria);
        Categoria Delete(int id);
    }
}
