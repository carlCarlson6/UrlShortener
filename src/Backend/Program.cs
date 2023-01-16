using Backend.Presentation;
using Backend.UrlShortener.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddUrlShortener()
    .AddGrpc();

builder
    .Build()
    .MapGrpc()
    .Run();