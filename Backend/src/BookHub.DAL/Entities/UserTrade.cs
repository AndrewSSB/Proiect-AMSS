using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Infrastructure.Entities
{
    public class UserTrade
    {
        public User? UserBy { get; set; }
        public int? UserById { get; set; }
        public User? UserFor { get; set; }
        public int? UserForId { get; set; }
        public Trade? Trade { get; set; }
        public int? TradeId { get; set;}
    }
}
