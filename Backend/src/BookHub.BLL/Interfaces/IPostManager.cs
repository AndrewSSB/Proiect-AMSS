using Microsoft.Extensions.Hosting;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Models;
using System.Collections.Generic;

namespace BookHub.Services.Interfaces;

public interface IPostManager
{
    List<Post> GetAllUserPosts(int id);
    Post GetPostById(int id);
    void CreatePost(PostModel model);
    void UpdatePost(PostModel model);
    public void DeletePost(int id);
    List<Post> GetAllPosts();
}