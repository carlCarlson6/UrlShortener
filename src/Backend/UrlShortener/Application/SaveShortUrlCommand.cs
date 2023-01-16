using Backend.UrlShortener.Domain;

namespace Backend.UrlShortener.Application;

public record SaveShortUrlCommand(Uri Url, Slug Slug);