using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ApiCatalogo.Domain.Interfaces;
using ApiCatalogo.Infrastructure.Repositories;
namespace ApiCatalogo.Infrastructure
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<AppDbContext>();
           // services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            //services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            //services.AddScoped<INotificador, Notificador>();
            // services.AddScoped<IFornecedorService, FornecedorService>();
            //services.AddScoped<IProdutoService, ProdutoService>();

            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // services.AddScoped<IUser, AspNetUser>();

            // services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
