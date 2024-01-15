using BookHub.BLL.DTOs;
using BookHub.DAL.Entities;
using System.Collections.Generic;

namespace BookHub.BLL.Interfaces;

public interface IUserRepository
{
    List<UserDTO> GetAllUsersToList();
    User GetUserById(int id);
    string GetUserNameById(int id);
    void DeleteUser(User user);
}
