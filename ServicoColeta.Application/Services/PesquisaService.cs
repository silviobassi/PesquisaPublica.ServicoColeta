using Microsoft.Extensions.Logging;
using PesquisaPublica.Shared.Contracts.Events;

namespace ServicoColeta.Application.Services;

public class PesquisaService(IServiceBusEvent serviceBusEvent, ILogger<PesquisaService> logger)
{
    public async Task Publicar(PesquisaRespondidaEvent pesquisaRespondidaEvent,
        CancellationToken cancellationToken = default)
    {
        await serviceBusEvent.Publish(pesquisaRespondidaEvent, cancellationToken);
        logger.LogInformation("Pesquisa respondida: {Event}", pesquisaRespondidaEvent);
    }
}