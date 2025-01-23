using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BL.DTOs.UserDTO;

public class RegisterDTO
{
    [Required]
    [StringLength(20)]
    
    public string FirstName { get; set; }
    [Required]
    [StringLength(20)]
    public string LastName { get; set; }
    [Required]
    [StringLength(20)]
    [RegularExpression(@"@_$%")]
    [EmailAddress(ErrorMessage ="Invalid Email address")]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

}
