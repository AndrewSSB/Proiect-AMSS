using BookHub.BLL.DTOs;
using BookHub.BLL.Models;
using BookHub.DAL.Entities;
using System.Collections.Generic;

namespace BookHub.BLL.Interfaces;

public interface IFriendshipManager
{
    void AddFriendship(FriendshipModel model);
    List<FriendshipGetDTO> GetAllFriendships();
    void DeleteFriendship(int id);
    Friendship GetFriendshipById(int id);

}
