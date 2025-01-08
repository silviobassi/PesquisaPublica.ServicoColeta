using MassTransit;
using Microsoft.Extensions.Logging;
using ServicoColeta.Application.Services;

namespace ServicoColeta.Infrastructure.Producers;

public sealed class PesquisaRespondidaEventProducer(IPublishEndpoint endpoint, ILogger<PesquisaRespondidaEventProducer> logger)
    : IServiceBusEvent
{
    public async Task Publish<T>(T @event, CancellationToken cancellationToken = default) where T : class
    {
        await endpoint.Publish(@event, cancellationToken);
        logger.LogInformation("Publicando evento...");
        await Task.Delay(3000, cancellationToken);
        logger.LogInformation("Pesquisa publicada com sucesso: {Event}", @event);
    }
}