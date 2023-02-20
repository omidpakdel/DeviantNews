using DeviantNews.Domain.Common;

namespace DeviantNews.Domain.Entities;

public class Article : BaseEntity
{
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }

    public string Title { get; set; }
    public string Content { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<Tag> Tags { get; set; }
}