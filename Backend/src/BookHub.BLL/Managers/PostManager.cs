using BookHub.BLL.Interfaces;
using BookHub.Infrastructure.Entities;
using BookHub.Services.Interfaces;
using BookHub.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Services.Managers;

public class PostManager : IPostManager
{
    private readonly IPostRepository postRepository;
    private readonly IUserRepository userRepository;

    public PostManager(IPostRepository postRepository, IUserRepository userRepository)
    {
        this.postRepository = postRepository;
        this.userRepository = userRepository;
    }

    public List<Post> GetAllUserPosts(int id)
    {
        return postRepository.GetAllUserPostsIQueryable(id).ToList();
    }

    public List<Post> GetAllPosts()
    {
        return postRepository.GetAllPostsIQueryable().ToList();
    }

    public Post GetPostById(int id)
    {
        return postRepository.GetPostById(id);
    }

    public void CreatePost(PostModel model)
    {
        var newPost = new Post
        {
            UserId = model.UserId,
            Description = model.Description,
            ImagePath = model.ImagePath,
        };

        string userName = userRepository.GetUserNameById(newPost.UserId);

        newPost.UserName = userName;
        newPost.PublishDate = DateTime.Now;

        postRepository.CreatePost(newPost);
    }

    public void UpdatePost(PostModel model)
    {
        var post = GetPostById(model.Id);
        if (model.Description != "")
            post.Description = model.Description;
        if (model.ImagePath != "")
            post.ImagePath = model.ImagePath;

        postRepository.UpdatePost(post);
    }

    public void DeletePost(int id)
    {
        var post = GetPostById(id);
        postRepository.DeletePost(post);
    }

}