using System.ComponentModel.DataAnnotations;

namespace DeviantNews.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    
    [Encrypted]
    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    [Encrypted]
    public string? LastModifiedBy { get; set; }

    public DateTime? LastModified { get; set; }

}