using Microsoft.AspNetCore.Mvc;
using BookHub.DAL;
using BookHub.Services.Interfaces;
using BookHub.Services.Models;
using System.Threading.Tasks;

namespace BookHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostManager manager;

    public PostController(IPostManager postManager, AppDbContext context)
    {
        this.manager = postManager;
    }

    [HttpGet("GetAllUser{id}Posts")]
    public async Task<IActionResult> GetUserPosts([FromRoute] int id)
    {
        var posts = manager.GetAllUserPosts(id);

        return Ok(posts);
    }

    [HttpGet("GetAllPosts")]
    public async Task<IActionResult> GetAll()
    {
        var posts = manager.GetAllPosts();
        return Ok(posts);
    }


    [HttpPost("CreatePost")]
    public async Task<IActionResult> CreatePost([FromBody] PostModel postModel)
    {
        manager.CreatePost(postModel);
        return Ok();
    }

    [HttpPut("UpdatePostById")]
    public async Task<IActionResult> UpdatePost([FromBody] PostModel postModel)
    {
        manager.UpdatePost(postModel);
        return Ok();
    }

    [HttpDelete("DeletePostBy{id}")]
    public async Task<IActionResult> DeletePost([FromRoute] int id)
    {
        manager.DeletePost(id);
        return Ok();
    }
}