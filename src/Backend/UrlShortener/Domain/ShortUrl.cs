namespace Backend.UrlShortener.Domain;

public class ShortUrl
{
    public Slug Slug { get; }
    public Uri Url { get; }
    
    
    public ShortUrl(Slug slug, Uri url)
    {
        Slug = slug;
        Url = url;
    }
}