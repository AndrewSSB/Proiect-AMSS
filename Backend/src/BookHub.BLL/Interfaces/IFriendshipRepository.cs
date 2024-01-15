using BookHub.BLL.DTOs;
using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BLL.Interfaces;

public interface IFriendshipRepository
{
    void AddFriendship(Friendship friendship);
    List<FriendshipGetDTO> GetFriendshipsToList();
    void DeleteFriendship(Friendship friendship);
    Friendship GetFriendshipById(int id);
}
