using System.ComponentModel.DataAnnotations;

namespace OrganizationProject.ViewModels;

public class RegisterVM
{
    [Display(Name = "Student Number")]
    [Required(ErrorMessage = "Student Number Must be Filled")]
    public string NIM { get; set; }
    [Display(Name = "Full Name")]
    [Required(ErrorMessage = "Name Must be Filled.")]
    public string Name { get; set; }
    [Display(Name = "Major Name")]
    [Required(ErrorMessage = "Major Name Must be Filled.")]
    public string MajorName { get; set; }
    [Display(Name = "Birth Date")]
    public DateTime BirthDate { get; set; }
    [Display(Name = "Title Name")]
    [Required(ErrorMessage = "Title Name Must be Filled.")]
    public string TitleName { get; set; }
    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone Number Must be Filled.")]
    public string PhoneNumber { get; set; }
    [Display(Name = "Address")]
    [Required(ErrorMessage = "Address Must be Filled.")]
    public string Address { get; set; }
    [EmailAddress]
    [Required(ErrorMessage = "Email Must Be Filled")]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [StringLength(12, ErrorMessage = "The {0} Must Be Filled Between {2} and {1} Characters.", MinimumLength = 6)]
    public string Password { get; set; }
    [Display(Name = "Password Confirmation")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "The Password Confirmation Did Not Match With the Password. Please Try Again.")]
    public string PasswordConfirm { get; set; }
}
