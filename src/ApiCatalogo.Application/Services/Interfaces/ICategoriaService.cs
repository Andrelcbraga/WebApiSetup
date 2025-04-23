using ApiCatalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
