using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Interfaces;

public interface IPostRepository
{
    IQueryable<Post> GetAllUserPostsIQueryable(int id);
    Post GetPostById(int id);
    void CreatePost(Post post);
    void UpdatePost(Post post);
    void DeletePost(Post post);
    IQueryable<Post> GetAllPostsIQueryable();
}