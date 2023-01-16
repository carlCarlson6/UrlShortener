using Backend.UrlShortener.Domain;

namespace Backend.UrlShortener.Application;

public class SaveShortUrl
{
    private readonly IShortUrlRepository _repo;
    public SaveShortUrl(IShortUrlRepository repo) => _repo = repo;

    public async Task Execute(SaveShortUrlCommand command)
    {
        var maybeShortUrl = await _repo.Find(command.Slug);
        if (maybeShortUrl is not null)
            throw new Exception(); // create proper exception

        await _repo.Save(new ShortUrl(command.Slug, command.Url));
    }
}