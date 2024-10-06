using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using Validation.Validators;
using Validation.Models;

namespace Validation.Controllers;



[Route("/api/[controller]")]
[ApiController]
public class UsersController : Controller
{
    [HttpPost("Register")]
    public IActionResult Register(UserModel model)
    {
        var validator = new RegisterValidator();
        var result = validator.Validate(model);
        if (!result.IsValid)
            return BadRequest(result.Errors);
        return Ok("Registration Successful");
    }
}
