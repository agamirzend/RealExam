using DAL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class AppUser : BaseAuditableEntity
{
    [Required]
    [StringLength(20)]

    public string UserName { get; set; }
    [Required]
    [StringLength(20)]
    [RegularExpression(@"_$%", ErrorMessage ="Invalid password")]
    public string Password { get; set; }
}
