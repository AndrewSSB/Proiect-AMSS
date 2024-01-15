using BookHub.BLL.Interfaces;
using BookHub.DAL;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookHub.Services.Repositories;

public class PostRepository : IPostRepository
{
    private readonly AppDbContext db;


    public PostRepository(AppDbContext db, IUserRepository userRepository)
    {
        this.db = db;

    }

    public IQueryable<Post> GetAllPostsIQueryable()
    {
        var posts = db.Posts
            .OrderByDescending(x => x.PublishDate);

        return posts;
    }

    public IQueryable<Post> GetAllUserPostsIQueryable(int id)
    {
        var posts = db.Posts
            .Where(x => (x.UserId == id))
            .OrderByDescending(x => x.PublishDate);

        return posts;
    }

    public Post GetPostById(int id)
    {
        var post = db.Posts
            .FirstOrDefault(x => x.Id == id);

        return post;
    }

    public void CreatePost(Post post)
    {
        db.Posts.Add(post);
        db.SaveChanges();
    }

    public void UpdatePost(Post post)
    {
        db.Posts.Update(post);
        db.SaveChanges();
    }

    public void DeletePost(Post post)
    {
        db.Posts.Remove(post);
        db.SaveChanges();
    }

}