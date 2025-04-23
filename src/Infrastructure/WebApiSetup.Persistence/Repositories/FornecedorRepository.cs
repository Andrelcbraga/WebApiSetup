using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Domain.Entities;
using ApiCatalogo.Domain.Interfaces;

namespace ApiCatalogo.Persistence.Repositories
{
    public class FornecedorRepository
    {
       

        //public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        //{
        //    return await Db.Fornecedores.AsNoTracking()
        //        .Include(c => c.Endereco)
        //        .FirstOrDefaultAsync(c => c.Id == id);
        //}

        //public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        //{
        //    return await Db.Fornecedores.AsNoTracking()
        //        .Include(c => c.Produtos)
        //        .Include(c => c.Endereco)
        //        .FirstOrDefaultAsync(c => c.Id == id);
        //}

    }
}
