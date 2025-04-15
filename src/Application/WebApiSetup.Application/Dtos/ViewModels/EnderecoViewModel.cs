

namespace WebApiSetup.Application.Dtos.ViewModels
{
    public record EnderecoViewModel(
        Guid Id,
        string? Logradouro,
        string? Numero,
        string? Complemento,
        string? Bairro,
        string Cep,
        string? Cidade,
        string? Estado);


}
