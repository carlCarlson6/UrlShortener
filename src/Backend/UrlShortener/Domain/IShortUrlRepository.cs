namespace Backend.UrlShortener.Domain;

public interface IShortUrlRepository
{
    Task Save(ShortUrl shortUrl);
    Task<ShortUrl?> Find(Slug slug);
}