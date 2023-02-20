using DeviantNews.Domain.Common;
using DeviantNews.Domain.Enums;

namespace DeviantNews.Domain.Entities;

public class Category : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Code { get; set; }

    public Guid? ParentId { get; set; }
    public Category? Parent { get; set; }

    public StatusTypes Status { get; set; }

    public ICollection<Category>? Children { get; set; }
}