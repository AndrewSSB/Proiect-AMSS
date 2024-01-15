using Microsoft.AspNetCore.Mvc;
using BookHub.BLL.DTOs;
using BookHub.BLL.Interfaces;
using System.Threading.Tasks;

namespace BookHub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager manager;

    public UserController(IUserManager userManager)
    {
        this.manager = userManager;
    }

    [HttpPost("send-email")]
    public async Task<IActionResult> SendEmail([FromBody] EmailReceiverDTO emailDto)
    {
        await manager.SendEmailTemplate(emailDto);
        return Ok("Email Sent!");
    }
}
