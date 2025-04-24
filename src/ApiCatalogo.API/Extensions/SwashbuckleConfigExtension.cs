using Swashbuckle.AspNetCore.SwaggerGen;

namespace ApiCatalogo.API.Extensions;

public static class SwashbuckleConfigExtension
{
     public static IServiceCollection ConfigSwashbuckle(this IServiceCollection services) =>
        services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen(options => { options.LoadDocumentationFiles();});

    private static void LoadDocumentationFiles(this SwaggerGenOptions options)
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            var xmlDocumentationFile = $"{assembly.GetName().Name}.xml";
            var xmlDocumentationPath = Path.Combine(AppContext.BaseDirectory, xmlDocumentationFile);
            if (File.Exists(xmlDocumentationPath))
            {
                options.IncludeXmlComments(xmlDocumentationPath, includeControllerXmlComments:true);
            }
        }
    }
}
