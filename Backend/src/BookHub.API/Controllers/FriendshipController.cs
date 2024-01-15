using Microsoft.AspNetCore.Mvc;
using BookHub.BLL.Interfaces;
using BookHub.BLL.Models;
using System.Threading.Tasks;

namespace BookHub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FriendshipController : ControllerBase
{
    private readonly IFriendshipManager manager;
    public FriendshipController(IFriendshipManager friendshipManager)
    {
        this.manager = friendshipManager;
    }

    [HttpPost("CreateFriendship")]
    public async Task<IActionResult> AddFriendship([FromBody] FriendshipModel friendshipModel)
    {
        manager.AddFriendship(friendshipModel);
        return Ok();
    }

    [HttpGet("GetAllFriendships")]
    public async Task<IActionResult> GetAllFriendships()
    {
        var friendships = manager.GetAllFriendships();
        return Ok(friendships);
    }

    [HttpDelete("DeleteFriendshipBy{id}")]
    public async Task<IActionResult> DeleteFriendship([FromRoute] int id)
    {
        manager.DeleteFriendship(id);
        return Ok();
    }
}