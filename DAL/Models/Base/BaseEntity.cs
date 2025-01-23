namespace DAL.Models.Base;

public abstract class BaseEntity 
{
    public int Id { get; set; }
    public string IsDeleted { get; set; }
}
