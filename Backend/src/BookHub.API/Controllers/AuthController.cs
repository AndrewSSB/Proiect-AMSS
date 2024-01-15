using Microsoft.AspNetCore.Mvc;
using BookHub.BLL.Interfaces;
using BookHub.BLL.Models;
using BookHub.Services.Models;
using System.Threading.Tasks;

namespace BookHub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthManager _authManager;

    public AuthController(IAuthManager authManager)
    {
        _authManager = authManager;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
    {
        var result = await _authManager.Register(registerModel);
        return result ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
    {
        var result = await _authManager.Login(loginModel);

        return result != null ? Ok(result) : BadRequest("Failed to login");
        
    }

    [HttpPost("CreateRole")]
    public async Task<IActionResult> CreateRole([FromBody] RoleModel roleModel)
    {
        var result = await _authManager.CreateRole(roleModel);

        return result ? Ok("Role created successfully") : BadRequest("Failed to create role");
    }
}