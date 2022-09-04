using System.ComponentModel.DataAnnotations;
using RestfulAPI.Identity.Contracts.Common;
using RestfulAPI.Identity.Domain;

namespace RestfulAPI.Identity.Contracts.v1.Request;

public class SignUpResponse: Response
{
    public User? User { get; set; }
}
