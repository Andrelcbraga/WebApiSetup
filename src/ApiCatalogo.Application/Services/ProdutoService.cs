using ApiCatalogo.Application.Services.Interfaces;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;

namespace ApiCatalogo.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IEnumerable<Produto> GetProdutos()
        {
            var produtos = _produtoRepository.GetProdutos().ToList();
            return produtos;
        }
        public async Task<Produto> GetProdutoById(int id)
        {
            var produto = await _produtoRepository.GetProduto(id);
            return produto;
        }

        public Produto Create(Produto produto)
        {
            var produto_ = _produtoRepository.Create(produto);
            return produto_;

        }
        public bool Update(Produto produto)
        {
            var produto_ = _produtoRepository.Update(produto);

            if (produto_ == false)
            {
                return false;
            }

            return true;
        }

        public bool Delete(int id)
        {
            var produto_ = _produtoRepository.Delete(id);

            if (produto_ == false)
            {
                return false;
            }

            return true;
        }






    }
}
