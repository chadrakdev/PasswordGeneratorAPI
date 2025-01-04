using Microsoft.AspNetCore.Mvc;
using PasswordGeneratorAPI.Models;
using PasswordGeneratorAPI.Services;

namespace PasswordGeneratorAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PasswordController : ControllerBase
{
    private readonly PasswordGeneratorService _passwordGeneratorService;

    public PasswordController(PasswordGeneratorService passwordGeneratorService)
    {
        this._passwordGeneratorService = passwordGeneratorService;
    }

    [HttpPost("generate")]
    public ActionResult<string> GeneratePassword([FromBody] PasswordCriteria criteria)
    {
        if (criteria.MaxLength < criteria.MinLength || criteria.MinLength < 1)
        {
            return BadRequest("Invalid password length range.");
        }

        var password = _passwordGeneratorService.GeneratePassword(criteria);
        return Ok(password);
    }
}