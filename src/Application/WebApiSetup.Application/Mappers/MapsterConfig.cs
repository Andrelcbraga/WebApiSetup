using Mapster;
using WebApiSetup.Application.Dtos.ViewModels;
using WebApiSetup.Domain.Entities;

namespace WebApiSetup.Application.Mappers
{
    public static class MapsterConfig
    {
        public static void RegisterMaps()
        {
            TypeAdapterConfig<Fornecedor, FornecedorViewModel>.NewConfig();
        }
    }
}
