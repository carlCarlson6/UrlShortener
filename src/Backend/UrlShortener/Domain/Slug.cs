namespace Backend.UrlShortener.Domain;

public readonly struct Slug
{
    private readonly string _value;

    public Slug(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException(nameof(value));
        _value = value;
    }

    public override string ToString() => _value;
}