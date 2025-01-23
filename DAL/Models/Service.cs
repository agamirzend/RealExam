using DAL.Models.Base;

namespace DAL.Models;

public class Service : BaseAuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Worker> Workers { get; set; }
}
