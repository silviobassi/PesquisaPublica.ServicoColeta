using PesquisaPublica.Shared.Contracts.Events;

namespace ServicoColeta.Application.Services;

public class PublicacaoRespostasService(IServiceBusEvent serviceBusEvent)
{
    public async Task Publicar(PesquisaRespondidaEvent pesquisaRespondidaEvent,
        CancellationToken cancellationToken = default)
    {
        await serviceBusEvent.Publish(pesquisaRespondidaEvent, cancellationToken);
    }
}