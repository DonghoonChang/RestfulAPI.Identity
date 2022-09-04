using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Identity.Contracts.Common;
using RestfulAPI.Identity.Contracts.v1.Request;
using RestfulAPI.Identity.Domain;

namespace RestfulAPI.Identity.Api.Controllers;

public class AuthController : Controller
{
    public IActionResult Index()
    {
        return Ok();
    }

    [HttpPost(ApiRoutes.V1.Authentication.SignUp)]
    public async Task<ActionResult<SignUpResponse>> SignUp(SignUpRequest request)
    {
        CreatePasswordHash(request.Password, out byte[] hash, out byte[] salt);
        var newUser = new User{
            UserName = request.UserName,
            PasswordHash = hash,
            PasswordSalt = salt
        };
        var response = new SignUpResponse
        {
            User = newUser
        };

        return Ok(response);
    }

    [HttpPost(ApiRoutes.V1.Authentication.SignIn)]
    public async Task<ActionResult<SignInResponse>> SignIn(SignInRequest request)
    {
        await Task.CompletedTask;

        return Ok();
    }

    private void CreatePasswordHash(string password, out byte[] hash, out byte[] salt)
    {
        using var hmac = new HMACSHA512();
        salt = hmac.Key;
        hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    }

    private bool VerifyPasswordHash(string password, byte[] salt, byte[] hash)
    {
        using var hmac = new HMACSHA512(salt);
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return computedHash == hash;
    }
}
