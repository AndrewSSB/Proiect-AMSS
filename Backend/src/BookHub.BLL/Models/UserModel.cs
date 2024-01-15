using BookHub.DAL.Entities;
using BookHub.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Services.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
