using System.ComponentModel.DataAnnotations;

namespace RestfulAPI.Identity.Contracts.v1.Request;

public class SignInRequest
{
    [Required(ErrorMessage = "User Name is required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }
}
