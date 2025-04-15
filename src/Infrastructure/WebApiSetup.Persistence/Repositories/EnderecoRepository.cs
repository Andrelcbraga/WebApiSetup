using WebApiSetup.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using WebApiSetup.Persistence.Context;
using WebApiSetup.Domain.Interfaces;

namespace WebApiSetup.Persistence.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}