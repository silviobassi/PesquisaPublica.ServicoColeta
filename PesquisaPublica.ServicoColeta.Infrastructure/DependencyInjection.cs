using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PesquisaPublica.ServicoColeta.Infrastructure.Producers;
using ServicoColeta.Application.Services;

namespace PesquisaPublica.ServicoColeta.Infrastructure;

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
            busConfigurator.UsingRabbitMq((context, configurator) =>
            {
                var connection = configuration.GetValue<string>("ConnectionString:RabbitMQ");
                configurator.Host(connection);
                configurator.ConfigureEndpoints(context);
            });
        });
    }
    
    private static void AddServiceBus(IServiceCollection services)
    {
        services.AddScoped<IServiceBusEvent, PesquisaRespondidaEventProducer>();
    }
}