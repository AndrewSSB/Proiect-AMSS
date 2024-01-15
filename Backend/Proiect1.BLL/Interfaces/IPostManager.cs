using Microsoft.Extensions.Hosting;
using Proiect1.Infrastructure.Entities;
using Proiect1.Services.Models;
using System.Collections.Generic;

namespace Proiect1.Services.Interfaces;

public interface IPostManager
{
    List<Post> GetAllUserPosts(int id);
    Post GetPostById(int id);
    void CreatePost(PostModel model);
    void UpdatePost(PostModel model);
    public void DeletePost(int id);
    List<Post> GetAllPosts();
}