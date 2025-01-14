namespace ServicoColeta.Application.Services;

public interface IServiceBusEvent
{
    public Task Publish<T>(T @event, CancellationToken cancellationToken = default) where T : class;
}