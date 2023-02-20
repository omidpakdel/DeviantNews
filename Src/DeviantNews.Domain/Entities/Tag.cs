namespace DeviantNews.Domain.Entities;

public class Tag
{
    public string Title { get; set; }

    public ICollection<Article> Articles { get; set; }
}