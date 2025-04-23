using Mapster;
using ApiCatalogo.Application.Dtos.ViewModels;
using ApiCatalogo.Domain.Entities;

namespace ApiCatalogo.Application.Mappers
{
    public static class MapsterConfig
    {
        public static void RegisterMaps()
        {
            TypeAdapterConfig<Fornecedor, FornecedorViewModel>.NewConfig();
            //TypeAdapterConfig<Categoria, categoriav>.NewConfig();
        }
    }
}
