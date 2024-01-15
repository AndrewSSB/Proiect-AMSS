using BookHub.BLL.DTOs;
using BookHub.BLL.Interfaces;
using BookHub.DAL;
using BookHub.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookHub.BLL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext db;

        public UserRepository(AppDbContext db)
        {
            this.db = db;
        }

        public List<UserDTO> GetAllUsersToList()
        {
            var users = db.Users;
            var result = new List<UserDTO>();
            foreach (var user in users)
            {
                var userDto = new UserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                };
                result.Add(userDto);
            }
            return result;
        }

        public User GetUserById(int id)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void DeleteUser(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public string GetUserNameById(int id)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            string userName = user.UserName;

            return userName;
        }
    }
}
