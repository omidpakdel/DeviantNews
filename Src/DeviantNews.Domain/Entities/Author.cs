using DeviantNews.Domain.Common;

namespace DeviantNews.Domain.Entities;

public class Author : BaseEntity
{
    public Guid UserId { get; set; }

    public string Name { get; set; }

    public ICollection<Article>? Articles { get; set; }
    public ICollection<Follower>? Followers { get; set; }
}