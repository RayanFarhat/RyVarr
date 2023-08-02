using System.ComponentModel.DataAnnotations;
namespace BackendServer.Authentication;

public class RegisterModel
{
    [Required(ErrorMessage = "User Name is required")]
    public string Username { get; set; } = "";

    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password should be at least 8 long")]
    [Containlower(ErrorMessage = "Password should contain at least one lower char")]
    [ContainUpper(ErrorMessage = "Password should contain at least one upper char")]
    [ContainNumber(ErrorMessage = "Password should contain at least one digit")]
    [ContainSymbol(ErrorMessage = "Password should contain at least one symbol(non-word char)")]
    [ContainSpace(ErrorMessage = "Password should not contain spaces")]
    public string Password { get; set; } = "";

}
