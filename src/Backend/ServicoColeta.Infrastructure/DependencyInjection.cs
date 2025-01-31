using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServicoColeta.Application.Services;
using ServicoColeta.Infrastructure.Producers;

namespace ServicoColeta.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddServiceBusConfigurations(services, configuration);
        AddServiceBus(services);
        return services;
    }
    
    private static void AddServiceBusConfigurations(IServiceCollection services, IConfiguration configuration)
    {
        services.AddMassTransit(busConfigurator =>
        {
            busConfigurator.UsingAzureServiceBus((context, configurator) =>
            {
                var connection = configuration.GetValue<string>("ConnectionStrings:AzureServiceBus")!;
                
                configurator.Host(new Uri(connection));
                configurator.ConfigureEndpoints(context);
            });
        });
    }
    
    private static void AddServiceBus(IServiceCollection services)
    {
        services.AddScoped<IServiceBusEvent, PesquisaRespondidaEventProducer>();
    }
}