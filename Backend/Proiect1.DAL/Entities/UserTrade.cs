using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Infrastructure.Entities
{
    public class UserTrade
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Trade Trade { get; set; }
        public int TradeId { get; set;}
    }
}
