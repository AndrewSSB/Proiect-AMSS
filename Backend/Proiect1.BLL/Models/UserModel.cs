using Proiect1.DAL.Entities;
using Proiect1.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
