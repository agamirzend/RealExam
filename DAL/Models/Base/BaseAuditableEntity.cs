namespace DAL.Models.Base;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get; set; }
 
    public DateTime? DeletedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}