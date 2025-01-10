using PesquisaPublica.ServicoColeta.Api.Endpoints;
using ServicoColeta.Application;
using PesquisaPublica.ServicoColeta.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapEndpoints();

app.UseHttpsRedirection();

app.Run();