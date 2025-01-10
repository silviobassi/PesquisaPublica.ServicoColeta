using Microsoft.Extensions.DependencyInjection;
using ServicoColeta.Application.Services;

namespace ServicoColeta.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        AddServices(services);
        return services;
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddScoped<PublicacaoRespostasService>();
    }
}