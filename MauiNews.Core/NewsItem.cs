namespace MauiNews.Core;

public record NewsItem
{
    public NewsItem(string title, string preamble, string text)
    {
        Title = title;
        Preamble = preamble;
        Text = text;
    }

    public string Title { get; init; }
    public string Preamble { get; init; }
    public string Text { get; init; }
    public string? ImageUrl { get; init; }
}

