using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProdutoRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public IQueryable<Produto> GetProdutos()
        {
            return _appDbContext.Produtos;
        }
        public async Task<Produto> GetProduto(int id)
        {
            var produto = await _appDbContext.Produtos.FirstOrDefaultAsync(c => c.ProdutoId == id);

            if (produto == null)
            {
                throw new InvalidOperationException("Produto é null");
            }
            return produto;
        }
        public Produto Create(Produto produto)
        {
            if (produto == null)
            {
                throw new InvalidOperationException("Produto é null");
            }
            _appDbContext.Produtos.Add(produto);
            _appDbContext.SaveChanges();
            return produto;
        }
        public bool Update(Produto produto)
        {
            if (produto == null) throw new InvalidOperationException("Produto é null");

            if (_appDbContext.Produtos.Any(p => p.ProdutoId == produto.ProdutoId))
            {
                _appDbContext.Produtos.Update(produto);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var produto = _appDbContext.Produtos.Find(id);
            if (produto is not null)
            {
                _appDbContext.Produtos.Remove(produto);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
