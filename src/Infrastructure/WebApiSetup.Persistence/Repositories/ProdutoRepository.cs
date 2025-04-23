using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;

namespace ApiCatalogo.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;
        ProdutoRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<Produto?> ObterProdutoPorIdAsync(int produtoId)
        {
            var produto = await _appDbContext.Produtos.FirstOrDefaultAsync(p => p.ProdutoId == produtoId);

            if (produto is null)
            {
                return null;
            }

            return produto;

        }

        public async Task<IEnumerable<Produto?>> ObterProdutosAsync()
        {
            var produtos = await _appDbContext.Produtos.AsNoTracking().ToListAsync();
            if (produtos is null)
            {
                return null;
            }
            return produtos;
        }


    }
}
