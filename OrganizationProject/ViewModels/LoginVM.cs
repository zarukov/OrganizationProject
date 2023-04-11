using System.ComponentModel.DataAnnotations;

namespace OrganizationProject.ViewModels;

public class LoginVM
{
    [EmailAddress]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "{0} is wrong. Try again.")]
    public string Password { get; set; }
}
