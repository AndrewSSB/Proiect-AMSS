using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Infrastructure.Entities
{
    public class Trade
    {
        public int TradeId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
        public virtual ICollection<UserTrade> UserTrades { get; set; }

        public bool acceptedUser1 { get; set; }
        public bool acceptedUser2 { get; set; }
    }
}
