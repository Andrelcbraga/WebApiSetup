using ApiCatalogo.Application.Services.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;

namespace ApiCatalogo.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Categoria> GetCategoriaById(int id)
        {
            var categoria = await _repository.GetCategoria(id);

            if (categoria == null)
            {
                throw new ArgumentException("Categoria não encontrada.");
            }

            return categoria;
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            var categoria = await GetCategorias();

            return categoria;
        }

        public Categoria Adicionar(Categoria categoria)
        {
            var categoria_ = _repository.AddCategoria(categoria);
            return categoria_;
        }

        public Task<Categoria> Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Remover(int id)
        {
            throw new NotImplementedException();
        }

    }
}
