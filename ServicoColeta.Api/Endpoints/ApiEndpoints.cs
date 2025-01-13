using Microsoft.AspNetCore.Mvc;
using PesquisaPublica.Shared.Contracts.Events;
using ServicoColeta.Application.Services;

namespace ServicoColeta.Api.Endpoints;

public static class ApiEndpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapPost("/pesquisas_publicas/enviar_resposta",
                async (
                    [FromServices] PublicacaoRespostasService pesquisaService,
                    [FromBody] PesquisaRespondidaEvent pesquisaRespondidaEvent) =>
                {
                    await pesquisaService.Publicar(pesquisaRespondidaEvent);
                    return Results.Ok();
                })
            .WithName("EnviarResposta");
    }
}