using ApiCatalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Persistence;

namespace ApiCatalogo.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _AppDbContext;

        public CategoriaRepository(AppDbContext dbContext)
        {
            _AppDbContext = dbContext;
        }

        public Categoria AddCategoria(Categoria categoria)
        {
            if (categoria == null)
                throw new ArgumentNullException(nameof(categoria));

            _AppDbContext.Categorias?.Add(categoria);
            _AppDbContext.SaveChangesAsync();
            return categoria;
        }

        public Categoria Delete(int id)
        {
            var categoria = _AppDbContext.Categorias!.Find(id);

            if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria));
            }

            _AppDbContext.Categorias.Remove(categoria);
            _AppDbContext.SaveChanges();

            return categoria;
        }

        public async Task<Categoria?> GetCategoria(int? id)
        {
            return await _AppDbContext.Categorias!.FirstOrDefaultAsync(c => c.CategoriaId == id);
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            var categoria = await _AppDbContext.Categorias!.ToListAsync();

            return categoria;
        }

        public Categoria? Update(Categoria categoria)
        {
            if (categoria != null)
            {
                throw new ArgumentNullException($"{nameof(categoria)}");
            }
            _AppDbContext.Entry(categoria!).State = EntityState.Modified;
            _AppDbContext.SaveChanges();
            return categoria;

        }
    }
}
