using Backend.gRpc.Greet;
using Backend.gRpc.Url;

namespace Backend.Presentation;

public static class WebAppExtensions
{
    public static WebApplication MapGrpc(this WebApplication webApp)
    {
        webApp.MapGrpcService<GreeterService>();
        webApp.MapGrpcService<UrlPresentation>();
        return webApp;
    }
}