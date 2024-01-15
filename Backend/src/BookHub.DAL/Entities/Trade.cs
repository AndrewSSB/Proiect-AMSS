using BookHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Infrastructure.Entities
{
    public class Trade
    {
        public int TradeId { get; set; }
        public int? UserById { get; set; }
        public User? UserBy { get; set; }
        public int? UserForId { get; set; }
        public User? UserFor { get; set; }
        public int? MeetingId { get; set; }
        public Meeting? Meeting { get; set; }
        public virtual ICollection<UserTrade> UserTrades { get; set; }

        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
