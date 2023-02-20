using DeviantNews.Domain.Common;

namespace DeviantNews.Domain.Entities;

public class Follower : BaseEntity
{
    public Guid UserId { get; set; }

    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
}