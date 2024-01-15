using BookHub.BLL.DTOs;
using BookHub.BLL.Interfaces;
using BookHub.BLL.Models;
using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BLL.Managers;
public class FriendshipManager : IFriendshipManager
{
    private readonly IFriendshipRepository friendshipRepository;

    public FriendshipManager(IFriendshipRepository friendshipRepository)
    {
        this.friendshipRepository = friendshipRepository;
    }
    public void AddFriendship(FriendshipModel model)
    {
        var newFriendship = new Friendship
        {
            UserId = model.UserId,
            FriendId = model.FriendId
        };

        friendshipRepository.AddFriendship(newFriendship);
    }

    public List<FriendshipGetDTO> GetAllFriendships()
    {
        return friendshipRepository.GetFriendshipsToList();
    }

    public Friendship GetFriendshipById(int id)
    {
        return friendshipRepository.GetFriendshipById(id);
    }

    public void DeleteFriendship(int id)
    {
        var friendship = GetFriendshipById(id);
        friendshipRepository.DeleteFriendship(friendship);
    }
}