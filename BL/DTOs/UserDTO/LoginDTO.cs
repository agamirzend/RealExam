using System.ComponentModel.DataAnnotations;

namespace BL.DTOs.UserDTO;

public class LoginDTO
{
    [Required]
 
    [StringLength(20)]
    [RegularExpression(@"@_$%")]
    [EmailAddress(ErrorMessage = "Invalid Email address")]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

}
