using Backend.UrlShortener.Application;
using Backend.UrlShortener.Domain;
using Grpc.Core;

namespace Backend.gRpc.Url;

public class UrlPresentation : UrlCreator.UrlCreatorBase
{
    private readonly SaveShortUrl _save;

    public UrlPresentation(SaveShortUrl save) => _save = save;

    public override async Task<ShortUrlResponse> Short(ShortUrlRequest request, ServerCallContext _)
    {
        var slug = new Slug(request.Slug);
        await _save.Execute(new SaveShortUrlCommand(new Uri(request.Url), slug));
        return new ShortUrlResponse { Slug = slug.ToString() };
    }
}