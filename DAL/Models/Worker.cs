using DAL.Models.Base;
using System.ComponentModel;

namespace DAL.Models;

public class Worker : BaseAuditableEntity
{
    [DisplayName("Full Name")]
    public string Name { get; set; }
    public string ImgPath { get; set; }
    public Service Service { get; set; }
    public int ServiceId { get; set; }

}
